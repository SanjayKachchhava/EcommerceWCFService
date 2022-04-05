using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EcommerceSystemWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Product GetProduct(int prodId);

        [OperationContract]
        DataSet GetAllProducts();

        [OperationContract]
        DataSet GetSellerProducts(int sellerId);

        [OperationContract]
        string CreateProduct(Product prod);

        [OperationContract]
        string UpdateProduct(Product prod);

        [OperationContract]
        string DeleteProduct(int prodId);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "EcommerceSystemWCFService.ContractType".
    [DataContract]
    public class Product
    {
        
        [DataMember]
        public int ProductId
        {
            get;
            set;
        }

        [DataMember]
        public string ProductName
        {
            get;
            set;
        }

        [DataMember]
        public string Category
        {
            get;
            set;
        }

        [DataMember]
        public double Price
        {
            get;
            set;
        }

        [DataMember]
        public int Quantity
        {
            get;
            set;
        }

        [DataMember]
        public int SellerId
        {
            get;
            set;
        }

    }
}
