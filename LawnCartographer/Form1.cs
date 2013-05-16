using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EVE.Net;


namespace LawnCartography
{
    public partial class LawnCartographer : Form
    {
        List<string> UsedIntel = new List<string>();
        List<string> filenames = new List<string> { "brncfc", "vnlcfc", "dekcfc", "tnlcfc" };

        public string LogFolder;
        public string Username;
        public string Password;

        public LawnCartographer()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy && Validate && Username != "" && Password != "")
            {
                listBox1.Items.Clear();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
            txtPassword.Text = Password;
            CheckValid();
        }

        protected void CheckValid()
        {
            if (Validate)
            {
                lblValidate.Text = "Valid";
                lblValidate.ForeColor = Color.Green;
            }
            else
            {
                lblValidate.Text = "Invalid";
                lblValidate.ForeColor = Color.Red;
            }
            Properties.Settings.Default.LogFolder = LogFolder;
            Properties.Settings.Default.Save();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }


        public new bool Validate
        {
            get
            {
                try
                {
                    List<string> Chatlogs = Directory.GetFiles(LogFolder).Select(a => a.ToLower()).ToList();
                    ChatEqualityComparer chatcompare = new ChatEqualityComparer();
                    return filenames.Intersect(Chatlogs, chatcompare).Any();
                }
                catch
                {
                    return false;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (DataBaseDataContext DataBase = new DataBaseDataContext())
                {
                    backgroundWorker1.ReportProgress(0, "Starting Update");

                    List<SolarSystem> Regions = DataBase.SolarSystems.Where(a => a.regionID == 10000055 || a.regionID == 10000015 || a.regionID == 10000035 || a.regionID == 10000045).ToList();
                    List<string> Chatlogs = Directory.GetFiles(LogFolder).Select(a => a.ToLower()).ToList();

                    List<Upload.KeyValuePairs> Updates = new List<Upload.KeyValuePairs>();


                    foreach (string file in filenames)
                    {
                        backgroundWorker1.ReportProgress(0, "Parsing " + file);
                        using (var fs = new FileStream(Chatlogs.Where(a => a.Contains(file)).OrderByDescending(a => a.ToString()).FirstOrDefault(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        using (var sr = new StreamReader(fs, Encoding.Default))
                        {
                            while (!sr.EndOfStream)
                            {
                                string Data = sr.ReadLine();
                                if (Data.Contains("EVE System > Channel MOTD") || UsedIntel.Contains(Data))
                                {
                                    continue;
                                }
                                UsedIntel.Add(Data);

                                SolarSystem Match = Regions.FirstOrDefault(a => Data.ToLower().Contains(a.solarSystemName.ToLower()));
                                if (Match != null)
                                {
                                    Upload.KeyValuePairs U = new Upload.KeyValuePairs();
                                    U.KEY = Match.solarSystemID;
                                    U.VALUE = Data.Substring(1);

                                    Updates.Add(U);
                                }
                            }
                        }
                    }





                    backgroundWorker1.ReportProgress(0, "Uploading data");

                    using (Upload.UpdateSoapClient Up = new Upload.UpdateSoapClient())
                    {
                        if (Up.Upload(Updates.ToArray(), Username, Password))
                        {
                            backgroundWorker1.ReportProgress(0, "Completed update");
                        }
                        else
                        {
                            backgroundWorker1.ReportProgress(0, "Upload failed - check settings");
                            timer1.Stop();
                        }
                    }



                }



            }
            catch (Exception ex)
            {
                backgroundWorker1.ReportProgress(0, ex.Message);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listBox1.Items.Add(e.UserState.ToString());
            listBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            LogFolder = folderBrowserDialog1.SelectedPath;
            CheckValid();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Properties.Settings.Default.Username = Username;
            Properties.Settings.Default.Save();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Password = txtPassword.Text;
            Properties.Settings.Default.Password = Password;
            Properties.Settings.Default.Save();
        }





    }

    class ChatEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string s1, string s2)
        {
            if (s1.Contains(s2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(string s)
        {
            return 0;
        }
    }
}
