﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wechat
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SampleSale.TicketDB")]
	public partial class WechatDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertWechatLog(WechatEntities.WechatLog instance);
    partial void UpdateWechatLog(WechatEntities.WechatLog instance);
    partial void DeleteWechatLog(WechatEntities.WechatLog instance);
    partial void InsertWechatMessage(WechatEntities.WechatMessage instance);
    partial void UpdateWechatMessage(WechatEntities.WechatMessage instance);
    partial void DeleteWechatMessage(WechatEntities.WechatMessage instance);
    partial void InsertAccessToken(WechatEntities.AccessToken instance);
    partial void UpdateAccessToken(WechatEntities.AccessToken instance);
    partial void DeleteAccessToken(WechatEntities.AccessToken instance);
    #endregion
		
		public WechatDBDataContext() : 
				base(global::Wechat.Properties.Settings.Default.WechatDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WechatDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WechatDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WechatDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WechatDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<WechatEntities.WechatLog> WechatLogs
		{
			get
			{
				return this.GetTable<WechatEntities.WechatLog>();
			}
		}
		
		public System.Data.Linq.Table<WechatEntities.WechatMessage> WechatMessages
		{
			get
			{
				return this.GetTable<WechatEntities.WechatMessage>();
			}
		}
		
		public System.Data.Linq.Table<WechatEntities.AccessToken> AccessTokens
		{
			get
			{
				return this.GetTable<WechatEntities.AccessToken>();
			}
		}
	}
}
namespace WechatEntities
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WechatLog")]
	public partial class WechatLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _LogContent;
		
		private System.Nullable<System.DateTime> _LogTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnLogContentChanging(string value);
    partial void OnLogContentChanged();
    partial void OnLogTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnLogTimeChanged();
    #endregion
		
		public WechatLog()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogContent", DbType="NVarChar(MAX)")]
		public string LogContent
		{
			get
			{
				return this._LogContent;
			}
			set
			{
				if ((this._LogContent != value))
				{
					this.OnLogContentChanging(value);
					this.SendPropertyChanging();
					this._LogContent = value;
					this.SendPropertyChanged("LogContent");
					this.OnLogContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> LogTime
		{
			get
			{
				return this._LogTime;
			}
			set
			{
				if ((this._LogTime != value))
				{
					this.OnLogTimeChanging(value);
					this.SendPropertyChanging();
					this._LogTime = value;
					this.SendPropertyChanged("LogTime");
					this.OnLogTimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WechatMessage")]
	public partial class WechatMessage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _FromUserName;
		
		private string _ToUserName;
		
		private System.Nullable<System.DateTime> _CreateTime;
		
		private string _MsgType;
		
		private string _Direction;
		
		private string _RawData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnFromUserNameChanging(string value);
    partial void OnFromUserNameChanged();
    partial void OnToUserNameChanging(string value);
    partial void OnToUserNameChanged();
    partial void OnCreateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateTimeChanged();
    partial void OnMsgTypeChanging(string value);
    partial void OnMsgTypeChanged();
    partial void OnDirectionChanging(string value);
    partial void OnDirectionChanged();
    partial void OnRawDataChanging(string value);
    partial void OnRawDataChanged();
    #endregion
		
		public WechatMessage()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromUserName", DbType="NVarChar(255)")]
		public string FromUserName
		{
			get
			{
				return this._FromUserName;
			}
			set
			{
				if ((this._FromUserName != value))
				{
					this.OnFromUserNameChanging(value);
					this.SendPropertyChanging();
					this._FromUserName = value;
					this.SendPropertyChanged("FromUserName");
					this.OnFromUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToUserName", DbType="NVarChar(255)")]
		public string ToUserName
		{
			get
			{
				return this._ToUserName;
			}
			set
			{
				if ((this._ToUserName != value))
				{
					this.OnToUserNameChanging(value);
					this.SendPropertyChanging();
					this._ToUserName = value;
					this.SendPropertyChanged("ToUserName");
					this.OnToUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				if ((this._CreateTime != value))
				{
					this.OnCreateTimeChanging(value);
					this.SendPropertyChanging();
					this._CreateTime = value;
					this.SendPropertyChanged("CreateTime");
					this.OnCreateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MsgType", DbType="NVarChar(50)")]
		public string MsgType
		{
			get
			{
				return this._MsgType;
			}
			set
			{
				if ((this._MsgType != value))
				{
					this.OnMsgTypeChanging(value);
					this.SendPropertyChanging();
					this._MsgType = value;
					this.SendPropertyChanged("MsgType");
					this.OnMsgTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direction", DbType="NVarChar(50)")]
		public string Direction
		{
			get
			{
				return this._Direction;
			}
			set
			{
				if ((this._Direction != value))
				{
					this.OnDirectionChanging(value);
					this.SendPropertyChanging();
					this._Direction = value;
					this.SendPropertyChanged("Direction");
					this.OnDirectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RawData", DbType="NVarChar(MAX)")]
		public string RawData
		{
			get
			{
				return this._RawData;
			}
			set
			{
				if ((this._RawData != value))
				{
					this.OnRawDataChanging(value);
					this.SendPropertyChanging();
					this._RawData = value;
					this.SendPropertyChanged("RawData");
					this.OnRawDataChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AccessToken")]
	public partial class AccessToken : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _AccessTokenData;
		
		private System.Nullable<System.DateTime> _ExpireBy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnAccessTokenDataChanging(string value);
    partial void OnAccessTokenDataChanged();
    partial void OnExpireByChanging(System.Nullable<System.DateTime> value);
    partial void OnExpireByChanged();
    #endregion
		
		public AccessToken()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccessTokenData", DbType="NVarChar(MAX)")]
		public string AccessTokenData
		{
			get
			{
				return this._AccessTokenData;
			}
			set
			{
				if ((this._AccessTokenData != value))
				{
					this.OnAccessTokenDataChanging(value);
					this.SendPropertyChanging();
					this._AccessTokenData = value;
					this.SendPropertyChanged("AccessTokenData");
					this.OnAccessTokenDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpireBy", DbType="DateTime")]
		public System.Nullable<System.DateTime> ExpireBy
		{
			get
			{
				return this._ExpireBy;
			}
			set
			{
				if ((this._ExpireBy != value))
				{
					this.OnExpireByChanging(value);
					this.SendPropertyChanging();
					this._ExpireBy = value;
					this.SendPropertyChanged("ExpireBy");
					this.OnExpireByChanged();
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
