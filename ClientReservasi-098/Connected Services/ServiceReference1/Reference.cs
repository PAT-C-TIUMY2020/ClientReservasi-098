﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientReservasi_098.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataRegister", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class DataRegister : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kategoriField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string kategori {
            get {
                return this.kategoriField;
            }
            set {
                if ((object.ReferenceEquals(this.kategoriField, value) != true)) {
                    this.kategoriField = value;
                    this.RaisePropertyChanged("kategori");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CekLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class CekLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeskripsiSingkatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaLokasiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DeskripsiSingkat {
            get {
                return this.DeskripsiSingkatField;
            }
            set {
                if ((object.ReferenceEquals(this.DeskripsiSingkatField, value) != true)) {
                    this.DeskripsiSingkatField = value;
                    this.RaisePropertyChanged("DeskripsiSingkat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDLokasi {
            get {
                return this.IDLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.IDLokasiField, value) != true)) {
                    this.IDLokasiField = value;
                    this.RaisePropertyChanged("IDLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaLokasi {
            get {
                return this.NamaLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaLokasiField, value) != true)) {
                    this.NamaLokasiField = value;
                    this.RaisePropertyChanged("NamaLokasi");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class DetailLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeskripsiFullField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KuotaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaLokasiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DeskripsiFull {
            get {
                return this.DeskripsiFullField;
            }
            set {
                if ((object.ReferenceEquals(this.DeskripsiFullField, value) != true)) {
                    this.DeskripsiFullField = value;
                    this.RaisePropertyChanged("DeskripsiFull");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDLokasi {
            get {
                return this.IDLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.IDLokasiField, value) != true)) {
                    this.IDLokasiField = value;
                    this.RaisePropertyChanged("IDLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Kuota {
            get {
                return this.KuotaField;
            }
            set {
                if ((this.KuotaField.Equals(value) != true)) {
                    this.KuotaField = value;
                    this.RaisePropertyChanged("Kuota");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaLokasi {
            get {
                return this.NamaLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaLokasiField, value) != true)) {
                    this.NamaLokasiField = value;
                    this.RaisePropertyChanged("NamaLokasi");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pemesanan", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi")]
    [System.SerializableAttribute()]
    public partial class Pemesanan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDPemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int JumlahPemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaCustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoTelponField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDPemesanan {
            get {
                return this.IDPemesananField;
            }
            set {
                if ((object.ReferenceEquals(this.IDPemesananField, value) != true)) {
                    this.IDPemesananField = value;
                    this.RaisePropertyChanged("IDPemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int JumlahPemesanan {
            get {
                return this.JumlahPemesananField;
            }
            set {
                if ((this.JumlahPemesananField.Equals(value) != true)) {
                    this.JumlahPemesananField = value;
                    this.RaisePropertyChanged("JumlahPemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lokasi {
            get {
                return this.LokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.LokasiField, value) != true)) {
                    this.LokasiField = value;
                    this.RaisePropertyChanged("Lokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaCustomer {
            get {
                return this.NamaCustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaCustomerField, value) != true)) {
                    this.NamaCustomerField = value;
                    this.RaisePropertyChanged("NamaCustomer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoTelpon {
            get {
                return this.NoTelponField;
            }
            set {
                if ((object.ReferenceEquals(this.NoTelponField, value) != true)) {
                    this.NoTelponField = value;
                    this.RaisePropertyChanged("NoTelpon");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        System.Threading.Tasks.Task<string> pemesananAsync(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        string editPemesanan(string IDPemesanan, string NamaCustomer, string Np_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        System.Threading.Tasks.Task<string> editPemesananAsync(string IDPemesanan, string NamaCustomer, string Np_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        string deletePemesanan(string IDPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        System.Threading.Tasks.Task<string> deletePemesananAsync(string IDPemesanan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        string Register(string username, string password, string kategori);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string kategori);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateRegister", ReplyAction="http://tempuri.org/IService1/UpdateRegisterResponse")]
        string UpdateRegister(string username, string password, string kategori, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateRegister", ReplyAction="http://tempuri.org/IService1/UpdateRegisterResponse")]
        System.Threading.Tasks.Task<string> UpdateRegisterAsync(string username, string password, string kategori, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegister", ReplyAction="http://tempuri.org/IService1/DeleteRegisterResponse")]
        string DeleteRegister(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegister", ReplyAction="http://tempuri.org/IService1/DeleteRegisterResponse")]
        System.Threading.Tasks.Task<string> DeleteRegisterAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataRegist", ReplyAction="http://tempuri.org/IService1/DataRegistResponse")]
        ClientReservasi_098.ServiceReference1.DataRegister[] DataRegist();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataRegist", ReplyAction="http://tempuri.org/IService1/DataRegistResponse")]
        System.Threading.Tasks.Task<ClientReservasi_098.ServiceReference1.DataRegister[]> DataRegistAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        ClientReservasi_098.ServiceReference1.CekLokasi[] ReviewLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_098.ServiceReference1.CekLokasi[]> ReviewLokasiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        ClientReservasi_098.ServiceReference1.DetailLokasi[] DetailLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_098.ServiceReference1.DetailLokasi[]> DetailLokasiAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (Pemesanan) of message PemesananRequest does not match the default value (Pemesanan1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        ClientReservasi_098.ServiceReference1.PemesananResponse Pemesanan1(ClientReservasi_098.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        System.Threading.Tasks.Task<ClientReservasi_098.ServiceReference1.PemesananResponse> Pemesanan1Async(ClientReservasi_098.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Pemesanan", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananRequest {
        
        public PemesananRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PemesananResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ClientReservasi_098.ServiceReference1.Pemesanan[] PemesananResult;
        
        public PemesananResponse() {
        }
        
        public PemesananResponse(ClientReservasi_098.ServiceReference1.Pemesanan[] PemesananResult) {
            this.PemesananResult = PemesananResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientReservasi_098.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientReservasi_098.ServiceReference1.IService1>, ClientReservasi_098.ServiceReference1.IService1 {
        
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
        
        public string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi) {
            return base.Channel.pemesanan(IDPemesanan, NamaCustomer, NoTelpon, JumlahPemesanan, IDLokasi);
        }
        
        public System.Threading.Tasks.Task<string> pemesananAsync(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi) {
            return base.Channel.pemesananAsync(IDPemesanan, NamaCustomer, NoTelpon, JumlahPemesanan, IDLokasi);
        }
        
        public string editPemesanan(string IDPemesanan, string NamaCustomer, string Np_telpon) {
            return base.Channel.editPemesanan(IDPemesanan, NamaCustomer, Np_telpon);
        }
        
        public System.Threading.Tasks.Task<string> editPemesananAsync(string IDPemesanan, string NamaCustomer, string Np_telpon) {
            return base.Channel.editPemesananAsync(IDPemesanan, NamaCustomer, Np_telpon);
        }
        
        public string deletePemesanan(string IDPemesanan) {
            return base.Channel.deletePemesanan(IDPemesanan);
        }
        
        public System.Threading.Tasks.Task<string> deletePemesananAsync(string IDPemesanan) {
            return base.Channel.deletePemesananAsync(IDPemesanan);
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public string Register(string username, string password, string kategori) {
            return base.Channel.Register(username, password, kategori);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string kategori) {
            return base.Channel.RegisterAsync(username, password, kategori);
        }
        
        public string UpdateRegister(string username, string password, string kategori, int id) {
            return base.Channel.UpdateRegister(username, password, kategori, id);
        }
        
        public System.Threading.Tasks.Task<string> UpdateRegisterAsync(string username, string password, string kategori, int id) {
            return base.Channel.UpdateRegisterAsync(username, password, kategori, id);
        }
        
        public string DeleteRegister(string username) {
            return base.Channel.DeleteRegister(username);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRegisterAsync(string username) {
            return base.Channel.DeleteRegisterAsync(username);
        }
        
        public ClientReservasi_098.ServiceReference1.DataRegister[] DataRegist() {
            return base.Channel.DataRegist();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_098.ServiceReference1.DataRegister[]> DataRegistAsync() {
            return base.Channel.DataRegistAsync();
        }
        
        public ClientReservasi_098.ServiceReference1.CekLokasi[] ReviewLokasi() {
            return base.Channel.ReviewLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_098.ServiceReference1.CekLokasi[]> ReviewLokasiAsync() {
            return base.Channel.ReviewLokasiAsync();
        }
        
        public ClientReservasi_098.ServiceReference1.DetailLokasi[] DetailLokasi() {
            return base.Channel.DetailLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_098.ServiceReference1.DetailLokasi[]> DetailLokasiAsync() {
            return base.Channel.DetailLokasiAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientReservasi_098.ServiceReference1.PemesananResponse ClientReservasi_098.ServiceReference1.IService1.Pemesanan1(ClientReservasi_098.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1(request);
        }
        
        public ClientReservasi_098.ServiceReference1.Pemesanan[] Pemesanan1() {
            ClientReservasi_098.ServiceReference1.PemesananRequest inValue = new ClientReservasi_098.ServiceReference1.PemesananRequest();
            ClientReservasi_098.ServiceReference1.PemesananResponse retVal = ((ClientReservasi_098.ServiceReference1.IService1)(this)).Pemesanan1(inValue);
            return retVal.PemesananResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientReservasi_098.ServiceReference1.PemesananResponse> ClientReservasi_098.ServiceReference1.IService1.Pemesanan1Async(ClientReservasi_098.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1Async(request);
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_098.ServiceReference1.PemesananResponse> Pemesanan1Async() {
            ClientReservasi_098.ServiceReference1.PemesananRequest inValue = new ClientReservasi_098.ServiceReference1.PemesananRequest();
            return ((ClientReservasi_098.ServiceReference1.IService1)(this)).Pemesanan1Async(inValue);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
    }
}
