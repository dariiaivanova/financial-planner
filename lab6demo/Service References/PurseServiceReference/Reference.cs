﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab6demo.PurseServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Purse", Namespace="http://schemas.datacontract.org/2004/07/financialplanner.Data")]
    [System.SerializableAttribute()]
    public partial class Purse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CurrentBalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lab6demo.PurseServiceReference.Operation[] OperationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PurseCurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ReportField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lab6demo.PurseServiceReference.PurseState _purseStateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CurrentBalance {
            get {
                return this.CurrentBalanceField;
            }
            set {
                if ((this.CurrentBalanceField.Equals(value) != true)) {
                    this.CurrentBalanceField = value;
                    this.RaisePropertyChanged("CurrentBalance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lab6demo.PurseServiceReference.Operation[] Operations {
            get {
                return this.OperationsField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationsField, value) != true)) {
                    this.OperationsField = value;
                    this.RaisePropertyChanged("Operations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PurseCurrency {
            get {
                return this.PurseCurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.PurseCurrencyField, value) != true)) {
                    this.PurseCurrencyField = value;
                    this.RaisePropertyChanged("PurseCurrency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Report {
            get {
                return this.ReportField;
            }
            set {
                if ((this.ReportField.Equals(value) != true)) {
                    this.ReportField = value;
                    this.RaisePropertyChanged("Report");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lab6demo.PurseServiceReference.PurseState _purseState {
            get {
                return this._purseStateField;
            }
            set {
                if ((object.ReferenceEquals(this._purseStateField, value) != true)) {
                    this._purseStateField = value;
                    this.RaisePropertyChanged("_purseState");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PurseState", Namespace="http://schemas.datacontract.org/2004/07/financialplanner.Data")]
    [System.SerializableAttribute()]
    public partial class PurseState : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lab6demo.PurseServiceReference.Purse PurseField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lab6demo.PurseServiceReference.Purse Purse {
            get {
                return this.PurseField;
            }
            set {
                if ((object.ReferenceEquals(this.PurseField, value) != true)) {
                    this.PurseField = value;
                    this.RaisePropertyChanged("Purse");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Operation", Namespace="http://schemas.datacontract.org/2004/07/financialplanner.Data")]
    [System.SerializableAttribute()]
    public partial class Operation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lab6demo.PurseServiceReference.Category CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsExpenseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SumField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lab6demo.PurseServiceReference.Category Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Currency {
            get {
                return this.CurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrencyField, value) != true)) {
                    this.CurrencyField = value;
                    this.RaisePropertyChanged("Currency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsExpense {
            get {
                return this.IsExpenseField;
            }
            set {
                if ((this.IsExpenseField.Equals(value) != true)) {
                    this.IsExpenseField = value;
                    this.RaisePropertyChanged("IsExpense");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Note {
            get {
                return this.NoteField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteField, value) != true)) {
                    this.NoteField = value;
                    this.RaisePropertyChanged("Note");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Place {
            get {
                return this.PlaceField;
            }
            set {
                if ((object.ReferenceEquals(this.PlaceField, value) != true)) {
                    this.PlaceField = value;
                    this.RaisePropertyChanged("Place");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Sum {
            get {
                return this.SumField;
            }
            set {
                if ((this.SumField.Equals(value) != true)) {
                    this.SumField = value;
                    this.RaisePropertyChanged("Sum");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/financialplanner.Data")]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lab6demo.PurseServiceReference.Category[] ChildrenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private lab6demo.PurseServiceReference.Category ParentField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lab6demo.PurseServiceReference.Category[] Children {
            get {
                return this.ChildrenField;
            }
            set {
                if ((object.ReferenceEquals(this.ChildrenField, value) != true)) {
                    this.ChildrenField = value;
                    this.RaisePropertyChanged("Children");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public lab6demo.PurseServiceReference.Category Parent {
            get {
                return this.ParentField;
            }
            set {
                if ((object.ReferenceEquals(this.ParentField, value) != true)) {
                    this.ParentField = value;
                    this.RaisePropertyChanged("Parent");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PurseServiceReference.IPurseService")]
    public interface IPurseService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPurseService/NewPurse", ReplyAction="http://tempuri.org/IPurseService/NewPurseResponse")]
        bool NewPurse(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPurseService/NewPurse", ReplyAction="http://tempuri.org/IPurseService/NewPurseResponse")]
        System.Threading.Tasks.Task<bool> NewPurseAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPurseService/GetPurse", ReplyAction="http://tempuri.org/IPurseService/GetPurseResponse")]
        lab6demo.PurseServiceReference.Purse GetPurse(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPurseService/GetPurse", ReplyAction="http://tempuri.org/IPurseService/GetPurseResponse")]
        System.Threading.Tasks.Task<lab6demo.PurseServiceReference.Purse> GetPurseAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPurseService/UpdatePurse", ReplyAction="http://tempuri.org/IPurseService/UpdatePurseResponse")]
        bool UpdatePurse(lab6demo.PurseServiceReference.Purse purse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPurseService/UpdatePurse", ReplyAction="http://tempuri.org/IPurseService/UpdatePurseResponse")]
        System.Threading.Tasks.Task<bool> UpdatePurseAsync(lab6demo.PurseServiceReference.Purse purse);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPurseServiceChannel : lab6demo.PurseServiceReference.IPurseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PurseServiceClient : System.ServiceModel.ClientBase<lab6demo.PurseServiceReference.IPurseService>, lab6demo.PurseServiceReference.IPurseService {
        
        public PurseServiceClient() {
        }
        
        public PurseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PurseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PurseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PurseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool NewPurse(string name) {
            return base.Channel.NewPurse(name);
        }
        
        public System.Threading.Tasks.Task<bool> NewPurseAsync(string name) {
            return base.Channel.NewPurseAsync(name);
        }
        
        public lab6demo.PurseServiceReference.Purse GetPurse(string name) {
            return base.Channel.GetPurse(name);
        }
        
        public System.Threading.Tasks.Task<lab6demo.PurseServiceReference.Purse> GetPurseAsync(string name) {
            return base.Channel.GetPurseAsync(name);
        }
        
        public bool UpdatePurse(lab6demo.PurseServiceReference.Purse purse) {
            return base.Channel.UpdatePurse(purse);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePurseAsync(lab6demo.PurseServiceReference.Purse purse) {
            return base.Channel.UpdatePurseAsync(purse);
        }
    }
}
