﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Advisor.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Advisor.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to suppression creation message.
        /// </summary>
        internal static string SuppressionCreate
        {
            get
            {
                return ResourceManager.GetString("SuppressionCreate", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Disable recommendation warning message.
        /// </summary>
        internal static string DisableRecommendationWarningMessage
        {
            get {
                return ResourceManager.GetString("DisableRecommendationWarningMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to suppression creation message.
        /// </summary>
        internal static string SuppressionRemove
        {
            get
            {
                return ResourceManager.GetString("SuppressionRemove", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to enable recommendation warning message.
        /// </summary>
        internal static string EnableRecommendationWarningMessage
        {
            get
            {
                return ResourceManager.GetString("EnableRecommendationWarningMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to enable recommendation warning message.
        /// </summary>
        internal static string ConfigurationUpdate
        {
            get
            {
                return ResourceManager.GetString("ConfigurationUpdate", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to enable recommendation warning message.
        /// </summary>
        internal static string ConfigurationUpdateSubscriptionLevel
        {
            get
            {
                return ResourceManager.GetString("ConfigurationUpdateSubscriptionLevel", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to enable recommendation warning message.
        /// </summary>
        internal static string ConfigurationUpdateResourceGroupLevel
        {
            get
            {
                return ResourceManager.GetString("ConfigurationUpdateResourceGroupLevel", resourceCulture);
            }
        }

    }
}