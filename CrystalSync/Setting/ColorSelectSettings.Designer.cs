﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrystalSync.Setting {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class ColorSelectSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ColorSelectSettings defaultInstance = ((ColorSelectSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ColorSelectSettings())));
        
        public static ColorSelectSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string maxNumber {
            get {
                return ((string)(this["maxNumber"]));
            }
            set {
                this["maxNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFF0000")]
        public string color {
            get {
                return ((string)(this["color"]));
            }
            set {
                this["color"] = value;
            }
        }
    }
}
