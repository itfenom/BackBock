// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Jedzia.BackBock.Data.Xml.XmlData</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>True</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>True</EnableEncoding><AutomaticProperties>True</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings>Jedzia.BackBock.SharedTypes</CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Jedzia.BackBock.Data.Xml.XmlData {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using Jedzia.BackBock.SharedTypes;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class BackupData : EntityBase<BackupData> {
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<BackupItemType> backupItemField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string datasetNameField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string datasetGroupField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DatasetName {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DatasetGroup {get; set;}

        
        [System.Xml.Serialization.XmlElementAttribute("BackupItem", Order=0)]
        public List<BackupItemType> BackupItem {
            get {
                if ((this.backupItemField == null)) {
                    this.backupItemField = new List<BackupItemType>();
                }
                return this.backupItemField;
            }
            set {
                this.backupItemField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("BackupItem", Namespace="", IsNullable=false)]
    public partial class BackupItemType : EntityBase<BackupItemType> {
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<PathDataType> pathField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private TaskType taskField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string itemNameField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string itemGroupField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private bool isEnabledField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ItemName {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ItemGroup {get; set;}

        
        public BackupItemType() {
            this.isEnabledField = false;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Path", Order=0)]
        public List<PathDataType> Path {
            get {
                if ((this.pathField == null)) {
                    this.pathField = new List<PathDataType>();
                }
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public TaskType Task {
            get {
                if ((this.taskField == null)) {
                    this.taskField = new TaskType();
                }
                return this.taskField;
            }
            set {
                this.taskField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsEnabled {
            get {
                return this.isEnabledField;
            }
            set {
                this.isEnabledField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Path", Namespace="", IsNullable=false)]
    public partial class PathDataType : EntityBase<PathDataType> {
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Wildcard> exclusionField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Wildcard> inclusionField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string pathField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string userDataField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Path {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserData {get; set;}

        
        [System.Xml.Serialization.XmlElementAttribute("Exclusion", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public List<Wildcard> Exclusion {
            get {
                if ((this.exclusionField == null)) {
                    this.exclusionField = new List<Wildcard>();
                }
                return this.exclusionField;
            }
            set {
                this.exclusionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Inclusion", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public List<Wildcard> Inclusion {
            get {
                if ((this.inclusionField == null)) {
                    this.inclusionField = new List<Wildcard>();
                }
                return this.inclusionField;
            }
            set {
                this.inclusionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class Wildcard : EntityBase<Wildcard> {
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string patternField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private bool enabledField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Pattern {get; set;}

        
        public Wildcard() {
            this.enabledField = false;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TaskType : EntityBase<TaskType> {
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string typeNameField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<System.Xml.XmlAttribute> anyAttrField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TypeName {get; set;}

        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr {
            get {
                if ((this.anyAttrField == null)) {
                    this.anyAttrField = new List<System.Xml.XmlAttribute>();
                }
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
}
