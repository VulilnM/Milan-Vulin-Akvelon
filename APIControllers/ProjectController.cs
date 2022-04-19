using Akvelon_Internship_Test_Task.Models;
using Akvelon_Internship_Test_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Akvelon_Internship_Test_Task.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IGenericRepository<Project> _repo;

        public ProjectController(IGenericRepository<Project> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Returns all the projects in the database.")]
        [SwaggerResponse(200, "Everything is fine, returnig all projects!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public IEnumerable<Project> GetAllProjects()
        {
            return _repo.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        [SwaggerOperation(Summary = "Returns the specific project with the specified projectId.")]
        [SwaggerResponse(200, "Everything is fine, returnig the project!")]
        [SwaggerResponse(400, "Bad request, please check the parameter again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public Project GetProjectById(int id)
        {
            return _repo.GetById(id);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Adds a project to the database.")]
        [SwaggerResponse(201, "Project succesfully saved to the database!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public void AddProject([FromForm] Project proj)
        {
            _repo.Add(proj);
        }

        [HttpDelete]
        [Route("{id}")]
        [SwaggerOperation(Summary = "Deletes the specified project form the database (project with the specified id) if it exists.")]
        [SwaggerResponse(200, "Everything is fine, project deleted!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public void RemoveProject(int id)
        {
            _repo.Remove(id);
        }
        [HttpDelete]
        [Route("removeProjects")]
        [SwaggerOperation(Summary = "Removes a range of projects with the specified IDs (if they exist).")]
        [SwaggerResponse(200, "Everything is fine, specified projects deleted!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public void RemoveProjects(IEnumerable<int> ids)
        {
            _repo.RemoveRange(ids);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Updates the specified project form the database (project with the specified id) if it exists.")]
        [SwaggerResponse(200, "Everything is fine, project updated!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public void UpdateProject(Project proj)
        {
            _repo.Update(proj);
        }

    }
}
