using System.ServiceModel;
using System.ServiceModel.Web;
using Floorplanner.Web.Models.Entity;

namespace Floorplanner.Web.Models
{
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IFloorplannerApi
    {
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Xml, UriTemplate = "users.xml")]
        UserCollection ListUsers();

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Xml, UriTemplate = "projects.xml")]
        ProjectCollection ListProjects();

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Xml, UriTemplate = "users/{id}/projects.xml")]
        ProjectCollection GetProjects(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "users.xml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        User CreateUser(User user);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/users/{userId}/projects.xml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        Project CreateProject(Project project, string userId);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "users/{id}.xml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        User EditUser(string id, User user);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/users/{userId}/projects/{id}.xml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        Project EditProject(string userId, string id, Project project);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "users/{id}.xml", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        void DeleteUser(string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "projects/{id}.xml", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        void DeleteProject(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "users/{id}.xml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        User GetUser(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "projects/{id}.xml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        Project GetProject(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "users/{id}/token.xml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        User GetUserToken(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "projects/{id}/export.fml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        User ExportProject(string id);
    }
}
