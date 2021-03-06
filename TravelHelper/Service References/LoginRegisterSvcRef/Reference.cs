﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DsodAsgmnt5.LoginRegisterSvcRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginRegisterSvcRef.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registerUser", ReplyAction="http://tempuri.org/IService1/registerUserResponse")]
        string registerUser(string username, string password, string confirmPassword, string zip, string email, string cellno, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registerUser", ReplyAction="http://tempuri.org/IService1/registerUserResponse")]
        System.Threading.Tasks.Task<string> registerUserAsync(string username, string password, string confirmPassword, string zip, string email, string cellno, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        bool login(string username, string password, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        System.Threading.Tasks.Task<bool> loginAsync(string username, string password, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        string addUser(string username, string password, string confirmpassword, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        System.Threading.Tasks.Task<string> addUserAsync(string username, string password, string confirmpassword, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteUser", ReplyAction="http://tempuri.org/IService1/deleteUserResponse")]
        string deleteUser(string username, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteUser", ReplyAction="http://tempuri.org/IService1/deleteUserResponse")]
        System.Threading.Tasks.Task<string> deleteUserAsync(string username, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewUser", ReplyAction="http://tempuri.org/IService1/viewUserResponse")]
        string[] viewUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewUser", ReplyAction="http://tempuri.org/IService1/viewUserResponse")]
        System.Threading.Tasks.Task<string[]> viewUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewStaff", ReplyAction="http://tempuri.org/IService1/viewStaffResponse")]
        string[] viewStaff();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewStaff", ReplyAction="http://tempuri.org/IService1/viewStaffResponse")]
        System.Threading.Tasks.Task<string[]> viewStaffAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewManager", ReplyAction="http://tempuri.org/IService1/viewManagerResponse")]
        string[] viewManager();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewManager", ReplyAction="http://tempuri.org/IService1/viewManagerResponse")]
        System.Threading.Tasks.Task<string[]> viewManagerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addOrder", ReplyAction="http://tempuri.org/IService1/addOrderResponse")]
        string addOrder(int orderno, string name, string email, string date, decimal totalprice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addOrder", ReplyAction="http://tempuri.org/IService1/addOrderResponse")]
        System.Threading.Tasks.Task<string> addOrderAsync(int orderno, string name, string email, string date, decimal totalprice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewOrders", ReplyAction="http://tempuri.org/IService1/viewOrdersResponse")]
        string[] viewOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewOrders", ReplyAction="http://tempuri.org/IService1/viewOrdersResponse")]
        System.Threading.Tasks.Task<string[]> viewOrdersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DsodAsgmnt5.LoginRegisterSvcRef.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DsodAsgmnt5.LoginRegisterSvcRef.IService1>, DsodAsgmnt5.LoginRegisterSvcRef.IService1 {
        
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
        
        public string registerUser(string username, string password, string confirmPassword, string zip, string email, string cellno, string role) {
            return base.Channel.registerUser(username, password, confirmPassword, zip, email, cellno, role);
        }
        
        public System.Threading.Tasks.Task<string> registerUserAsync(string username, string password, string confirmPassword, string zip, string email, string cellno, string role) {
            return base.Channel.registerUserAsync(username, password, confirmPassword, zip, email, cellno, role);
        }
        
        public bool login(string username, string password, string role) {
            return base.Channel.login(username, password, role);
        }
        
        public System.Threading.Tasks.Task<bool> loginAsync(string username, string password, string role) {
            return base.Channel.loginAsync(username, password, role);
        }
        
        public string addUser(string username, string password, string confirmpassword, string role) {
            return base.Channel.addUser(username, password, confirmpassword, role);
        }
        
        public System.Threading.Tasks.Task<string> addUserAsync(string username, string password, string confirmpassword, string role) {
            return base.Channel.addUserAsync(username, password, confirmpassword, role);
        }
        
        public string deleteUser(string username, string role) {
            return base.Channel.deleteUser(username, role);
        }
        
        public System.Threading.Tasks.Task<string> deleteUserAsync(string username, string role) {
            return base.Channel.deleteUserAsync(username, role);
        }
        
        public string[] viewUser() {
            return base.Channel.viewUser();
        }
        
        public System.Threading.Tasks.Task<string[]> viewUserAsync() {
            return base.Channel.viewUserAsync();
        }
        
        public string[] viewStaff() {
            return base.Channel.viewStaff();
        }
        
        public System.Threading.Tasks.Task<string[]> viewStaffAsync() {
            return base.Channel.viewStaffAsync();
        }
        
        public string[] viewManager() {
            return base.Channel.viewManager();
        }
        
        public System.Threading.Tasks.Task<string[]> viewManagerAsync() {
            return base.Channel.viewManagerAsync();
        }
        
        public string addOrder(int orderno, string name, string email, string date, decimal totalprice) {
            return base.Channel.addOrder(orderno, name, email, date, totalprice);
        }
        
        public System.Threading.Tasks.Task<string> addOrderAsync(int orderno, string name, string email, string date, decimal totalprice) {
            return base.Channel.addOrderAsync(orderno, name, email, date, totalprice);
        }
        
        public string[] viewOrders() {
            return base.Channel.viewOrders();
        }
        
        public System.Threading.Tasks.Task<string[]> viewOrdersAsync() {
            return base.Channel.viewOrdersAsync();
        }
    }
}
