﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ankh.UI.Commands {
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
    internal class CommandStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CommandStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ankh.UI.Commands.CommandStrings", typeof(CommandStrings).Assembly);
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
        ///   Looks up a localized string similar to Enter a valid path (like &apos;C:\MyWork&apos;).
        /// </summary>
        internal static string EnterValidPath {
            get {
                return ResourceManager.GetString("EnterValidPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter a valid url (like &apos;http://myserver/svn/repos/path&apos;).
        /// </summary>
        internal static string EnterValidUrl {
            get {
                return ResourceManager.GetString("EnterValidUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compare.
        /// </summary>
        internal static string WhitespaceCompare {
            get {
                return ResourceManager.GetString("WhitespaceCompare", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ignore all Whitespace.
        /// </summary>
        internal static string WhitespaceIgnoreAllWhitespace {
            get {
                return ResourceManager.GetString("WhitespaceIgnoreAllWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ignore Changes.
        /// </summary>
        internal static string WhitespaceIgnoreChanges {
            get {
                return ResourceManager.GetString("WhitespaceIgnoreChanges", resourceCulture);
            }
        }
    }
}
