﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigimonWorld2Tool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowGridPosAsHex {
            get {
                return ((bool)(this["ShowGridPosAsHex"]));
            }
            set {
                this["ShowGridPosAsHex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowGridLines {
            get {
                return ((bool)(this["ShowGridLines"]));
            }
            set {
                this["ShowGridLines"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int GridTileSize {
            get {
                return ((int)(this["GridTileSize"]));
            }
            set {
                this["GridTileSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sloppy")]
        public string ErrorCheckingLevel {
            get {
                return ((string)(this["ErrorCheckingLevel"]));
            }
            set {
                this["ErrorCheckingLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowLogs {
            get {
                return ((bool)(this["ShowLogs"]));
            }
            set {
                this["ShowLogs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MapDataFolder {
            get {
                return ((string)(this["MapDataFolder"]));
            }
            set {
                this["MapDataFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowWarpsLayer {
            get {
                return ((bool)(this["ShowWarpsLayer"]));
            }
            set {
                this["ShowWarpsLayer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowTrapsLayer {
            get {
                return ((bool)(this["ShowTrapsLayer"]));
            }
            set {
                this["ShowTrapsLayer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowChestsLayer {
            get {
                return ((bool)(this["ShowChestsLayer"]));
            }
            set {
                this["ShowChestsLayer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowDigimonLayer {
            get {
                return ((bool)(this["ShowDigimonLayer"]));
            }
            set {
                this["ShowDigimonLayer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ScaleTextureToFit {
            get {
                return ((bool)(this["ScaleTextureToFit"]));
            }
            set {
                this["ScaleTextureToFit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TextureUseAltClutCheckbox {
            get {
                return ((bool)(this["TextureUseAltClutCheckbox"]));
            }
            set {
                this["TextureUseAltClutCheckbox"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CLUTFirstColourTransparantCheckbox {
            get {
                return ((bool)(this["CLUTFirstColourTransparantCheckbox"]));
            }
            set {
                this["CLUTFirstColourTransparantCheckbox"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool InvertCLUTColours {
            get {
                return ((bool)(this["InvertCLUTColours"]));
            }
            set {
                this["InvertCLUTColours"] = value;
            }
        }
    }
}
