﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWCFMex.TestWCFMex {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestWCFMex.ICalc")]
    public interface ICalc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Sum", ReplyAction="http://tempuri.org/ICalc/SumResponse")]
        int Sum(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Sum", ReplyAction="http://tempuri.org/ICalc/SumResponse")]
        System.Threading.Tasks.Task<int> SumAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Sub", ReplyAction="http://tempuri.org/ICalc/SubResponse")]
        int Sub(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Sub", ReplyAction="http://tempuri.org/ICalc/SubResponse")]
        System.Threading.Tasks.Task<int> SubAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Div", ReplyAction="http://tempuri.org/ICalc/DivResponse")]
        int Div(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Div", ReplyAction="http://tempuri.org/ICalc/DivResponse")]
        System.Threading.Tasks.Task<int> DivAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Mult", ReplyAction="http://tempuri.org/ICalc/MultResponse")]
        int Mult(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Mult", ReplyAction="http://tempuri.org/ICalc/MultResponse")]
        System.Threading.Tasks.Task<int> MultAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcChannel : TestWCFMex.TestWCFMex.ICalc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcClient : System.ServiceModel.ClientBase<TestWCFMex.TestWCFMex.ICalc>, TestWCFMex.TestWCFMex.ICalc {
        
        public CalcClient() {
        }
        
        public CalcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Sum(int a, int b) {
            return base.Channel.Sum(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SumAsync(int a, int b) {
            return base.Channel.SumAsync(a, b);
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
        
        public int Mult(int a, int b) {
            return base.Channel.Mult(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultAsync(int a, int b) {
            return base.Channel.MultAsync(a, b);
        }
    }
}