﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExchangeRatesClientLibrary.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IExchangeRates")]
    public interface IExchangeRates {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeRates/CurrentExchangeRates", ReplyAction="http://tempuri.org/IExchangeRates/CurrentExchangeRatesResponse")]
        string CurrentExchangeRates();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeRates/CurrentExchangeRates", ReplyAction="http://tempuri.org/IExchangeRates/CurrentExchangeRatesResponse")]
        System.Threading.Tasks.Task<string> CurrentExchangeRatesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExchangeRatesChannel : ExchangeRatesClientLibrary.ServiceReference1.IExchangeRates, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExchangeRatesClient : System.ServiceModel.ClientBase<ExchangeRatesClientLibrary.ServiceReference1.IExchangeRates>, ExchangeRatesClientLibrary.ServiceReference1.IExchangeRates {
        
        public ExchangeRatesClient() {
        }
        
        public ExchangeRatesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExchangeRatesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeRatesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeRatesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CurrentExchangeRates() {
            return base.Channel.CurrentExchangeRates();
        }
        
        public System.Threading.Tasks.Task<string> CurrentExchangeRatesAsync() {
            return base.Channel.CurrentExchangeRatesAsync();
        }
    }
}
