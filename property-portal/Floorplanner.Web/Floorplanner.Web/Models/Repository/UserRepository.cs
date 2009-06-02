using System;
using System.ServiceModel;
using Floorplanner.Web.Models.Entity;

namespace Floorplanner.Web.Models.Repository
{
    public class UserRepository
    {
        private readonly ChannelFactory<IFloorplannerApi> _factory;
        private readonly IFloorplannerApi _proxy;

        public UserRepository()
        {
            _factory = FloorplannerFactory.GetFloorPlannerCatory();
            _proxy = _factory.CreateChannel();
        }

        public UserCollection ListAll()
        {
            var users = _proxy.ListUsers();
            ((IDisposable)_proxy).Dispose();
            return users;
        }

        public void Add(string company, string email, string eid)
        {
            var user = new User { Company = company, Email = email, ExternalIdentifier = eid, AccountType = "pro", CountryCode = "NL" };

            var createdUser = _proxy.CreateUser(user);

            ((IDisposable)_proxy).Dispose();
        }

        public void Edit(int id, string company, string email, string eid)
        {
            var user = _proxy.GetUser(id.ToString());
            user.Company = company;
            user.Email = email;
            user.ExternalIdentifier = eid;

            _proxy.EditUser(id.ToString(), user);

            ((IDisposable)_proxy).Dispose();
        }

        public void Delete(int id)
        {
            _proxy.DeleteUser(id.ToString()); // TODO: Fix it; "Unexpected end of file." Error Message.
            ((IDisposable)_proxy).Dispose();
        }

        public User GetUser(int id)
        {
            var user = _proxy.GetUser(id.ToString());
            ((IDisposable)_proxy).Dispose();
            return user;
        }

        public string GetUserToken(int id)
        {
            var user = _proxy.GetUserToken(id.ToString());
            ((IDisposable)_proxy).Dispose();
            return user.CurrentToken;
        }
    }
}
