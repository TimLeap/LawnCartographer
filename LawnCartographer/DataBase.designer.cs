﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LawnCartography
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LawnAtlas")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSolarSystem(SolarSystem instance);
    partial void UpdateSolarSystem(SolarSystem instance);
    partial void DeleteSolarSystem(SolarSystem instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::LawnCartography.Properties.Settings.Default.LawnAtlasConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SolarSystem> SolarSystems
		{
			get
			{
				return this.GetTable<SolarSystem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Control.SolarSystems")]
	public partial class SolarSystem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _regionID;
		
		private System.Nullable<int> _constellationID;
		
		private int _solarSystemID;
		
		private string _solarSystemName;
		
		private System.Nullable<double> _x;
		
		private System.Nullable<double> _y;
		
		private System.Nullable<double> _z;
		
		private System.Nullable<double> _xMin;
		
		private System.Nullable<double> _xMax;
		
		private System.Nullable<double> _yMin;
		
		private System.Nullable<double> _yMax;
		
		private System.Nullable<double> _zMin;
		
		private System.Nullable<double> _zMax;
		
		private System.Nullable<double> _luminosity;
		
		private System.Nullable<bool> _border;
		
		private System.Nullable<bool> _fringe;
		
		private System.Nullable<bool> _corridor;
		
		private System.Nullable<bool> _hub;
		
		private System.Nullable<bool> _international;
		
		private System.Nullable<bool> _regional;
		
		private System.Nullable<bool> _constellation;
		
		private System.Nullable<double> _security;
		
		private System.Nullable<int> _factionID;
		
		private System.Nullable<double> _radius;
		
		private System.Nullable<int> _sunTypeID;
		
		private string _securityClass;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnregionIDChanging(System.Nullable<int> value);
    partial void OnregionIDChanged();
    partial void OnconstellationIDChanging(System.Nullable<int> value);
    partial void OnconstellationIDChanged();
    partial void OnsolarSystemIDChanging(int value);
    partial void OnsolarSystemIDChanged();
    partial void OnsolarSystemNameChanging(string value);
    partial void OnsolarSystemNameChanged();
    partial void OnxChanging(System.Nullable<double> value);
    partial void OnxChanged();
    partial void OnyChanging(System.Nullable<double> value);
    partial void OnyChanged();
    partial void OnzChanging(System.Nullable<double> value);
    partial void OnzChanged();
    partial void OnxMinChanging(System.Nullable<double> value);
    partial void OnxMinChanged();
    partial void OnxMaxChanging(System.Nullable<double> value);
    partial void OnxMaxChanged();
    partial void OnyMinChanging(System.Nullable<double> value);
    partial void OnyMinChanged();
    partial void OnyMaxChanging(System.Nullable<double> value);
    partial void OnyMaxChanged();
    partial void OnzMinChanging(System.Nullable<double> value);
    partial void OnzMinChanged();
    partial void OnzMaxChanging(System.Nullable<double> value);
    partial void OnzMaxChanged();
    partial void OnluminosityChanging(System.Nullable<double> value);
    partial void OnluminosityChanged();
    partial void OnborderChanging(System.Nullable<bool> value);
    partial void OnborderChanged();
    partial void OnfringeChanging(System.Nullable<bool> value);
    partial void OnfringeChanged();
    partial void OncorridorChanging(System.Nullable<bool> value);
    partial void OncorridorChanged();
    partial void OnhubChanging(System.Nullable<bool> value);
    partial void OnhubChanged();
    partial void OninternationalChanging(System.Nullable<bool> value);
    partial void OninternationalChanged();
    partial void OnregionalChanging(System.Nullable<bool> value);
    partial void OnregionalChanged();
    partial void OnconstellationChanging(System.Nullable<bool> value);
    partial void OnconstellationChanged();
    partial void OnsecurityChanging(System.Nullable<double> value);
    partial void OnsecurityChanged();
    partial void OnfactionIDChanging(System.Nullable<int> value);
    partial void OnfactionIDChanged();
    partial void OnradiusChanging(System.Nullable<double> value);
    partial void OnradiusChanged();
    partial void OnsunTypeIDChanging(System.Nullable<int> value);
    partial void OnsunTypeIDChanged();
    partial void OnsecurityClassChanging(string value);
    partial void OnsecurityClassChanged();
    #endregion
		
		public SolarSystem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_regionID", DbType="Int")]
		public System.Nullable<int> regionID
		{
			get
			{
				return this._regionID;
			}
			set
			{
				if ((this._regionID != value))
				{
					this.OnregionIDChanging(value);
					this.SendPropertyChanging();
					this._regionID = value;
					this.SendPropertyChanged("regionID");
					this.OnregionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_constellationID", DbType="Int")]
		public System.Nullable<int> constellationID
		{
			get
			{
				return this._constellationID;
			}
			set
			{
				if ((this._constellationID != value))
				{
					this.OnconstellationIDChanging(value);
					this.SendPropertyChanging();
					this._constellationID = value;
					this.SendPropertyChanged("constellationID");
					this.OnconstellationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_solarSystemID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int solarSystemID
		{
			get
			{
				return this._solarSystemID;
			}
			set
			{
				if ((this._solarSystemID != value))
				{
					this.OnsolarSystemIDChanging(value);
					this.SendPropertyChanging();
					this._solarSystemID = value;
					this.SendPropertyChanged("solarSystemID");
					this.OnsolarSystemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_solarSystemName", DbType="NVarChar(100)")]
		public string solarSystemName
		{
			get
			{
				return this._solarSystemName;
			}
			set
			{
				if ((this._solarSystemName != value))
				{
					this.OnsolarSystemNameChanging(value);
					this.SendPropertyChanging();
					this._solarSystemName = value;
					this.SendPropertyChanged("solarSystemName");
					this.OnsolarSystemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_x", DbType="Float")]
		public System.Nullable<double> x
		{
			get
			{
				return this._x;
			}
			set
			{
				if ((this._x != value))
				{
					this.OnxChanging(value);
					this.SendPropertyChanging();
					this._x = value;
					this.SendPropertyChanged("x");
					this.OnxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_y", DbType="Float")]
		public System.Nullable<double> y
		{
			get
			{
				return this._y;
			}
			set
			{
				if ((this._y != value))
				{
					this.OnyChanging(value);
					this.SendPropertyChanging();
					this._y = value;
					this.SendPropertyChanged("y");
					this.OnyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_z", DbType="Float")]
		public System.Nullable<double> z
		{
			get
			{
				return this._z;
			}
			set
			{
				if ((this._z != value))
				{
					this.OnzChanging(value);
					this.SendPropertyChanging();
					this._z = value;
					this.SendPropertyChanged("z");
					this.OnzChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xMin", DbType="Float")]
		public System.Nullable<double> xMin
		{
			get
			{
				return this._xMin;
			}
			set
			{
				if ((this._xMin != value))
				{
					this.OnxMinChanging(value);
					this.SendPropertyChanging();
					this._xMin = value;
					this.SendPropertyChanged("xMin");
					this.OnxMinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xMax", DbType="Float")]
		public System.Nullable<double> xMax
		{
			get
			{
				return this._xMax;
			}
			set
			{
				if ((this._xMax != value))
				{
					this.OnxMaxChanging(value);
					this.SendPropertyChanging();
					this._xMax = value;
					this.SendPropertyChanged("xMax");
					this.OnxMaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_yMin", DbType="Float")]
		public System.Nullable<double> yMin
		{
			get
			{
				return this._yMin;
			}
			set
			{
				if ((this._yMin != value))
				{
					this.OnyMinChanging(value);
					this.SendPropertyChanging();
					this._yMin = value;
					this.SendPropertyChanged("yMin");
					this.OnyMinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_yMax", DbType="Float")]
		public System.Nullable<double> yMax
		{
			get
			{
				return this._yMax;
			}
			set
			{
				if ((this._yMax != value))
				{
					this.OnyMaxChanging(value);
					this.SendPropertyChanging();
					this._yMax = value;
					this.SendPropertyChanged("yMax");
					this.OnyMaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zMin", DbType="Float")]
		public System.Nullable<double> zMin
		{
			get
			{
				return this._zMin;
			}
			set
			{
				if ((this._zMin != value))
				{
					this.OnzMinChanging(value);
					this.SendPropertyChanging();
					this._zMin = value;
					this.SendPropertyChanged("zMin");
					this.OnzMinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zMax", DbType="Float")]
		public System.Nullable<double> zMax
		{
			get
			{
				return this._zMax;
			}
			set
			{
				if ((this._zMax != value))
				{
					this.OnzMaxChanging(value);
					this.SendPropertyChanging();
					this._zMax = value;
					this.SendPropertyChanged("zMax");
					this.OnzMaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_luminosity", DbType="Float")]
		public System.Nullable<double> luminosity
		{
			get
			{
				return this._luminosity;
			}
			set
			{
				if ((this._luminosity != value))
				{
					this.OnluminosityChanging(value);
					this.SendPropertyChanging();
					this._luminosity = value;
					this.SendPropertyChanged("luminosity");
					this.OnluminosityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_border", DbType="Bit")]
		public System.Nullable<bool> border
		{
			get
			{
				return this._border;
			}
			set
			{
				if ((this._border != value))
				{
					this.OnborderChanging(value);
					this.SendPropertyChanging();
					this._border = value;
					this.SendPropertyChanged("border");
					this.OnborderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fringe", DbType="Bit")]
		public System.Nullable<bool> fringe
		{
			get
			{
				return this._fringe;
			}
			set
			{
				if ((this._fringe != value))
				{
					this.OnfringeChanging(value);
					this.SendPropertyChanging();
					this._fringe = value;
					this.SendPropertyChanged("fringe");
					this.OnfringeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_corridor", DbType="Bit")]
		public System.Nullable<bool> corridor
		{
			get
			{
				return this._corridor;
			}
			set
			{
				if ((this._corridor != value))
				{
					this.OncorridorChanging(value);
					this.SendPropertyChanging();
					this._corridor = value;
					this.SendPropertyChanged("corridor");
					this.OncorridorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hub", DbType="Bit")]
		public System.Nullable<bool> hub
		{
			get
			{
				return this._hub;
			}
			set
			{
				if ((this._hub != value))
				{
					this.OnhubChanging(value);
					this.SendPropertyChanging();
					this._hub = value;
					this.SendPropertyChanged("hub");
					this.OnhubChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_international", DbType="Bit")]
		public System.Nullable<bool> international
		{
			get
			{
				return this._international;
			}
			set
			{
				if ((this._international != value))
				{
					this.OninternationalChanging(value);
					this.SendPropertyChanging();
					this._international = value;
					this.SendPropertyChanged("international");
					this.OninternationalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_regional", DbType="Bit")]
		public System.Nullable<bool> regional
		{
			get
			{
				return this._regional;
			}
			set
			{
				if ((this._regional != value))
				{
					this.OnregionalChanging(value);
					this.SendPropertyChanging();
					this._regional = value;
					this.SendPropertyChanged("regional");
					this.OnregionalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_constellation", DbType="Bit")]
		public System.Nullable<bool> constellation
		{
			get
			{
				return this._constellation;
			}
			set
			{
				if ((this._constellation != value))
				{
					this.OnconstellationChanging(value);
					this.SendPropertyChanging();
					this._constellation = value;
					this.SendPropertyChanged("constellation");
					this.OnconstellationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_security", DbType="Float")]
		public System.Nullable<double> security
		{
			get
			{
				return this._security;
			}
			set
			{
				if ((this._security != value))
				{
					this.OnsecurityChanging(value);
					this.SendPropertyChanging();
					this._security = value;
					this.SendPropertyChanged("security");
					this.OnsecurityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_factionID", DbType="Int")]
		public System.Nullable<int> factionID
		{
			get
			{
				return this._factionID;
			}
			set
			{
				if ((this._factionID != value))
				{
					this.OnfactionIDChanging(value);
					this.SendPropertyChanging();
					this._factionID = value;
					this.SendPropertyChanged("factionID");
					this.OnfactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_radius", DbType="Float")]
		public System.Nullable<double> radius
		{
			get
			{
				return this._radius;
			}
			set
			{
				if ((this._radius != value))
				{
					this.OnradiusChanging(value);
					this.SendPropertyChanging();
					this._radius = value;
					this.SendPropertyChanged("radius");
					this.OnradiusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sunTypeID", DbType="Int")]
		public System.Nullable<int> sunTypeID
		{
			get
			{
				return this._sunTypeID;
			}
			set
			{
				if ((this._sunTypeID != value))
				{
					this.OnsunTypeIDChanging(value);
					this.SendPropertyChanging();
					this._sunTypeID = value;
					this.SendPropertyChanged("sunTypeID");
					this.OnsunTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_securityClass", DbType="VarChar(2)")]
		public string securityClass
		{
			get
			{
				return this._securityClass;
			}
			set
			{
				if ((this._securityClass != value))
				{
					this.OnsecurityClassChanging(value);
					this.SendPropertyChanging();
					this._securityClass = value;
					this.SendPropertyChanged("securityClass");
					this.OnsecurityClassChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
