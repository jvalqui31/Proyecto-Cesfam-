﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaHtml.ServiceMantenedorDetalleIngreso {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorDetalleIngreso.WebService1DetalleIngresoSoap")]
    public interface WebService1DetalleIngresoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaDetalleIngresoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaDetalleIngresoService(CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso detalleingreso, string id_detalle_ingreso, string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaDetalleIngresoService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaDetalleIngresoServiceAsync(CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso detalleingreso, string id_detalle_ingreso, string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarDetalleIngresoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarDetalleIngresoService(string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarDetalleIngresoService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarDetalleIngresoServiceAsync(string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionDetalleIngresoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso retornaPosicionDetalleIngresoService(int pos, string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionDetalleIngresoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso> retornaPosicionDetalleIngresoServiceAsync(int pos, string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarDetalleIngresoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso buscarDetalleIngresoService(string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarDetalleIngresoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso> buscarDetalleIngresoServiceAsync(string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdDetalleIngresoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso buscarIdDetalleIngresoService(string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdDetalleIngresoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso> buscarIdDetalleIngresoServiceAsync(string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarDetalleIngresoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarDetalleIngresoService(string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarDetalleIngresoService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarDetalleIngresoServiceAsync(string id_detalleingr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarDetalleIngresoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarDetalleIngresoService(CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso detalleingreso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarDetalleIngresoService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarDetalleIngresoServiceAsync(CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso detalleingreso);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class DetalleIngreso : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string id_detalleIngrField;
        
        private int cantidadField;
        
        private System.DateTime fecha_elaboracionField;
        
        private System.DateTime fecha_vencimientoField;
        
        private string medicamento_codicoField;
        
        private string ingreso_medicamento_id_ingresoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id_detalleIngr {
            get {
                return this.id_detalleIngrField;
            }
            set {
                this.id_detalleIngrField = value;
                this.RaisePropertyChanged("Id_detalleIngr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
                this.RaisePropertyChanged("Cantidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime Fecha_elaboracion {
            get {
                return this.fecha_elaboracionField;
            }
            set {
                this.fecha_elaboracionField = value;
                this.RaisePropertyChanged("Fecha_elaboracion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime Fecha_vencimiento {
            get {
                return this.fecha_vencimientoField;
            }
            set {
                this.fecha_vencimientoField = value;
                this.RaisePropertyChanged("Fecha_vencimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Medicamento_codico {
            get {
                return this.medicamento_codicoField;
            }
            set {
                this.medicamento_codicoField = value;
                this.RaisePropertyChanged("Medicamento_codico");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Ingreso_medicamento_id_ingreso {
            get {
                return this.ingreso_medicamento_id_ingresoField;
            }
            set {
                this.ingreso_medicamento_id_ingresoField = value;
                this.RaisePropertyChanged("Ingreso_medicamento_id_ingreso");
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
    public interface WebService1DetalleIngresoSoapChannel : CapaHtml.ServiceMantenedorDetalleIngreso.WebService1DetalleIngresoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1DetalleIngresoSoapClient : System.ServiceModel.ClientBase<CapaHtml.ServiceMantenedorDetalleIngreso.WebService1DetalleIngresoSoap>, CapaHtml.ServiceMantenedorDetalleIngreso.WebService1DetalleIngresoSoap {
        
        public WebService1DetalleIngresoSoapClient() {
        }
        
        public WebService1DetalleIngresoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1DetalleIngresoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1DetalleIngresoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1DetalleIngresoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaDetalleIngresoService(CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso detalleingreso, string id_detalle_ingreso, string codigo) {
            base.Channel.insertaDetalleIngresoService(detalleingreso, id_detalle_ingreso, codigo);
        }
        
        public System.Threading.Tasks.Task insertaDetalleIngresoServiceAsync(CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso detalleingreso, string id_detalle_ingreso, string codigo) {
            return base.Channel.insertaDetalleIngresoServiceAsync(detalleingreso, id_detalle_ingreso, codigo);
        }
        
        public System.Data.DataSet retornarDetalleIngresoService(string id_detalleingr) {
            return base.Channel.retornarDetalleIngresoService(id_detalleingr);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarDetalleIngresoServiceAsync(string id_detalleingr) {
            return base.Channel.retornarDetalleIngresoServiceAsync(id_detalleingr);
        }
        
        public CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso retornaPosicionDetalleIngresoService(int pos, string id_detalleingr) {
            return base.Channel.retornaPosicionDetalleIngresoService(pos, id_detalleingr);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso> retornaPosicionDetalleIngresoServiceAsync(int pos, string id_detalleingr) {
            return base.Channel.retornaPosicionDetalleIngresoServiceAsync(pos, id_detalleingr);
        }
        
        public CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso buscarDetalleIngresoService(string id_detalleingr) {
            return base.Channel.buscarDetalleIngresoService(id_detalleingr);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso> buscarDetalleIngresoServiceAsync(string id_detalleingr) {
            return base.Channel.buscarDetalleIngresoServiceAsync(id_detalleingr);
        }
        
        public CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso buscarIdDetalleIngresoService(string id_detalleingr) {
            return base.Channel.buscarIdDetalleIngresoService(id_detalleingr);
        }
        
        public System.Threading.Tasks.Task<CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso> buscarIdDetalleIngresoServiceAsync(string id_detalleingr) {
            return base.Channel.buscarIdDetalleIngresoServiceAsync(id_detalleingr);
        }
        
        public void eliminarDetalleIngresoService(string id_detalleingr) {
            base.Channel.eliminarDetalleIngresoService(id_detalleingr);
        }
        
        public System.Threading.Tasks.Task eliminarDetalleIngresoServiceAsync(string id_detalleingr) {
            return base.Channel.eliminarDetalleIngresoServiceAsync(id_detalleingr);
        }
        
        public void actualizarDetalleIngresoService(CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso detalleingreso) {
            base.Channel.actualizarDetalleIngresoService(detalleingreso);
        }
        
        public System.Threading.Tasks.Task actualizarDetalleIngresoServiceAsync(CapaHtml.ServiceMantenedorDetalleIngreso.DetalleIngreso detalleingreso) {
            return base.Channel.actualizarDetalleIngresoServiceAsync(detalleingreso);
        }
    }
}
