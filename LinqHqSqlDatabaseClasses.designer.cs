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

namespace museum
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BookofHonour")]
	public partial class LinqHqSqlDatabaseClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLibraryMember(LibraryMember instance);
    partial void UpdateLibraryMember(LibraryMember instance);
    partial void DeleteLibraryMember(LibraryMember instance);
    partial void InsertBookofHonour(BookofHonour instance);
    partial void UpdateBookofHonour(BookofHonour instance);
    partial void DeleteBookofHonour(BookofHonour instance);
    #endregion
		
		public LinqHqSqlDatabaseClassesDataContext() : 
				base(global::museum.Properties.Settings.Default.BookofHonourConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqHqSqlDatabaseClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqHqSqlDatabaseClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqHqSqlDatabaseClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqHqSqlDatabaseClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LibraryMember> LibraryMembers
		{
			get
			{
				return this.GetTable<LibraryMember>();
			}
		}
		
		public System.Data.Linq.Table<BookofHonour> BookofHonours
		{
			get
			{
				return this.GetTable<BookofHonour>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LibraryMember")]
	public partial class LibraryMember : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MemberID;
		
		private string _NameFirst;
		
		private string _NameInitial;
		
		private string _NameLast;
		
		private string _Username;
		
		private string _Password;
		
		private string _ConfirmPassword;
		
		private string _Address;
		
		private string _Street;
		
		private string _Town;
		
		private string _County;
		
		private string _Country;
		
		private string _Postcode;
		
		private int _Classification;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMemberIDChanging(int value);
    partial void OnMemberIDChanged();
    partial void OnNameFirstChanging(string value);
    partial void OnNameFirstChanged();
    partial void OnNameInitialChanging(string value);
    partial void OnNameInitialChanged();
    partial void OnNameLastChanging(string value);
    partial void OnNameLastChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnConfirmPasswordChanging(string value);
    partial void OnConfirmPasswordChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnStreetChanging(string value);
    partial void OnStreetChanged();
    partial void OnTownChanging(string value);
    partial void OnTownChanged();
    partial void OnCountyChanging(string value);
    partial void OnCountyChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnPostcodeChanging(string value);
    partial void OnPostcodeChanged();
    partial void OnClassificationChanging(int value);
    partial void OnClassificationChanged();
    #endregion
		
		public LibraryMember()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MemberID
		{
			get
			{
				return this._MemberID;
			}
			set
			{
				if ((this._MemberID != value))
				{
					this.OnMemberIDChanging(value);
					this.SendPropertyChanging();
					this._MemberID = value;
					this.SendPropertyChanged("MemberID");
					this.OnMemberIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameFirst", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string NameFirst
		{
			get
			{
				return this._NameFirst;
			}
			set
			{
				if ((this._NameFirst != value))
				{
					this.OnNameFirstChanging(value);
					this.SendPropertyChanging();
					this._NameFirst = value;
					this.SendPropertyChanged("NameFirst");
					this.OnNameFirstChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameInitial", DbType="VarChar(30)")]
		public string NameInitial
		{
			get
			{
				return this._NameInitial;
			}
			set
			{
				if ((this._NameInitial != value))
				{
					this.OnNameInitialChanging(value);
					this.SendPropertyChanging();
					this._NameInitial = value;
					this.SendPropertyChanged("NameInitial");
					this.OnNameInitialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameLast", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string NameLast
		{
			get
			{
				return this._NameLast;
			}
			set
			{
				if ((this._NameLast != value))
				{
					this.OnNameLastChanging(value);
					this.SendPropertyChanging();
					this._NameLast = value;
					this.SendPropertyChanged("NameLast");
					this.OnNameLastChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfirmPassword", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string ConfirmPassword
		{
			get
			{
				return this._ConfirmPassword;
			}
			set
			{
				if ((this._ConfirmPassword != value))
				{
					this.OnConfirmPasswordChanging(value);
					this.SendPropertyChanging();
					this._ConfirmPassword = value;
					this.SendPropertyChanged("ConfirmPassword");
					this.OnConfirmPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(30)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="VarChar(30)")]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this.OnStreetChanging(value);
					this.SendPropertyChanging();
					this._Street = value;
					this.SendPropertyChanged("Street");
					this.OnStreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Town", DbType="VarChar(30)")]
		public string Town
		{
			get
			{
				return this._Town;
			}
			set
			{
				if ((this._Town != value))
				{
					this.OnTownChanging(value);
					this.SendPropertyChanging();
					this._Town = value;
					this.SendPropertyChanged("Town");
					this.OnTownChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_County", DbType="VarChar(30)")]
		public string County
		{
			get
			{
				return this._County;
			}
			set
			{
				if ((this._County != value))
				{
					this.OnCountyChanging(value);
					this.SendPropertyChanging();
					this._County = value;
					this.SendPropertyChanged("County");
					this.OnCountyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(30)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Postcode", DbType="VarChar(30)")]
		public string Postcode
		{
			get
			{
				return this._Postcode;
			}
			set
			{
				if ((this._Postcode != value))
				{
					this.OnPostcodeChanging(value);
					this.SendPropertyChanging();
					this._Postcode = value;
					this.SendPropertyChanged("Postcode");
					this.OnPostcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Classification", DbType="Int NOT NULL")]
		public int Classification
		{
			get
			{
				return this._Classification;
			}
			set
			{
				if ((this._Classification != value))
				{
					this.OnClassificationChanging(value);
					this.SendPropertyChanging();
					this._Classification = value;
					this.SendPropertyChanged("Classification");
					this.OnClassificationChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookofHonour")]
	public partial class BookofHonour : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Ref_No;
		
		private string _Surname;
		
		private string _First_Name;
		
		private string _Rank;
		
		private System.Nullable<double> _Service___Regiment_No_;
		
		private string _Regiment___Unit___Service;
		
		private string _Attestation_Date___Place;
		
		private string _Residence_When_Enlisted;
		
		private string _Date_of_Birth;
		
		private string _Place_of_Birth;
		
		private string _Fathers_Name;
		
		private string _Mothers_Name;
		
		private string _Parental___Next_of_Kin_Address;
		
		private string _Next_of_Kin;
		
		private string _Religion;
		
		private string _Marital_Status;
		
		private string _Spouse_Name;
		
		private string _Spouse_Address;
		
		private string _Cause_of_Death;
		
		private string _Place_of_Death;
		
		private System.Nullable<System.DateTime> _Date_of_Death;
		
		private string _Place_of_Burial;
		
		private System.Nullable<double> _Age_at_Death;
		
		private string _Memorial;
		
		private string _Will;
		
		private string _Award___Honours___Medals;
		
		private string _Image_s_;
		
		private string _Any_additional_info;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRef_NoChanging(int value);
    partial void OnRef_NoChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnRankChanging(string value);
    partial void OnRankChanged();
    partial void OnService___Regiment_No_Changing(System.Nullable<double> value);
    partial void OnService___Regiment_No_Changed();
    partial void OnRegiment___Unit___ServiceChanging(string value);
    partial void OnRegiment___Unit___ServiceChanged();
    partial void OnAttestation_Date___PlaceChanging(string value);
    partial void OnAttestation_Date___PlaceChanged();
    partial void OnResidence_When_EnlistedChanging(string value);
    partial void OnResidence_When_EnlistedChanged();
    partial void OnDate_of_BirthChanging(string value);
    partial void OnDate_of_BirthChanged();
    partial void OnPlace_of_BirthChanging(string value);
    partial void OnPlace_of_BirthChanged();
    partial void OnFathers_NameChanging(string value);
    partial void OnFathers_NameChanged();
    partial void OnMothers_NameChanging(string value);
    partial void OnMothers_NameChanged();
    partial void OnParental___Next_of_Kin_AddressChanging(string value);
    partial void OnParental___Next_of_Kin_AddressChanged();
    partial void OnNext_of_KinChanging(string value);
    partial void OnNext_of_KinChanged();
    partial void OnReligionChanging(string value);
    partial void OnReligionChanged();
    partial void OnMarital_StatusChanging(string value);
    partial void OnMarital_StatusChanged();
    partial void OnSpouse_NameChanging(string value);
    partial void OnSpouse_NameChanged();
    partial void OnSpouse_AddressChanging(string value);
    partial void OnSpouse_AddressChanged();
    partial void OnCause_of_DeathChanging(string value);
    partial void OnCause_of_DeathChanged();
    partial void OnPlace_of_DeathChanging(string value);
    partial void OnPlace_of_DeathChanged();
    partial void OnDate_of_DeathChanging(System.Nullable<System.DateTime> value);
    partial void OnDate_of_DeathChanged();
    partial void OnPlace_of_BurialChanging(string value);
    partial void OnPlace_of_BurialChanged();
    partial void OnAge_at_DeathChanging(System.Nullable<double> value);
    partial void OnAge_at_DeathChanged();
    partial void OnMemorialChanging(string value);
    partial void OnMemorialChanged();
    partial void OnWillChanging(string value);
    partial void OnWillChanged();
    partial void OnAward___Honours___MedalsChanging(string value);
    partial void OnAward___Honours___MedalsChanged();
    partial void OnImage_s_Changing(string value);
    partial void OnImage_s_Changed();
    partial void OnAny_additional_infoChanging(string value);
    partial void OnAny_additional_infoChanged();
    #endregion
		
		public BookofHonour()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Ref No]", Storage="_Ref_No", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Ref_No
		{
			get
			{
				return this._Ref_No;
			}
			set
			{
				if ((this._Ref_No != value))
				{
					this.OnRef_NoChanging(value);
					this.SendPropertyChanging();
					this._Ref_No = value;
					this.SendPropertyChanged("Ref_No");
					this.OnRef_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(255)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[First Name]", Storage="_First_Name", DbType="NVarChar(255)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rank", DbType="NVarChar(255)")]
		public string Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				if ((this._Rank != value))
				{
					this.OnRankChanging(value);
					this.SendPropertyChanging();
					this._Rank = value;
					this.SendPropertyChanged("Rank");
					this.OnRankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Service / Regiment No#]", Storage="_Service___Regiment_No_", DbType="Float")]
		public System.Nullable<double> Service___Regiment_No_
		{
			get
			{
				return this._Service___Regiment_No_;
			}
			set
			{
				if ((this._Service___Regiment_No_ != value))
				{
					this.OnService___Regiment_No_Changing(value);
					this.SendPropertyChanging();
					this._Service___Regiment_No_ = value;
					this.SendPropertyChanged("Service___Regiment_No_");
					this.OnService___Regiment_No_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Regiment / Unit / Service]", Storage="_Regiment___Unit___Service", DbType="NVarChar(255)")]
		public string Regiment___Unit___Service
		{
			get
			{
				return this._Regiment___Unit___Service;
			}
			set
			{
				if ((this._Regiment___Unit___Service != value))
				{
					this.OnRegiment___Unit___ServiceChanging(value);
					this.SendPropertyChanging();
					this._Regiment___Unit___Service = value;
					this.SendPropertyChanged("Regiment___Unit___Service");
					this.OnRegiment___Unit___ServiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Attestation Date / Place]", Storage="_Attestation_Date___Place", DbType="NVarChar(255)")]
		public string Attestation_Date___Place
		{
			get
			{
				return this._Attestation_Date___Place;
			}
			set
			{
				if ((this._Attestation_Date___Place != value))
				{
					this.OnAttestation_Date___PlaceChanging(value);
					this.SendPropertyChanging();
					this._Attestation_Date___Place = value;
					this.SendPropertyChanged("Attestation_Date___Place");
					this.OnAttestation_Date___PlaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Residence When Enlisted]", Storage="_Residence_When_Enlisted", DbType="NVarChar(255)")]
		public string Residence_When_Enlisted
		{
			get
			{
				return this._Residence_When_Enlisted;
			}
			set
			{
				if ((this._Residence_When_Enlisted != value))
				{
					this.OnResidence_When_EnlistedChanging(value);
					this.SendPropertyChanging();
					this._Residence_When_Enlisted = value;
					this.SendPropertyChanged("Residence_When_Enlisted");
					this.OnResidence_When_EnlistedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Date of Birth]", Storage="_Date_of_Birth", DbType="NVarChar(255)")]
		public string Date_of_Birth
		{
			get
			{
				return this._Date_of_Birth;
			}
			set
			{
				if ((this._Date_of_Birth != value))
				{
					this.OnDate_of_BirthChanging(value);
					this.SendPropertyChanging();
					this._Date_of_Birth = value;
					this.SendPropertyChanged("Date_of_Birth");
					this.OnDate_of_BirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Place of Birth]", Storage="_Place_of_Birth", DbType="NVarChar(255)")]
		public string Place_of_Birth
		{
			get
			{
				return this._Place_of_Birth;
			}
			set
			{
				if ((this._Place_of_Birth != value))
				{
					this.OnPlace_of_BirthChanging(value);
					this.SendPropertyChanging();
					this._Place_of_Birth = value;
					this.SendPropertyChanged("Place_of_Birth");
					this.OnPlace_of_BirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Fathers Name]", Storage="_Fathers_Name", DbType="NVarChar(255)")]
		public string Fathers_Name
		{
			get
			{
				return this._Fathers_Name;
			}
			set
			{
				if ((this._Fathers_Name != value))
				{
					this.OnFathers_NameChanging(value);
					this.SendPropertyChanging();
					this._Fathers_Name = value;
					this.SendPropertyChanged("Fathers_Name");
					this.OnFathers_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Mothers Name]", Storage="_Mothers_Name", DbType="NVarChar(255)")]
		public string Mothers_Name
		{
			get
			{
				return this._Mothers_Name;
			}
			set
			{
				if ((this._Mothers_Name != value))
				{
					this.OnMothers_NameChanging(value);
					this.SendPropertyChanging();
					this._Mothers_Name = value;
					this.SendPropertyChanged("Mothers_Name");
					this.OnMothers_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Parental / Next of Kin Address]", Storage="_Parental___Next_of_Kin_Address", DbType="NVarChar(255)")]
		public string Parental___Next_of_Kin_Address
		{
			get
			{
				return this._Parental___Next_of_Kin_Address;
			}
			set
			{
				if ((this._Parental___Next_of_Kin_Address != value))
				{
					this.OnParental___Next_of_Kin_AddressChanging(value);
					this.SendPropertyChanging();
					this._Parental___Next_of_Kin_Address = value;
					this.SendPropertyChanged("Parental___Next_of_Kin_Address");
					this.OnParental___Next_of_Kin_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Next of Kin]", Storage="_Next_of_Kin", DbType="NVarChar(255)")]
		public string Next_of_Kin
		{
			get
			{
				return this._Next_of_Kin;
			}
			set
			{
				if ((this._Next_of_Kin != value))
				{
					this.OnNext_of_KinChanging(value);
					this.SendPropertyChanging();
					this._Next_of_Kin = value;
					this.SendPropertyChanged("Next_of_Kin");
					this.OnNext_of_KinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Religion", DbType="NVarChar(255)")]
		public string Religion
		{
			get
			{
				return this._Religion;
			}
			set
			{
				if ((this._Religion != value))
				{
					this.OnReligionChanging(value);
					this.SendPropertyChanging();
					this._Religion = value;
					this.SendPropertyChanged("Religion");
					this.OnReligionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Marital Status]", Storage="_Marital_Status", DbType="NVarChar(255)")]
		public string Marital_Status
		{
			get
			{
				return this._Marital_Status;
			}
			set
			{
				if ((this._Marital_Status != value))
				{
					this.OnMarital_StatusChanging(value);
					this.SendPropertyChanging();
					this._Marital_Status = value;
					this.SendPropertyChanged("Marital_Status");
					this.OnMarital_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Spouse Name]", Storage="_Spouse_Name", DbType="NVarChar(255)")]
		public string Spouse_Name
		{
			get
			{
				return this._Spouse_Name;
			}
			set
			{
				if ((this._Spouse_Name != value))
				{
					this.OnSpouse_NameChanging(value);
					this.SendPropertyChanging();
					this._Spouse_Name = value;
					this.SendPropertyChanged("Spouse_Name");
					this.OnSpouse_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Spouse Address]", Storage="_Spouse_Address", DbType="NVarChar(255)")]
		public string Spouse_Address
		{
			get
			{
				return this._Spouse_Address;
			}
			set
			{
				if ((this._Spouse_Address != value))
				{
					this.OnSpouse_AddressChanging(value);
					this.SendPropertyChanging();
					this._Spouse_Address = value;
					this.SendPropertyChanged("Spouse_Address");
					this.OnSpouse_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Cause of Death]", Storage="_Cause_of_Death", DbType="NVarChar(255)")]
		public string Cause_of_Death
		{
			get
			{
				return this._Cause_of_Death;
			}
			set
			{
				if ((this._Cause_of_Death != value))
				{
					this.OnCause_of_DeathChanging(value);
					this.SendPropertyChanging();
					this._Cause_of_Death = value;
					this.SendPropertyChanged("Cause_of_Death");
					this.OnCause_of_DeathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Place of Death]", Storage="_Place_of_Death", DbType="NVarChar(255)")]
		public string Place_of_Death
		{
			get
			{
				return this._Place_of_Death;
			}
			set
			{
				if ((this._Place_of_Death != value))
				{
					this.OnPlace_of_DeathChanging(value);
					this.SendPropertyChanging();
					this._Place_of_Death = value;
					this.SendPropertyChanged("Place_of_Death");
					this.OnPlace_of_DeathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Date of Death]", Storage="_Date_of_Death", DbType="DateTime")]
		public System.Nullable<System.DateTime> Date_of_Death
		{
			get
			{
				return this._Date_of_Death;
			}
			set
			{
				if ((this._Date_of_Death != value))
				{
					this.OnDate_of_DeathChanging(value);
					this.SendPropertyChanging();
					this._Date_of_Death = value;
					this.SendPropertyChanged("Date_of_Death");
					this.OnDate_of_DeathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Place of Burial]", Storage="_Place_of_Burial", DbType="NVarChar(255)")]
		public string Place_of_Burial
		{
			get
			{
				return this._Place_of_Burial;
			}
			set
			{
				if ((this._Place_of_Burial != value))
				{
					this.OnPlace_of_BurialChanging(value);
					this.SendPropertyChanging();
					this._Place_of_Burial = value;
					this.SendPropertyChanged("Place_of_Burial");
					this.OnPlace_of_BurialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Age at Death]", Storage="_Age_at_Death", DbType="Float")]
		public System.Nullable<double> Age_at_Death
		{
			get
			{
				return this._Age_at_Death;
			}
			set
			{
				if ((this._Age_at_Death != value))
				{
					this.OnAge_at_DeathChanging(value);
					this.SendPropertyChanging();
					this._Age_at_Death = value;
					this.SendPropertyChanged("Age_at_Death");
					this.OnAge_at_DeathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Memorial", DbType="NVarChar(255)")]
		public string Memorial
		{
			get
			{
				return this._Memorial;
			}
			set
			{
				if ((this._Memorial != value))
				{
					this.OnMemorialChanging(value);
					this.SendPropertyChanging();
					this._Memorial = value;
					this.SendPropertyChanged("Memorial");
					this.OnMemorialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Will", DbType="NVarChar(255)")]
		public string Will
		{
			get
			{
				return this._Will;
			}
			set
			{
				if ((this._Will != value))
				{
					this.OnWillChanging(value);
					this.SendPropertyChanging();
					this._Will = value;
					this.SendPropertyChanged("Will");
					this.OnWillChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Award / Honours / Medals]", Storage="_Award___Honours___Medals", DbType="NVarChar(255)")]
		public string Award___Honours___Medals
		{
			get
			{
				return this._Award___Honours___Medals;
			}
			set
			{
				if ((this._Award___Honours___Medals != value))
				{
					this.OnAward___Honours___MedalsChanging(value);
					this.SendPropertyChanging();
					this._Award___Honours___Medals = value;
					this.SendPropertyChanged("Award___Honours___Medals");
					this.OnAward___Honours___MedalsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Image(s)]", Storage="_Image_s_", DbType="NVarChar(255)")]
		public string Image_s_
		{
			get
			{
				return this._Image_s_;
			}
			set
			{
				if ((this._Image_s_ != value))
				{
					this.OnImage_s_Changing(value);
					this.SendPropertyChanging();
					this._Image_s_ = value;
					this.SendPropertyChanged("Image_s_");
					this.OnImage_s_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Any additional info]", Storage="_Any_additional_info", DbType="NVarChar(255)")]
		public string Any_additional_info
		{
			get
			{
				return this._Any_additional_info;
			}
			set
			{
				if ((this._Any_additional_info != value))
				{
					this.OnAny_additional_infoChanging(value);
					this.SendPropertyChanging();
					this._Any_additional_info = value;
					this.SendPropertyChanged("Any_additional_info");
					this.OnAny_additional_infoChanged();
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
