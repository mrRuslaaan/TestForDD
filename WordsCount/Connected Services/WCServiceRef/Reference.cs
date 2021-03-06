﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WordsCount.WCServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCServiceRef.IWCService")]
    public interface IWCService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCService/WordsCount", ReplyAction="http://tempuri.org/IWCService/WordsCountResponse")]
        System.Collections.Generic.Dictionary<string, int> WordsCount(string[] words, System.Collections.Generic.Dictionary<string, int> dict);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCService/WordsCount", ReplyAction="http://tempuri.org/IWCService/WordsCountResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> WordsCountAsync(string[] words, System.Collections.Generic.Dictionary<string, int> dict);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCServiceChannel : WordsCount.WCServiceRef.IWCService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCServiceClient : System.ServiceModel.ClientBase<WordsCount.WCServiceRef.IWCService>, WordsCount.WCServiceRef.IWCService {
        
        public WCServiceClient() {
        }
        
        public WCServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.Dictionary<string, int> WordsCount(string[] words, System.Collections.Generic.Dictionary<string, int> dict) {
            return base.Channel.WordsCount(words, dict);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> WordsCountAsync(string[] words, System.Collections.Generic.Dictionary<string, int> dict) {
            return base.Channel.WordsCountAsync(words, dict);
        }
    }
}
