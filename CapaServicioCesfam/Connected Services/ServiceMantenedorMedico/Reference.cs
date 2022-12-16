﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaServicioCesfam.ServiceMantenedorMedico {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMantenedorMedico.WebServiceMedicoSoap")]
    public interface WebServiceMedicoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaMedicoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void insertaMedicoService(CapaServicioCesfam.ServiceMantenedorMedico.Medico auxMedico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertaMedicoService", ReplyAction="*")]
        System.Threading.Tasks.Task insertaMedicoServiceAsync(CapaServicioCesfam.ServiceMantenedorMedico.Medico auxMedico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarMedicamentoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retornarMedicamentoService(string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornarMedicamentoService", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retornarMedicamentoServiceAsync(string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionMedicoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorMedico.Medico retornaPosicionMedicoService(int pos, string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retornaPosicionMedicoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorMedico.Medico> retornaPosicionMedicoServiceAsync(int pos, string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarMedicoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorMedico.Medico buscarMedicoService(string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarMedicoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorMedico.Medico> buscarMedicoServiceAsync(string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdMedicoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CapaServicioCesfam.ServiceMantenedorMedico.Medico buscarIdMedicoService(string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/buscarIdMedicoService", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorMedico.Medico> buscarIdMedicoServiceAsync(string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarMedicoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarMedicoService(string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarMedicoService", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarMedicoServiceAsync(string rut_medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarMedicoService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void actualizarMedicoService(CapaServicioCesfam.ServiceMantenedorMedico.Medico medico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizarMedicoService", ReplyAction="*")]
        System.Threading.Tasks.Task actualizarMedicoServiceAsync(CapaServicioCesfam.ServiceMantenedorMedico.Medico medico);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Medico : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string rut_medicoField;
        
        private string nombre_completoField;
        
        private string especialidadField;
        
        private string direccionField;
        
        private string telefonoField;
        
        private string emailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Rut_medico {
            get {
                return this.rut_medicoField;
            }
            set {
                this.rut_medicoField = value;
                this.RaisePropertyChanged("Rut_medico");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre_completo {
            get {
                return this.nombre_completoField;
            }
            set {
                this.nombre_completoField = value;
                this.RaisePropertyChanged("Nombre_completo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Especialidad {
            get {
                return this.especialidadField;
            }
            set {
                this.especialidadField = value;
                this.RaisePropertyChanged("Especialidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("Direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("Telefono");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
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
    public interface WebServiceMedicoSoapChannel : CapaServicioCesfam.ServiceMantenedorMedico.WebServiceMedicoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceMedicoSoapClient : System.ServiceModel.ClientBase<CapaServicioCesfam.ServiceMantenedorMedico.WebServiceMedicoSoap>, CapaServicioCesfam.ServiceMantenedorMedico.WebServiceMedicoSoap {
        
        public WebServiceMedicoSoapClient() {
        }
        
        public WebServiceMedicoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceMedicoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceMedicoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceMedicoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void insertaMedicoService(CapaServicioCesfam.ServiceMantenedorMedico.Medico auxMedico) {
            base.Channel.insertaMedicoService(auxMedico);
        }
        
        public System.Threading.Tasks.Task insertaMedicoServiceAsync(CapaServicioCesfam.ServiceMantenedorMedico.Medico auxMedico) {
            return base.Channel.insertaMedicoServiceAsync(auxMedico);
        }
        
        public System.Data.DataSet retornarMedicamentoService(string rut_medico) {
            return base.Channel.retornarMedicamentoService(rut_medico);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retornarMedicamentoServiceAsync(string rut_medico) {
            return base.Channel.retornarMedicamentoServiceAsync(rut_medico);
        }
        
        public CapaServicioCesfam.ServiceMantenedorMedico.Medico retornaPosicionMedicoService(int pos, string rut_medico) {
            return base.Channel.retornaPosicionMedicoService(pos, rut_medico);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorMedico.Medico> retornaPosicionMedicoServiceAsync(int pos, string rut_medico) {
            return base.Channel.retornaPosicionMedicoServiceAsync(pos, rut_medico);
        }
        
        public CapaServicioCesfam.ServiceMantenedorMedico.Medico buscarMedicoService(string rut_medico) {
            return base.Channel.buscarMedicoService(rut_medico);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorMedico.Medico> buscarMedicoServiceAsync(string rut_medico) {
            return base.Channel.buscarMedicoServiceAsync(rut_medico);
        }
        
        public CapaServicioCesfam.ServiceMantenedorMedico.Medico buscarIdMedicoService(string rut_medico) {
            return base.Channel.buscarIdMedicoService(rut_medico);
        }
        
        public System.Threading.Tasks.Task<CapaServicioCesfam.ServiceMantenedorMedico.Medico> buscarIdMedicoServiceAsync(string rut_medico) {
            return base.Channel.buscarIdMedicoServiceAsync(rut_medico);
        }
        
        public void eliminarMedicoService(string rut_medico) {
            base.Channel.eliminarMedicoService(rut_medico);
        }
        
        public System.Threading.Tasks.Task eliminarMedicoServiceAsync(string rut_medico) {
            return base.Channel.eliminarMedicoServiceAsync(rut_medico);
        }
        
        public void actualizarMedicoService(CapaServicioCesfam.ServiceMantenedorMedico.Medico medico) {
            base.Channel.actualizarMedicoService(medico);
        }
        
        public System.Threading.Tasks.Task actualizarMedicoServiceAsync(CapaServicioCesfam.ServiceMantenedorMedico.Medico medico) {
            return base.Channel.actualizarMedicoServiceAsync(medico);
        }
    }
}
