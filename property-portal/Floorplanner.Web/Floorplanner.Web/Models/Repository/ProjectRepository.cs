using System;
using System.ServiceModel;
using Floorplanner.Web.Models.Entity;

namespace Floorplanner.Web.Models.Repository
{
    public class ProjectRepository
    {
        private readonly ChannelFactory<IFloorplannerApi> _factory;
        private readonly IFloorplannerApi _proxy;

        public ProjectRepository()
        {
            _factory = FloorplannerFactory.GetFloorPlannerCatory();
            _proxy = _factory.CreateChannel();
        }

        public ProjectCollection ListAll()
        {
            var projects = _proxy.ListProjects();
            ((IDisposable)_proxy).Dispose();
            return projects;
        }

        public ProjectCollection GetPorjects(int id)
        {
            var projects = _proxy.GetProjects(id.ToString());
            ((IDisposable)_proxy).Dispose();
            return projects;
        }

        public void Add(DateTime createdAt, string description, string name, string eid, int numberOfFloors, int userId, FloorCollection floors)
        {
            var project = new Project
                              {
                                  CreatedAt = createdAt.ToString("s"),
                                  Description = description,
                                  Name = name,
                                  ExternalIdentifier = eid,
                                  UserId = userId,
                                  FloorsCount = numberOfFloors,
                                  Floors = floors,
                              };

            project.Floors.Type = "array";

            _proxy.CreateProject(project, userId.ToString());
            ((IDisposable)_proxy).Dispose();
        }

        public void Edit(int id, DateTime updatedAt, string description, string name, string eid, int numberOfFloors, FloorCollection floors)
        {
            var project = _proxy.GetProject((id.ToString()));

            project.UpdateAt = updatedAt.ToString("s");
            project.Description = description;
            project.Name = name;
            project.ExternalIdentifier = eid;
            project.FloorsCount = numberOfFloors;
            project.Floors = floors;
            project.Floors.Type = "array";

            _proxy.EditProject(project.UserId.ToString(), id.ToString(), project);
            ((IDisposable)_proxy).Dispose();
        }

        public Project GetProject(int id)
        {
            var project = _proxy.GetProject(id.ToString());
            return project;
        }

        public void Delete(int id)
        {
            _proxy.DeleteProject(id.ToString()); // TODO: Fix it; "Unexpected end of file." Error Message. 
            ((IDisposable)_proxy).Dispose();
        }
    }
}
