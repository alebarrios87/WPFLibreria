﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFLibreria.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=BAUFEST-30\\MSSQLSERVER01;Database=LibreriaDB;Trusted_Connection=True;")]
        public string LinqSQLConnString {
            get {
                return ((string)(this["LinqSQLConnString"]));
            }
            set {
                this["LinqSQLConnString"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=BAUFEST-30\\MSSQLSERVER01;Initial Catalog=xstoredb;Integrated Security" +
            "=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string LibreriaDBConnectionString1 {
            get {
                return ((string)(this["LibreriaDBConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=BAUFEST-30\\MSSQLSERVER01;Initial Catalog=LibreriaBD;Integrated Securi" +
            "ty=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string LibreriaDBConnectionString {
            get {
                return ((string)(this["LibreriaDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=BAUFEST-30\\MSSQLSERVER01;Initial Catalog=LibreriaBD;Integrated Securi" +
            "ty=True")]
        public string LibreriaBDConnectionString {
            get {
                return ((string)(this["LibreriaBDConnectionString"]));
            }
        }
    }
}
