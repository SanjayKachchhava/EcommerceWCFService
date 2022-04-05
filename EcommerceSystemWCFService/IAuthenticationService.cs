using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceSystemWCFService
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        RegisterUserResult RegisterUser(User user);

        [OperationContract]
        LoginResult Login(string userName, string password);

    }

    [DataContract]
    public class RegisterUserResult
    {
        [DataMember]
        public bool success { get; set; }

        [DataMember]
        public string message { get; set; }

    }

    [DataContract]
    public class LoginResult
    {
        [DataMember]
        public bool success { get; set; }

        [DataMember]
        public int _yourId { get; set; }

        [DataMember]
        public string message { get; set; }

    }

    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId
        {
            get;set;
        }

        [DataMember]
        public string Username
        {
            get; set;
        }

        [DataMember]
        public string FirstName
        {
            get; set;
        }

        [DataMember]
        public string LastName
        {
            get; set;
        }

        [DataMember]
        public int Gender // 0 = male 1 = female 2= other
        {
            get; set;
        }

        [DataMember]
        public string MobileNumber
        {
            get; set;
        }

        [DataMember]
        public string Address
        {
            get; set;
        }


        [DataMember]
        public string Password
        {
            get; set;
        }
    }


}
