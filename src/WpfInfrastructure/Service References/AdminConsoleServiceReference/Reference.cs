/* Copyright 2017 Cimpress

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License. */


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VP.FF.PT.Common.WpfInfrastructure.AdminConsoleServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminConsoleServiceReference.IAdminConsoleService")]
    public interface IAdminConsoleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminConsoleService/ExecuteCommand", ReplyAction="http://tempuri.org/IAdminConsoleService/ExecuteCommandResponse")]
        object ExecuteCommand(string cmd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminConsoleService/ExecuteCommand", ReplyAction="http://tempuri.org/IAdminConsoleService/ExecuteCommandResponse")]
        System.Threading.Tasks.Task<object> ExecuteCommandAsync(string cmd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminConsoleService/Initialize", ReplyAction="http://tempuri.org/IAdminConsoleService/InitializeResponse")]
        void Initialize();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminConsoleService/Initialize", ReplyAction="http://tempuri.org/IAdminConsoleService/InitializeResponse")]
        System.Threading.Tasks.Task InitializeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminConsoleServiceChannel : VP.FF.PT.Common.WpfInfrastructure.AdminConsoleServiceReference.IAdminConsoleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminConsoleServiceClient : System.ServiceModel.ClientBase<VP.FF.PT.Common.WpfInfrastructure.AdminConsoleServiceReference.IAdminConsoleService>, VP.FF.PT.Common.WpfInfrastructure.AdminConsoleServiceReference.IAdminConsoleService {
        
        public AdminConsoleServiceClient() {
        }
        
        public AdminConsoleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminConsoleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminConsoleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminConsoleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public object ExecuteCommand(string cmd) {
            return base.Channel.ExecuteCommand(cmd);
        }
        
        public System.Threading.Tasks.Task<object> ExecuteCommandAsync(string cmd) {
            return base.Channel.ExecuteCommandAsync(cmd);
        }
        
        public void Initialize() {
            base.Channel.Initialize();
        }
        
        public System.Threading.Tasks.Task InitializeAsync() {
            return base.Channel.InitializeAsync();
        }
    }
}