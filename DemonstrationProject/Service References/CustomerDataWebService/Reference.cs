﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemonstrationProject.CustomerDataWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RawCustomerBill", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects")]
    [System.SerializableAttribute()]
    public partial class RawCustomerBill : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemonstrationProject.CustomerDataWebService.CallCharges CallChargesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemonstrationProject.CustomerDataWebService.Package PackageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemonstrationProject.CustomerDataWebService.SkyStore SkyStoreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemonstrationProject.CustomerDataWebService.Statement StatementField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TotalField;
        
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
        public DemonstrationProject.CustomerDataWebService.CallCharges CallCharges {
            get {
                return this.CallChargesField;
            }
            set {
                if ((object.ReferenceEquals(this.CallChargesField, value) != true)) {
                    this.CallChargesField = value;
                    this.RaisePropertyChanged("CallCharges");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DemonstrationProject.CustomerDataWebService.Package Package {
            get {
                return this.PackageField;
            }
            set {
                if ((object.ReferenceEquals(this.PackageField, value) != true)) {
                    this.PackageField = value;
                    this.RaisePropertyChanged("Package");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DemonstrationProject.CustomerDataWebService.SkyStore SkyStore {
            get {
                return this.SkyStoreField;
            }
            set {
                if ((object.ReferenceEquals(this.SkyStoreField, value) != true)) {
                    this.SkyStoreField = value;
                    this.RaisePropertyChanged("SkyStore");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DemonstrationProject.CustomerDataWebService.Statement Statement {
            get {
                return this.StatementField;
            }
            set {
                if ((object.ReferenceEquals(this.StatementField, value) != true)) {
                    this.StatementField = value;
                    this.RaisePropertyChanged("Statement");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CallCharges", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects.RawCustomerBill" +
        "JsonTypes")]
    [System.SerializableAttribute()]
    public partial class CallCharges : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemonstrationProject.CustomerDataWebService.Call[] CallsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TotalField;
        
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
        public DemonstrationProject.CustomerDataWebService.Call[] Calls {
            get {
                return this.CallsField;
            }
            set {
                if ((object.ReferenceEquals(this.CallsField, value) != true)) {
                    this.CallsField = value;
                    this.RaisePropertyChanged("Calls");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Package", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects.RawCustomerBill" +
        "JsonTypes")]
    [System.SerializableAttribute()]
    public partial class Package : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemonstrationProject.CustomerDataWebService.Subscription[] SubscriptionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TotalField;
        
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
        public DemonstrationProject.CustomerDataWebService.Subscription[] Subscriptions {
            get {
                return this.SubscriptionsField;
            }
            set {
                if ((object.ReferenceEquals(this.SubscriptionsField, value) != true)) {
                    this.SubscriptionsField = value;
                    this.RaisePropertyChanged("Subscriptions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SkyStore", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects.RawCustomerBill" +
        "JsonTypes")]
    [System.SerializableAttribute()]
    public partial class SkyStore : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemonstrationProject.CustomerDataWebService.BuyAndKeep[] BuyAndKeepField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemonstrationProject.CustomerDataWebService.Rental[] RentalsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TotalField;
        
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
        public DemonstrationProject.CustomerDataWebService.BuyAndKeep[] BuyAndKeep {
            get {
                return this.BuyAndKeepField;
            }
            set {
                if ((object.ReferenceEquals(this.BuyAndKeepField, value) != true)) {
                    this.BuyAndKeepField = value;
                    this.RaisePropertyChanged("BuyAndKeep");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DemonstrationProject.CustomerDataWebService.Rental[] Rentals {
            get {
                return this.RentalsField;
            }
            set {
                if ((object.ReferenceEquals(this.RentalsField, value) != true)) {
                    this.RentalsField = value;
                    this.RaisePropertyChanged("Rentals");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Statement", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects.RawCustomerBill" +
        "JsonTypes")]
    [System.SerializableAttribute()]
    public partial class Statement : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneratedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemonstrationProject.CustomerDataWebService.Period PeriodField;
        
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
        public string Due {
            get {
                return this.DueField;
            }
            set {
                if ((object.ReferenceEquals(this.DueField, value) != true)) {
                    this.DueField = value;
                    this.RaisePropertyChanged("Due");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Generated {
            get {
                return this.GeneratedField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneratedField, value) != true)) {
                    this.GeneratedField = value;
                    this.RaisePropertyChanged("Generated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DemonstrationProject.CustomerDataWebService.Period Period {
            get {
                return this.PeriodField;
            }
            set {
                if ((object.ReferenceEquals(this.PeriodField, value) != true)) {
                    this.PeriodField = value;
                    this.RaisePropertyChanged("Period");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Call", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects.RawCustomerBill" +
        "JsonTypes")]
    [System.SerializableAttribute()]
    public partial class Call : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CalledField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DurationField;
        
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
        public string Called {
            get {
                return this.CalledField;
            }
            set {
                if ((object.ReferenceEquals(this.CalledField, value) != true)) {
                    this.CalledField = value;
                    this.RaisePropertyChanged("Called");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Cost {
            get {
                return this.CostField;
            }
            set {
                if ((this.CostField.Equals(value) != true)) {
                    this.CostField = value;
                    this.RaisePropertyChanged("Cost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Duration {
            get {
                return this.DurationField;
            }
            set {
                if ((object.ReferenceEquals(this.DurationField, value) != true)) {
                    this.DurationField = value;
                    this.RaisePropertyChanged("Duration");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Subscription", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects.RawCustomerBill" +
        "JsonTypes")]
    [System.SerializableAttribute()]
    public partial class Subscription : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public double Cost {
            get {
                return this.CostField;
            }
            set {
                if ((this.CostField.Equals(value) != true)) {
                    this.CostField = value;
                    this.RaisePropertyChanged("Cost");
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
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BuyAndKeep", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects.RawCustomerBill" +
        "JsonTypes")]
    [System.SerializableAttribute()]
    public partial class BuyAndKeep : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public double Cost {
            get {
                return this.CostField;
            }
            set {
                if ((this.CostField.Equals(value) != true)) {
                    this.CostField = value;
                    this.RaisePropertyChanged("Cost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Rental", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects.RawCustomerBill" +
        "JsonTypes")]
    [System.SerializableAttribute()]
    public partial class Rental : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public double Cost {
            get {
                return this.CostField;
            }
            set {
                if ((this.CostField.Equals(value) != true)) {
                    this.CostField = value;
                    this.RaisePropertyChanged("Cost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Period", Namespace="http://schemas.datacontract.org/2004/07/DemoWebService.RawObjects.RawCustomerBill" +
        "JsonTypes")]
    [System.SerializableAttribute()]
    public partial class Period : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToField;
        
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
        public string From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string To {
            get {
                return this.ToField;
            }
            set {
                if ((object.ReferenceEquals(this.ToField, value) != true)) {
                    this.ToField = value;
                    this.RaisePropertyChanged("To");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerDataWebService.ICustomerDataWebService")]
    public interface ICustomerDataWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerDataWebService/GetCustomerBill", ReplyAction="http://tempuri.org/ICustomerDataWebService/GetCustomerBillResponse")]
        DemonstrationProject.CustomerDataWebService.RawCustomerBill GetCustomerBill();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerDataWebService/GetCustomerBill", ReplyAction="http://tempuri.org/ICustomerDataWebService/GetCustomerBillResponse")]
        System.Threading.Tasks.Task<DemonstrationProject.CustomerDataWebService.RawCustomerBill> GetCustomerBillAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerDataWebServiceChannel : DemonstrationProject.CustomerDataWebService.ICustomerDataWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerDataWebServiceClient : System.ServiceModel.ClientBase<DemonstrationProject.CustomerDataWebService.ICustomerDataWebService>, DemonstrationProject.CustomerDataWebService.ICustomerDataWebService {
        
        public CustomerDataWebServiceClient() {
        }
        
        public CustomerDataWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerDataWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerDataWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerDataWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DemonstrationProject.CustomerDataWebService.RawCustomerBill GetCustomerBill() {
            return base.Channel.GetCustomerBill();
        }
        
        public System.Threading.Tasks.Task<DemonstrationProject.CustomerDataWebService.RawCustomerBill> GetCustomerBillAsync() {
            return base.Channel.GetCustomerBillAsync();
        }
    }
}