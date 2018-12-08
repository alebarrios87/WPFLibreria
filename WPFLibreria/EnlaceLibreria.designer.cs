﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFLibreria
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibreriaBD")]
	public partial class EnlaceLibreriaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertEditoriales(Editoriales instance);
    partial void UpdateEditoriales(Editoriales instance);
    partial void DeleteEditoriales(Editoriales instance);
    partial void InsertLibros(Libros instance);
    partial void UpdateLibros(Libros instance);
    partial void DeleteLibros(Libros instance);
    #endregion
		
		public EnlaceLibreriaDataContext() : 
				base(global::WPFLibreria.Properties.Settings.Default.LibreriaBDConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EnlaceLibreriaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EnlaceLibreriaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EnlaceLibreriaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EnlaceLibreriaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Editoriales> Editoriales
		{
			get
			{
				return this.GetTable<Editoriales>();
			}
		}
		
		public System.Data.Linq.Table<Libros> Libros
		{
			get
			{
				return this.GetTable<Libros>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateLibro")]
		public int UpdateLibro([global::System.Data.Linq.Mapping.ParameterAttribute(Name="LibroID", DbType="Int")] System.Nullable<int> libroID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EditorialID", DbType="Int")] System.Nullable<int> editorialID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreAutor", DbType="NVarChar(50)")] string nombreAutor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Genero", DbType="NVarChar(50)")] string genero, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PrecioUnitario", DbType="Money")] System.Nullable<decimal> precioUnitario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descricion", DbType="NVarChar(50)")] string descricion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), libroID, editorialID, nombreAutor, genero, precioUnitario, descricion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddEditorial")]
		public int AddEditorial([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EditorialNombre", DbType="NVarChar(50)")] string editorialNombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EditorialDireccion", DbType="NVarChar(50)")] string editorialDireccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EditorialID", DbType="Int")] ref System.Nullable<int> editorialID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), editorialNombre, editorialDireccion, editorialID);
			editorialID = ((System.Nullable<int>)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddLibro")]
		public int AddLibro([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EditorialID", DbType="Int")] System.Nullable<int> editorialID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreAutor", DbType="NVarChar(50)")] string nombreAutor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Genero", DbType="NVarChar(50)")] string genero, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PrecioUnitario", DbType="Money")] System.Nullable<decimal> precioUnitario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descricion", DbType="NVarChar(200)")] string descricion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LibroID", DbType="Int")] ref System.Nullable<int> libroID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), editorialID, nombreAutor, genero, precioUnitario, descricion, libroID);
			libroID = ((System.Nullable<int>)(result.GetParameterValue(5)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteEditorial")]
		public int DeleteEditorial([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EditorialID", DbType="Int")] System.Nullable<int> editorialID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), editorialID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteLibro")]
		public int DeleteLibro([global::System.Data.Linq.Mapping.ParameterAttribute(Name="LibroID", DbType="Int")] System.Nullable<int> libroID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), libroID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetEditoriales")]
		public ISingleResult<GetEditorialesResult> GetEditoriales()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetEditorialesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLibros")]
		public ISingleResult<GetLibrosResult> GetLibros()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetLibrosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateEditorial")]
		public int UpdateEditorial([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EditorialID", DbType="Int")] System.Nullable<int> editorialID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EditorialNombre", DbType="NVarChar(50)")] string editorialNombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EditorialDireccion", DbType="NVarChar(50)")] string editorialDireccion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), editorialID, editorialNombre, editorialDireccion);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Editoriales")]
	public partial class Editoriales : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EditorialID;
		
		private string _EditorialNombre;
		
		private string _EditorialDireccion;
		
		private EntitySet<Libros> _Libros;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEditorialIDChanging(int value);
    partial void OnEditorialIDChanged();
    partial void OnEditorialNombreChanging(string value);
    partial void OnEditorialNombreChanged();
    partial void OnEditorialDireccionChanging(string value);
    partial void OnEditorialDireccionChanged();
    #endregion
		
		public Editoriales()
		{
			this._Libros = new EntitySet<Libros>(new Action<Libros>(this.attach_Libros), new Action<Libros>(this.detach_Libros));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EditorialID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EditorialID
		{
			get
			{
				return this._EditorialID;
			}
			set
			{
				if ((this._EditorialID != value))
				{
					this.OnEditorialIDChanging(value);
					this.SendPropertyChanging();
					this._EditorialID = value;
					this.SendPropertyChanged("EditorialID");
					this.OnEditorialIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EditorialNombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EditorialNombre
		{
			get
			{
				return this._EditorialNombre;
			}
			set
			{
				if ((this._EditorialNombre != value))
				{
					this.OnEditorialNombreChanging(value);
					this.SendPropertyChanging();
					this._EditorialNombre = value;
					this.SendPropertyChanged("EditorialNombre");
					this.OnEditorialNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EditorialDireccion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EditorialDireccion
		{
			get
			{
				return this._EditorialDireccion;
			}
			set
			{
				if ((this._EditorialDireccion != value))
				{
					this.OnEditorialDireccionChanging(value);
					this.SendPropertyChanging();
					this._EditorialDireccion = value;
					this.SendPropertyChanged("EditorialDireccion");
					this.OnEditorialDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Editoriales_Libros", Storage="_Libros", ThisKey="EditorialID", OtherKey="EditorialID")]
		public EntitySet<Libros> Libros
		{
			get
			{
				return this._Libros;
			}
			set
			{
				this._Libros.Assign(value);
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
		
		private void attach_Libros(Libros entity)
		{
			this.SendPropertyChanging();
			entity.Editoriales = this;
		}
		
		private void detach_Libros(Libros entity)
		{
			this.SendPropertyChanging();
			entity.Editoriales = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Libros")]
	public partial class Libros : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LibroID;
		
		private int _EditorialID;
		
		private string _NombreAutor;
		
		private string _Genero;
		
		private System.Nullable<decimal> _PrecioUnitario;
		
		private string _Descricion;
		
		private EntityRef<Editoriales> _Editoriales;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLibroIDChanging(int value);
    partial void OnLibroIDChanged();
    partial void OnEditorialIDChanging(int value);
    partial void OnEditorialIDChanged();
    partial void OnNombreAutorChanging(string value);
    partial void OnNombreAutorChanged();
    partial void OnGeneroChanging(string value);
    partial void OnGeneroChanged();
    partial void OnPrecioUnitarioChanging(System.Nullable<decimal> value);
    partial void OnPrecioUnitarioChanged();
    partial void OnDescricionChanging(string value);
    partial void OnDescricionChanged();
    #endregion
		
		public Libros()
		{
			this._Editoriales = default(EntityRef<Editoriales>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LibroID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LibroID
		{
			get
			{
				return this._LibroID;
			}
			set
			{
				if ((this._LibroID != value))
				{
					this.OnLibroIDChanging(value);
					this.SendPropertyChanging();
					this._LibroID = value;
					this.SendPropertyChanged("LibroID");
					this.OnLibroIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EditorialID", DbType="Int NOT NULL")]
		public int EditorialID
		{
			get
			{
				return this._EditorialID;
			}
			set
			{
				if ((this._EditorialID != value))
				{
					if (this._Editoriales.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEditorialIDChanging(value);
					this.SendPropertyChanging();
					this._EditorialID = value;
					this.SendPropertyChanged("EditorialID");
					this.OnEditorialIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreAutor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreAutor
		{
			get
			{
				return this._NombreAutor;
			}
			set
			{
				if ((this._NombreAutor != value))
				{
					this.OnNombreAutorChanging(value);
					this.SendPropertyChanging();
					this._NombreAutor = value;
					this.SendPropertyChanged("NombreAutor");
					this.OnNombreAutorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this.OnGeneroChanging(value);
					this.SendPropertyChanging();
					this._Genero = value;
					this.SendPropertyChanged("Genero");
					this.OnGeneroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioUnitario", DbType="Money")]
		public System.Nullable<decimal> PrecioUnitario
		{
			get
			{
				return this._PrecioUnitario;
			}
			set
			{
				if ((this._PrecioUnitario != value))
				{
					this.OnPrecioUnitarioChanging(value);
					this.SendPropertyChanging();
					this._PrecioUnitario = value;
					this.SendPropertyChanged("PrecioUnitario");
					this.OnPrecioUnitarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descricion", DbType="VarChar(200)")]
		public string Descricion
		{
			get
			{
				return this._Descricion;
			}
			set
			{
				if ((this._Descricion != value))
				{
					this.OnDescricionChanging(value);
					this.SendPropertyChanging();
					this._Descricion = value;
					this.SendPropertyChanged("Descricion");
					this.OnDescricionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Editoriales_Libros", Storage="_Editoriales", ThisKey="EditorialID", OtherKey="EditorialID", IsForeignKey=true)]
		public Editoriales Editoriales
		{
			get
			{
				return this._Editoriales.Entity;
			}
			set
			{
				Editoriales previousValue = this._Editoriales.Entity;
				if (((previousValue != value) 
							|| (this._Editoriales.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Editoriales.Entity = null;
						previousValue.Libros.Remove(this);
					}
					this._Editoriales.Entity = value;
					if ((value != null))
					{
						value.Libros.Add(this);
						this._EditorialID = value.EditorialID;
					}
					else
					{
						this._EditorialID = default(int);
					}
					this.SendPropertyChanged("Editoriales");
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
	
	public partial class GetEditorialesResult
	{
		
		private string _EditorialNombre;
		
		private string _EditorialDireccion;
		
		public GetEditorialesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EditorialNombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EditorialNombre
		{
			get
			{
				return this._EditorialNombre;
			}
			set
			{
				if ((this._EditorialNombre != value))
				{
					this._EditorialNombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EditorialDireccion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EditorialDireccion
		{
			get
			{
				return this._EditorialDireccion;
			}
			set
			{
				if ((this._EditorialDireccion != value))
				{
					this._EditorialDireccion = value;
				}
			}
		}
	}
	
	public partial class GetLibrosResult
	{
		
		private string _EditorialNombre;
		
		private int _LibroID;
		
		private string _NombreAutor;
		
		private string _Genero;
		
		private System.Nullable<decimal> _PrecioUnitario;
		
		private string _Descricion;
		
		public GetLibrosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EditorialNombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EditorialNombre
		{
			get
			{
				return this._EditorialNombre;
			}
			set
			{
				if ((this._EditorialNombre != value))
				{
					this._EditorialNombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LibroID", DbType="Int NOT NULL")]
		public int LibroID
		{
			get
			{
				return this._LibroID;
			}
			set
			{
				if ((this._LibroID != value))
				{
					this._LibroID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreAutor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreAutor
		{
			get
			{
				return this._NombreAutor;
			}
			set
			{
				if ((this._NombreAutor != value))
				{
					this._NombreAutor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this._Genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioUnitario", DbType="Money")]
		public System.Nullable<decimal> PrecioUnitario
		{
			get
			{
				return this._PrecioUnitario;
			}
			set
			{
				if ((this._PrecioUnitario != value))
				{
					this._PrecioUnitario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descricion", DbType="VarChar(200)")]
		public string Descricion
		{
			get
			{
				return this._Descricion;
			}
			set
			{
				if ((this._Descricion != value))
				{
					this._Descricion = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
