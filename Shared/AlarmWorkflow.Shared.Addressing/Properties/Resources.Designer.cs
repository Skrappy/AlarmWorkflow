﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmWorkflow.Shared.Addressing.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlarmWorkflow.Shared.Addressing.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Address book scan finished. Entries found: {0}..
        /// </summary>
        internal static string AddressBook_FinishScanMessage {
            get {
                return ResourceManager.GetString("AddressBook_FinishScanMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begin scanning address book contents....
        /// </summary>
        internal static string AddressBook_StartScanMessage {
            get {
                return ResourceManager.GetString("AddressBook_StartScanMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred during converting a value using provider &apos;{0}&apos;. This data item will be ignored. See log for further information..
        /// </summary>
        internal static string ConvertBackErrorMessage {
            get {
                return ResourceManager.GetString("ConvertBackErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The phone number &apos;{0}&apos; contains invalid chars! Make sure it does only contain digits (0-9)!.
        /// </summary>
        internal static string PhoneNumberContainsInvalidChars {
            get {
                return ResourceManager.GetString("PhoneNumberContainsInvalidChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Unbenannt).
        /// </summary>
        internal static string UnknownNameSubstitute {
            get {
                return ResourceManager.GetString("UnknownNameSubstitute", resourceCulture);
            }
        }
    }
}
