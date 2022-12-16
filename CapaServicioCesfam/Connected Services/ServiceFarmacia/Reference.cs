﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaServicioCesfam.ServiceFarmacia {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceFarmacia.WebServiceFarmaciaSoap")]
    public interface WebServiceFarmaciaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaFarmaciaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaFarmaciaService(CapaServicioCesfam.ServiceFarmacia.Farmacia auxFarmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaFarmaciaService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaFarmaciaServiceAsync(CapaServicioCesfam.ServiceFarmacia.Farmacia auxFarmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarFarmaciaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarFarmaciaService(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarFarmaciaService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarFarmaciaServiceAsync(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionFarmaciaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceFarmacia.Farmacia retornaPosicionFarmaciaService(int pos, string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionFarmaciaService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmacia.Farmacia> retornaPosicionFarmaciaServiceAsync(int pos, string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarFarmaciaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceFarmacia.Farmacia buscarFarmaciaService(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarFarmaciaService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmacia.Farmacia> buscarFarmaciaServiceAsync(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdFarmaciaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceFarmacia.Farmacia buscarIdFarmaciaService(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdFarmaciaService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmacia.Farmacia> buscarIdFarmaciaServiceAsync(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarFarmaciaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarFarmaciaService(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarFarmaciaService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarFarmaciaServiceAsync(string id_farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarCiudadService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarCiudadService(CapaServicioCesfam.ServiceFarmacia.Farmacia farmacia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarCiudadService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarCiudadServiceAsync(CapaServicioCesfam.ServiceFarmacia.Farmacia farmacia);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Farmacia : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_farmaciaField;
        
        private string id_ciudadField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_farmacia {
            get {
                return this.id_farmaciaField;
            }
            set {
                this.id_farmaciaField = value;
                this.RaisePropertyChanged("Id_farmacia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Id_ciudad {
            get {
                return this.id_ciudadField;
            }
            set {
                this.id_ciudadField = value;
                this.RaisePropertyChanged("Id_ciudad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
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
    public interface WebServiceFarmaciaSoapChannel : CapaServicioCesfam.ServiceFarmacia.WebServiceFarmaciaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceFarmaciaSoapClient : System.ServiceModel.ClientBase<CapaServicioCesfam.ServiceFarmacia.WebServiceFarmaciaSoap>, CapaServicioCesfam.ServiceFarmacia.WebServiceFarmaciaSoap {
        
        public WebServiceFarmaciaSoapClient() {
        }
        
        public WebServiceFarmaciaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceFarmaciaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFarmaciaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFarmaciaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaFarmaciaService(CapaServicioCesfam.ServiceFarmacia.Farmacia auxFarmacia) {
            base.Channel.insertaFarmaciaService(auxFarmacia);
        }
        
        public System.Threading.Tasks.Task insertaFarmaciaServiceAsync(CapaServicioCesfam.ServiceFarmacia.Farmacia auxFarmacia) {
            return base.Channel.insertaFarmaciaServiceAsync(auxFarmacia);
        }
        
        public System.Data.DataSet retornarFarmaciaService(string id_farmacia) {
            return base.Channel.retornarFarmaciaService(id_farmacia);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarFarmaciaServiceAsync(string id_farmacia) {
            return base.Channel.retornarFarmaciaServiceAsync(id_farmacia);
        }
        
        public CapaServicioCesfam.ServiceFarmacia.Farmacia retornaPosicionFarmaciaService(int pos, string id_farmacia) {
            return base.Channel.retornaPosicionFarmaciaService(pos, id_farmacia);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmacia.Farmacia> retornaPosicionFarmaciaServiceAsync(int pos, string id_farmacia) {
            return base.Channel.retornaPosicionFarmaciaServiceAsync(pos, id_farmacia);
        }
        
        public CapaServicioCesfam.ServiceFarmacia.Farmacia buscarFarmaciaService(string id_farmacia) {
            return base.Channel.buscarFarmaciaService(id_farmacia);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmacia.Farmacia> buscarFarmaciaServiceAsync(string id_farmacia) {
            return base.Channel.buscarFarmaciaServiceAsync(id_farmacia);
        }
        
        public CapaServicioCesfam.ServiceFarmacia.Farmacia buscarIdFarmaciaService(string id_farmacia) {
            return base.Channel.buscarIdFarmaciaService(id_farmacia);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceFarmacia.Farmacia> buscarIdFarmaciaServiceAsync(string id_farmacia) {
            return base.Channel.buscarIdFarmaciaServiceAsync(id_farmacia);
        }
        
        public void eliminarFarmaciaService(string id_farmacia) {
            base.Channel.eliminarFarmaciaService(id_farmacia);
        }
        
        public System.Threading.Tasks.Task eliminarFarmaciaServiceAsync(string id_farmacia) {
            return base.Channel.eliminarFarmaciaServiceAsync(id_farmacia);
        }
        
        public void actualizarCiudadService(CapaServicioCesfam.ServiceFarmacia.Farmacia farmacia) {
            base.Channel.actualizarCiudadService(farmacia);
        }
        
        public System.Threading.Tasks.Task actualizarCiudadServiceAsync(CapaServicioCesfam.ServiceFarmacia.Farmacia farmacia) {
            return base.Channel.actualizarCiudadServiceAsync(farmacia);
        }
    }
}