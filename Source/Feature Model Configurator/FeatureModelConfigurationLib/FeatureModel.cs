﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50215.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50215.312.
// 
namespace FeatureModelConfigurationLib
{
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRootAttribute("RootFeature", Namespace="", IsNullable=false)]
    public partial class RootFeatureType {
        
        private object[] itemsField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Feature", typeof(FeatureType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("FeatureSet", typeof(FeatureSetType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    public partial class FeatureType {
        
        private object[] itemsField;
        
        private string nameField;
        
        private KindType kindField;
        
        private ConfigType configurationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Feature", typeof(FeatureType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("FeatureSet", typeof(FeatureSetType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public KindType kind {
            get {
                return this.kindField;
            }
            set {
                this.kindField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ConfigType configuration {
            get {
                return this.configurationField;
            }
            set {
                this.configurationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    public partial class FeatureSetType {
        
        private FeatureType[] featureField;
        
        private string minField;
        
        private string maxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Feature", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FeatureType[] Feature {
            get {
                return this.featureField;
            }
            set {
                this.featureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string min {
            get {
                return this.minField;
            }
            set {
                this.minField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string max {
            get {
                return this.maxField;
            }
            set {
                this.maxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    public enum KindType {
        
        /// <remarks/>
        Mandatory,
        
        /// <remarks/>
        Optional,
        
        /// <remarks/>
        FeatureSetFeature,
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    public enum ConfigType {
        
        /// <remarks/>
        Unspecified,
        
        /// <remarks/>
        Excluded,
        
        /// <remarks/>
        Included,
    }
}
