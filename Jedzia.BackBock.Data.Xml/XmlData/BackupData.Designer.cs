// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>Jedzia.BackBock.Data.Xml.XmlData</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>True</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>True</EnableEncoding><AutomaticProperties>True</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings>Jedzia.BackBock.SharedTypes</CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class BackupData : EntityBase<BackupData> {
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private BackupItemType[] backupItemField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string datasetNameField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string datasetGroupField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DatasetName {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DatasetGroup {get; set;}

        
        [System.Xml.Serialization.XmlElementAttribute("BackupItem", Order=0)]
        public BackupItemType[] BackupItem {
            get {
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
        private PathDataType[] pathField;
        
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
        public PathDataType[] Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public TaskType Task {
            get {
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
        private Wildcard[] exclusionField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private Wildcard[] inclusionField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string pathField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string userDataField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Path {get; set;}

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserData {get; set;}

        
        [System.Xml.Serialization.XmlElementAttribute("Exclusion", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Wildcard[] Exclusion {
            get {
                return this.exclusionField;
            }
            set {
                this.exclusionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Inclusion", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public Wildcard[] Inclusion {
            get {
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
        private System.Xml.XmlAttribute[] anyAttrField;
        
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TypeName {get; set;}

        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
}
