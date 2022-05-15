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

namespace DataLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Library")]
	public partial class LibraryDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertbooks_on_hand(books_on_hand instance);
    partial void Updatebooks_on_hand(books_on_hand instance);
    partial void Deletebooks_on_hand(books_on_hand instance);
    partial void Insertlent_book(lent_book instance);
    partial void Updatelent_book(lent_book instance);
    partial void Deletelent_book(lent_book instance);
    #endregion
		
		public LibraryDatabaseDataContext() : 
				base(global::DataLayer.Properties.Settings.Default.LibraryConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<books_on_hand> books_on_hands
		{
			get
			{
				return this.GetTable<books_on_hand>();
			}
		}
		
		public System.Data.Linq.Table<lent_book> lent_books
		{
			get
			{
				return this.GetTable<lent_book>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.books_on_hand")]
	public partial class books_on_hand : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _book_id;
		
		private string _title;
		
		private string _author_firstName;
		
		private string _author_lastName;
		
		private string _short_description;
		
		private string _long_description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onbook_idChanging(decimal value);
    partial void Onbook_idChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void Onauthor_firstNameChanging(string value);
    partial void Onauthor_firstNameChanged();
    partial void Onauthor_lastNameChanging(string value);
    partial void Onauthor_lastNameChanged();
    partial void Onshort_descriptionChanging(string value);
    partial void Onshort_descriptionChanged();
    partial void Onlong_descriptionChanging(string value);
    partial void Onlong_descriptionChanged();
    #endregion
		
		public books_on_hand()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_book_id", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal book_id
		{
			get
			{
				return this._book_id;
			}
			set
			{
				if ((this._book_id != value))
				{
					this.Onbook_idChanging(value);
					this.SendPropertyChanging();
					this._book_id = value;
					this.SendPropertyChanged("book_id");
					this.Onbook_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_firstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string author_firstName
		{
			get
			{
				return this._author_firstName;
			}
			set
			{
				if ((this._author_firstName != value))
				{
					this.Onauthor_firstNameChanging(value);
					this.SendPropertyChanging();
					this._author_firstName = value;
					this.SendPropertyChanged("author_firstName");
					this.Onauthor_firstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_lastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string author_lastName
		{
			get
			{
				return this._author_lastName;
			}
			set
			{
				if ((this._author_lastName != value))
				{
					this.Onauthor_lastNameChanging(value);
					this.SendPropertyChanging();
					this._author_lastName = value;
					this.SendPropertyChanged("author_lastName");
					this.Onauthor_lastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_short_description", DbType="VarChar(50)")]
		public string short_description
		{
			get
			{
				return this._short_description;
			}
			set
			{
				if ((this._short_description != value))
				{
					this.Onshort_descriptionChanging(value);
					this.SendPropertyChanging();
					this._short_description = value;
					this.SendPropertyChanged("short_description");
					this.Onshort_descriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_long_description", DbType="VarChar(400)")]
		public string long_description
		{
			get
			{
				return this._long_description;
			}
			set
			{
				if ((this._long_description != value))
				{
					this.Onlong_descriptionChanging(value);
					this.SendPropertyChanging();
					this._long_description = value;
					this.SendPropertyChanged("long_description");
					this.Onlong_descriptionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.lent_books")]
	public partial class lent_book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _book_id;
		
		private string _title;
		
		private string _author_firstName;
		
		private string _author_lastName;
		
		private string _short_description;
		
		private string _long_description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onbook_idChanging(decimal value);
    partial void Onbook_idChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void Onauthor_firstNameChanging(string value);
    partial void Onauthor_firstNameChanged();
    partial void Onauthor_lastNameChanging(string value);
    partial void Onauthor_lastNameChanged();
    partial void Onshort_descriptionChanging(string value);
    partial void Onshort_descriptionChanged();
    partial void Onlong_descriptionChanging(string value);
    partial void Onlong_descriptionChanged();
    #endregion
		
		public lent_book()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_book_id", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal book_id
		{
			get
			{
				return this._book_id;
			}
			set
			{
				if ((this._book_id != value))
				{
					this.Onbook_idChanging(value);
					this.SendPropertyChanging();
					this._book_id = value;
					this.SendPropertyChanged("book_id");
					this.Onbook_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_firstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string author_firstName
		{
			get
			{
				return this._author_firstName;
			}
			set
			{
				if ((this._author_firstName != value))
				{
					this.Onauthor_firstNameChanging(value);
					this.SendPropertyChanging();
					this._author_firstName = value;
					this.SendPropertyChanged("author_firstName");
					this.Onauthor_firstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_author_lastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string author_lastName
		{
			get
			{
				return this._author_lastName;
			}
			set
			{
				if ((this._author_lastName != value))
				{
					this.Onauthor_lastNameChanging(value);
					this.SendPropertyChanging();
					this._author_lastName = value;
					this.SendPropertyChanged("author_lastName");
					this.Onauthor_lastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_short_description", DbType="VarChar(50)")]
		public string short_description
		{
			get
			{
				return this._short_description;
			}
			set
			{
				if ((this._short_description != value))
				{
					this.Onshort_descriptionChanging(value);
					this.SendPropertyChanging();
					this._short_description = value;
					this.SendPropertyChanged("short_description");
					this.Onshort_descriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_long_description", DbType="VarChar(400)")]
		public string long_description
		{
			get
			{
				return this._long_description;
			}
			set
			{
				if ((this._long_description != value))
				{
					this.Onlong_descriptionChanging(value);
					this.SendPropertyChanging();
					this._long_description = value;
					this.SendPropertyChanged("long_description");
					this.Onlong_descriptionChanged();
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
