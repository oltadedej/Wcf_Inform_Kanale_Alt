﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClientInf.WcfInformatike {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhoneBookModel", Namespace="http://schemas.datacontract.org/2004/07/WcfInformatike.Models")]
    [System.SerializableAttribute()]
    public partial class PhoneBookModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
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
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfInformatike")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Output", Namespace="http://schemas.datacontract.org/2004/07/WcfInformatike.Models")]
    [System.SerializableAttribute()]
    public partial class Output : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfClientInf.WcfInformatike.PhoneBookModel[] phoneBookModelsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfClientInf.WcfInformatike.Response responseField;
        
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
        public WcfClientInf.WcfInformatike.PhoneBookModel[] phoneBookModels {
            get {
                return this.phoneBookModelsField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneBookModelsField, value) != true)) {
                    this.phoneBookModelsField = value;
                    this.RaisePropertyChanged("phoneBookModels");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfClientInf.WcfInformatike.Response response {
            get {
                return this.responseField;
            }
            set {
                if ((object.ReferenceEquals(this.responseField, value) != true)) {
                    this.responseField = value;
                    this.RaisePropertyChanged("response");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/WcfInformatike.Models")]
    [System.SerializableAttribute()]
    public partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfClientInf.WcfInformatike.ResponseCode responseCodeField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfClientInf.WcfInformatike.ResponseCode responseCode {
            get {
                return this.responseCodeField;
            }
            set {
                if ((this.responseCodeField.Equals(value) != true)) {
                    this.responseCodeField = value;
                    this.RaisePropertyChanged("responseCode");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseCode", Namespace="http://schemas.datacontract.org/2004/07/WcfInformatike.Models")]
    public enum ResponseCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OK = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        KO = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfInformatike.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsConnected", ReplyAction="http://tempuri.org/IService1/IsConnectedResponse")]
        bool IsConnected();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsConnected", ReplyAction="http://tempuri.org/IService1/IsConnectedResponse")]
        System.Threading.Tasks.Task<bool> IsConnectedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Post", ReplyAction="http://tempuri.org/IService1/PostResponse")]
        string Post(WcfClientInf.WcfInformatike.PhoneBookModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Post", ReplyAction="http://tempuri.org/IService1/PostResponse")]
        System.Threading.Tasks.Task<string> PostAsync(WcfClientInf.WcfInformatike.PhoneBookModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfClientInf.WcfInformatike.CompositeType GetDataUsingDataContract(WcfClientInf.WcfInformatike.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfClientInf.WcfInformatike.CompositeType> GetDataUsingDataContractAsync(WcfClientInf.WcfInformatike.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPhoneBookList", ReplyAction="http://tempuri.org/IService1/GetPhoneBookListResponse")]
        WcfClientInf.WcfInformatike.Output GetPhoneBookList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPhoneBookList", ReplyAction="http://tempuri.org/IService1/GetPhoneBookListResponse")]
        System.Threading.Tasks.Task<WcfClientInf.WcfInformatike.Output> GetPhoneBookListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetById", ReplyAction="http://tempuri.org/IService1/GetByIdResponse")]
        WcfClientInf.WcfInformatike.Output GetById(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetById", ReplyAction="http://tempuri.org/IService1/GetByIdResponse")]
        System.Threading.Tasks.Task<WcfClientInf.WcfInformatike.Output> GetByIdAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        WcfClientInf.WcfInformatike.Output Insert(WcfClientInf.WcfInformatike.PhoneBookModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        System.Threading.Tasks.Task<WcfClientInf.WcfInformatike.Output> InsertAsync(WcfClientInf.WcfInformatike.PhoneBookModel model);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfClientInf.WcfInformatike.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfClientInf.WcfInformatike.IService1>, WcfClientInf.WcfInformatike.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public bool IsConnected() {
            return base.Channel.IsConnected();
        }
        
        public System.Threading.Tasks.Task<bool> IsConnectedAsync() {
            return base.Channel.IsConnectedAsync();
        }
        
        public string Post(WcfClientInf.WcfInformatike.PhoneBookModel model) {
            return base.Channel.Post(model);
        }
        
        public System.Threading.Tasks.Task<string> PostAsync(WcfClientInf.WcfInformatike.PhoneBookModel model) {
            return base.Channel.PostAsync(model);
        }
        
        public WcfClientInf.WcfInformatike.CompositeType GetDataUsingDataContract(WcfClientInf.WcfInformatike.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfClientInf.WcfInformatike.CompositeType> GetDataUsingDataContractAsync(WcfClientInf.WcfInformatike.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public WcfClientInf.WcfInformatike.Output GetPhoneBookList() {
            return base.Channel.GetPhoneBookList();
        }
        
        public System.Threading.Tasks.Task<WcfClientInf.WcfInformatike.Output> GetPhoneBookListAsync() {
            return base.Channel.GetPhoneBookListAsync();
        }
        
        public WcfClientInf.WcfInformatike.Output GetById(long id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<WcfClientInf.WcfInformatike.Output> GetByIdAsync(long id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public WcfClientInf.WcfInformatike.Output Insert(WcfClientInf.WcfInformatike.PhoneBookModel model) {
            return base.Channel.Insert(model);
        }
        
        public System.Threading.Tasks.Task<WcfClientInf.WcfInformatike.Output> InsertAsync(WcfClientInf.WcfInformatike.PhoneBookModel model) {
            return base.Channel.InsertAsync(model);
        }
    }
}
