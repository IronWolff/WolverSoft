﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS.ShowCase.ApplicationService.UserSvc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://www.wolversoft.com/Security/Model/User/20130612")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool MustChangePasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MustChangePassword {
            get {
                return this.MustChangePasswordField;
            }
            set {
                if ((this.MustChangePasswordField.Equals(value) != true)) {
                    this.MustChangePasswordField = value;
                    this.RaisePropertyChanged("MustChangePassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/WS.Security.Model")]
    [System.SerializableAttribute()]
    public partial class ServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorDetailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
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
        public string ErrorCode {
            get {
                return this.ErrorCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorCodeField, value) != true)) {
                    this.ErrorCodeField = value;
                    this.RaisePropertyChanged("ErrorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDetail {
            get {
                return this.ErrorDetailField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDetailField, value) != true)) {
                    this.ErrorDetailField = value;
                    this.RaisePropertyChanged("ErrorDetail");
                }
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.wolversoft.com/UserSecurity/UserService/20120530", ConfigurationName="UserSvc.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/InsertUs" +
            "er", ReplyAction="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/InsertUs" +
            "erResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WS.ShowCase.ApplicationService.UserSvc.ServiceFault), Action="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/InsertUs" +
            "erServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/WS.Security.Model")]
        int InsertUser(WS.ShowCase.ApplicationService.UserSvc.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/UpdateUs" +
            "er", ReplyAction="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/UpdateUs" +
            "erResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WS.ShowCase.ApplicationService.UserSvc.ServiceFault), Action="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/UpdateUs" +
            "erServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/WS.Security.Model")]
        void UpdateUser(WS.ShowCase.ApplicationService.UserSvc.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/ChangePa" +
            "ssword", ReplyAction="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/ChangePa" +
            "sswordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WS.ShowCase.ApplicationService.UserSvc.ServiceFault), Action="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/ChangePa" +
            "sswordServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/WS.Security.Model")]
        void ChangePassword(WS.ShowCase.ApplicationService.UserSvc.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/GetUserB" +
            "yLogin", ReplyAction="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/GetUserB" +
            "yLoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WS.ShowCase.ApplicationService.UserSvc.ServiceFault), Action="http://www.wolversoft.com/UserSecurity/UserService/20120530/IUserService/GetUserB" +
            "yLoginServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/WS.Security.Model")]
        WS.ShowCase.ApplicationService.UserSvc.User GetUserByLogin(string userName, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : WS.ShowCase.ApplicationService.UserSvc.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<WS.ShowCase.ApplicationService.UserSvc.IUserService>, WS.ShowCase.ApplicationService.UserSvc.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int InsertUser(WS.ShowCase.ApplicationService.UserSvc.User user) {
            return base.Channel.InsertUser(user);
        }
        
        public void UpdateUser(WS.ShowCase.ApplicationService.UserSvc.User user) {
            base.Channel.UpdateUser(user);
        }
        
        public void ChangePassword(WS.ShowCase.ApplicationService.UserSvc.User user) {
            base.Channel.ChangePassword(user);
        }
        
        public WS.ShowCase.ApplicationService.UserSvc.User GetUserByLogin(string userName, string password) {
            return base.Channel.GetUserByLogin(userName, password);
        }
    }
}
