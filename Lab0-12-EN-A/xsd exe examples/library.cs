//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace library {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/library")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://example.org/jk/library", IsNullable=false)]
    public partial class library {
        
        private libraryBook[] bookField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("book")]
        public libraryBook[] book {
            get {
                return this.bookField;
            }
            set {
                this.bookField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://example.org/jk/library")]
    public partial class libraryBook {
        
        private string titleField;
        
        private string yearField;
        
        private string languageField;
        
        private string authornamesField;
        
        private string authorsurnameField;
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        public string authornames {
            get {
                return this.authornamesField;
            }
            set {
                this.authornamesField = value;
            }
        }
        
        /// <remarks/>
        public string authorsurname {
            get {
                return this.authorsurnameField;
            }
            set {
                this.authorsurnameField = value;
            }
        }
    }
}
