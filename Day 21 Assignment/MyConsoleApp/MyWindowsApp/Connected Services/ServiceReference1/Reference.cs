﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWindowsApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Factorial", ReplyAction="*")]
        int Factorial(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Factorial", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FactorialAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        int Sub(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Div", ReplyAction="*")]
        int Div(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Div", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DivAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        int Mul(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MulAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : MyWindowsApp.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<MyWindowsApp.ServiceReference1.WebService1Soap>, MyWindowsApp.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Factorial(int n) {
            return base.Channel.Factorial(n);
        }
        
        public System.Threading.Tasks.Task<int> FactorialAsync(int n) {
            return base.Channel.FactorialAsync(n);
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public int Sub(int a, int b) {
            return base.Channel.Sub(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SubAsync(int a, int b) {
            return base.Channel.SubAsync(a, b);
        }
        
        public int Div(int a, int b) {
            return base.Channel.Div(a, b);
        }
        
        public System.Threading.Tasks.Task<int> DivAsync(int a, int b) {
            return base.Channel.DivAsync(a, b);
        }
        
        public int Mul(int a, int b) {
            return base.Channel.Mul(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MulAsync(int a, int b) {
            return base.Channel.MulAsync(a, b);
        }
    }
}
