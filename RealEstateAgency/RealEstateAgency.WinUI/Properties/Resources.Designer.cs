﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstateAgency.WinUI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RealEstateAgency.WinUI.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://localhost:5010/api/.
        /// </summary>
        public static string ApiUrl {
            get {
                return ResourceManager.GetString("ApiUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Desila se greška, kontaktirajte tim za podršku!.
        /// </summary>
        public static string Error_Occured {
            get {
                return ResourceManager.GetString("Error_Occured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pogrešan username ili password.
        /// </summary>
        public static string Login_Faild {
            get {
                return ResourceManager.GetString("Login_Faild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nema zapisa!.
        /// </summary>
        public static string NoData {
            get {
                return ResourceManager.GetString("NoData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unesite ispravan email!.
        /// </summary>
        public static string Validation_EmailField {
            get {
                return ResourceManager.GetString("Validation_EmailField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vrijednost mora biti broj veći od 0!.
        /// </summary>
        public static string Validation_GreaterThanZero {
            get {
                return ResourceManager.GetString("Validation_GreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimalan broj slova je:.
        /// </summary>
        public static string Validation_MinLengthField {
            get {
                return ResourceManager.GetString("Validation_MinLengthField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Obavezno unijeti broj!.
        /// </summary>
        public static string Validation_MustBeANumber {
            get {
                return ResourceManager.GetString("Validation_MustBeANumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Polja nisu jednaka!.
        /// </summary>
        public static string Validation_NotEqualFields {
            get {
                return ResourceManager.GetString("Validation_NotEqualFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Šifra mora sadržavati 8 znakova i uključiti 3 od 4 sljedeća pravila: Velika slova (A-Z), mala slova (a-z), brojeve (0-9) i specijalne znakove (e.g. !@#$%^&amp;*)&quot;.
        /// </summary>
        public static string Validation_PasswordStrength {
            get {
                return ResourceManager.GetString("Validation_PasswordStrength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unesite ispravan broj telefona (061-111-111) !.
        /// </summary>
        public static string Validation_PhoneNumber {
            get {
                return ResourceManager.GetString("Validation_PhoneNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Obavezno polje!.
        /// </summary>
        public static string Validation_RequiredField {
            get {
                return ResourceManager.GetString("Validation_RequiredField", resourceCulture);
            }
        }
    }
}
