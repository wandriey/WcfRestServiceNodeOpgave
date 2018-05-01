using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestServiceNodeOpgave
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        //Routing til metoden "GetAll".
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "getall/")]
        List<Feedback> GetAll();


        //[OperationContract]
        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, 
        //    UriTemplate = "feedback?id={id}")] //en customer
        //Feedback GetFeedback(int id

        //[OperationContract]
        //[WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "deleteCustomer?id={id}")]
        //void DeleteCustomer(int id);

        //[OperationContract]
        //[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "insertCustomer/")]
        //void InsertCustomer(Customer customer);

        //[OperationContract]
        //[WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "updateCustomer?id={id}")]
        //void UpdateCustomer(Customer updatedCustomer, int id);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
