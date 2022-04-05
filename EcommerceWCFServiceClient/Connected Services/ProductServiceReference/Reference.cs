﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceWCFServiceClient.ProductServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/EcommerceSystemWCFService")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SellerIdField;
        
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
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SellerId {
            get {
                return this.SellerIdField;
            }
            set {
                if ((this.SellerIdField.Equals(value) != true)) {
                    this.SellerIdField = value;
                    this.RaisePropertyChanged("SellerId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceReference.IProductService")]
    public interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProduct", ReplyAction="http://tempuri.org/IProductService/GetProductResponse")]
        EcommerceWCFServiceClient.ProductServiceReference.Product GetProduct(int prodId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProduct", ReplyAction="http://tempuri.org/IProductService/GetProductResponse")]
        System.Threading.Tasks.Task<EcommerceWCFServiceClient.ProductServiceReference.Product> GetProductAsync(int prodId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetAllProducts", ReplyAction="http://tempuri.org/IProductService/GetAllProductsResponse")]
        System.Data.DataSet GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetAllProducts", ReplyAction="http://tempuri.org/IProductService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetSellerProducts", ReplyAction="http://tempuri.org/IProductService/GetSellerProductsResponse")]
        System.Data.DataSet GetSellerProducts(int sellerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetSellerProducts", ReplyAction="http://tempuri.org/IProductService/GetSellerProductsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetSellerProductsAsync(int sellerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/CreateProduct", ReplyAction="http://tempuri.org/IProductService/CreateProductResponse")]
        string CreateProduct(EcommerceWCFServiceClient.ProductServiceReference.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/CreateProduct", ReplyAction="http://tempuri.org/IProductService/CreateProductResponse")]
        System.Threading.Tasks.Task<string> CreateProductAsync(EcommerceWCFServiceClient.ProductServiceReference.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/UpdateProduct", ReplyAction="http://tempuri.org/IProductService/UpdateProductResponse")]
        string UpdateProduct(EcommerceWCFServiceClient.ProductServiceReference.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/UpdateProduct", ReplyAction="http://tempuri.org/IProductService/UpdateProductResponse")]
        System.Threading.Tasks.Task<string> UpdateProductAsync(EcommerceWCFServiceClient.ProductServiceReference.Product prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DeleteProduct", ReplyAction="http://tempuri.org/IProductService/DeleteProductResponse")]
        string DeleteProduct(int prodId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/DeleteProduct", ReplyAction="http://tempuri.org/IProductService/DeleteProductResponse")]
        System.Threading.Tasks.Task<string> DeleteProductAsync(int prodId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : EcommerceWCFServiceClient.ProductServiceReference.IProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<EcommerceWCFServiceClient.ProductServiceReference.IProductService>, EcommerceWCFServiceClient.ProductServiceReference.IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EcommerceWCFServiceClient.ProductServiceReference.Product GetProduct(int prodId) {
            return base.Channel.GetProduct(prodId);
        }
        
        public System.Threading.Tasks.Task<EcommerceWCFServiceClient.ProductServiceReference.Product> GetProductAsync(int prodId) {
            return base.Channel.GetProductAsync(prodId);
        }
        
        public System.Data.DataSet GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public System.Data.DataSet GetSellerProducts(int sellerId) {
            return base.Channel.GetSellerProducts(sellerId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetSellerProductsAsync(int sellerId) {
            return base.Channel.GetSellerProductsAsync(sellerId);
        }
        
        public string CreateProduct(EcommerceWCFServiceClient.ProductServiceReference.Product prod) {
            return base.Channel.CreateProduct(prod);
        }
        
        public System.Threading.Tasks.Task<string> CreateProductAsync(EcommerceWCFServiceClient.ProductServiceReference.Product prod) {
            return base.Channel.CreateProductAsync(prod);
        }
        
        public string UpdateProduct(EcommerceWCFServiceClient.ProductServiceReference.Product prod) {
            return base.Channel.UpdateProduct(prod);
        }
        
        public System.Threading.Tasks.Task<string> UpdateProductAsync(EcommerceWCFServiceClient.ProductServiceReference.Product prod) {
            return base.Channel.UpdateProductAsync(prod);
        }
        
        public string DeleteProduct(int prodId) {
            return base.Channel.DeleteProduct(prodId);
        }
        
        public System.Threading.Tasks.Task<string> DeleteProductAsync(int prodId) {
            return base.Channel.DeleteProductAsync(prodId);
        }
    }
}
