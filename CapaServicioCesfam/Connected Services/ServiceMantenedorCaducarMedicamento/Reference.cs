﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaServicioCesfam.ServiceMantenedorCaducarMedicamento {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorCaducarMedicamento.WebService1CaducarMedicamentoSoap")]
    public interface WebService1CaducarMedicamentoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaCaducarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaCaducarMedicamentoService(CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento caducarmedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaCaducarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaCaducarMedicamentoServiceAsync(CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento caducarmedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarCaducarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarCaducarMedicamentoService(string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarCaducarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarCaducarMedicamentoServiceAsync(string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionCaducarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento retornaPosicionCaducarMedicamentoService(int pos, string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionCaducarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento> retornaPosicionCaducarMedicamentoServiceAsync(int pos, string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarCaducarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento buscarCaducarMedicamentoService(string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarCaducarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento> buscarCaducarMedicamentoServiceAsync(string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdCaducarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento buscarIdCaducarMedicamentoService(string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdCaducarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento> buscarIdCaducarMedicamentoServiceAsync(string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarCaducarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarCaducarMedicamentoService(string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarCaducarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarCaducarMedicamentoServiceAsync(string id_caducidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarCaducarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarCaducarMedicamentoService(CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento caducarmedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarCaducarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarCaducarMedicamentoServiceAsync(CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento caducarmedicamento);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CaducarMedicamento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_caducidadField;
        
        private System.DateTime fecha_caducidadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_caducidad {
            get {
                return this.id_caducidadField;
            }
            set {
                this.id_caducidadField = value;
                this.RaisePropertyChanged("Id_caducidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Fecha_caducidad {
            get {
                return this.fecha_caducidadField;
            }
            set {
                this.fecha_caducidadField = value;
                this.RaisePropertyChanged("Fecha_caducidad");
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
    public interface WebService1CaducarMedicamentoSoapChannel : CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.WebService1CaducarMedicamentoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1CaducarMedicamentoSoapClient : System.ServiceModel.ClientBase<CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.WebService1CaducarMedicamentoSoap>, CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.WebService1CaducarMedicamentoSoap {
        
        public WebService1CaducarMedicamentoSoapClient() {
        }
        
        public WebService1CaducarMedicamentoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1CaducarMedicamentoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1CaducarMedicamentoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1CaducarMedicamentoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaCaducarMedicamentoService(CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento caducarmedicamento) {
            base.Channel.insertaCaducarMedicamentoService(caducarmedicamento);
        }
        
        public System.Threading.Tasks.Task insertaCaducarMedicamentoServiceAsync(CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento caducarmedicamento) {
            return base.Channel.insertaCaducarMedicamentoServiceAsync(caducarmedicamento);
        }
        
        public System.Data.DataSet retornarCaducarMedicamentoService(string id_caducidad) {
            return base.Channel.retornarCaducarMedicamentoService(id_caducidad);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarCaducarMedicamentoServiceAsync(string id_caducidad) {
            return base.Channel.retornarCaducarMedicamentoServiceAsync(id_caducidad);
        }
        
        public CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento retornaPosicionCaducarMedicamentoService(int pos, string id_caducidad) {
            return base.Channel.retornaPosicionCaducarMedicamentoService(pos, id_caducidad);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento> retornaPosicionCaducarMedicamentoServiceAsync(int pos, string id_caducidad) {
            return base.Channel.retornaPosicionCaducarMedicamentoServiceAsync(pos, id_caducidad);
        }
        
        public CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento buscarCaducarMedicamentoService(string id_caducidad) {
            return base.Channel.buscarCaducarMedicamentoService(id_caducidad);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento> buscarCaducarMedicamentoServiceAsync(string id_caducidad) {
            return base.Channel.buscarCaducarMedicamentoServiceAsync(id_caducidad);
        }
        
        public CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento buscarIdCaducarMedicamentoService(string id_caducidad) {
            return base.Channel.buscarIdCaducarMedicamentoService(id_caducidad);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento> buscarIdCaducarMedicamentoServiceAsync(string id_caducidad) {
            return base.Channel.buscarIdCaducarMedicamentoServiceAsync(id_caducidad);
        }
        
        public void eliminarCaducarMedicamentoService(string id_caducidad) {
            base.Channel.eliminarCaducarMedicamentoService(id_caducidad);
        }
        
        public System.Threading.Tasks.Task eliminarCaducarMedicamentoServiceAsync(string id_caducidad) {
            return base.Channel.eliminarCaducarMedicamentoServiceAsync(id_caducidad);
        }
        
        public void actualizarCaducarMedicamentoService(CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento caducarmedicamento) {
            base.Channel.actualizarCaducarMedicamentoService(caducarmedicamento);
        }
        
        public System.Threading.Tasks.Task actualizarCaducarMedicamentoServiceAsync(CapaServicioCesfam.ServiceMantenedorCaducarMedicamento.CaducarMedicamento caducarmedicamento) {
            return base.Channel.actualizarCaducarMedicamentoServiceAsync(caducarmedicamento);
        }
    }
}