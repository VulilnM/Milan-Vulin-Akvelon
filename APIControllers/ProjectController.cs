using Akvelon_Internship_Test_Task.Models;
using Akvelon_Internship_Test_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Akvelon_Internship_Test_Task.APIControllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class ProjectController : ControllerBase
    {

        private readonly IGenericRepository<Project> _repo;
        private readonly AppDbContext _context;

        public ProjectController(IGenericRepository<Project> repo, AppDbContext appDbContext)
        {
            _repo = repo;
            _context = appDbContext;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Returns all the projects in the database, with theirs related task.")]
        [SwaggerResponse(200, "Everything is fine, returnig all projects!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public IEnumerable<Project> GetAllProjects()
        {
            var _projectsWithTasks = _repo.GetAll();
            
            foreach (var _project in _projectsWithTasks) 

                // Find all of the related tasks for the passed project
               _repo.FindTasksForProject(_project);

            return _projectsWithTasks;

        }

        [HttpGet]
        [Route("{id}")]
        [SwaggerOperation(Summary = "Returns the specific project with the specified projectId and all of its related tasks.")]
        [SwaggerResponse(200, "Everything is fine, returnig the project!")]
        [SwaggerResponse(400, "Bad request, please check the parameter again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public Project GetProjectById(int id)
        {
            Project _project = _repo.GetById(id);

            // Find all of the related tasks for the passed project
            _repo.FindTasksForProject(_project);

            return _project;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Adds a project to the database.")]
        [SwaggerResponse(201, "Project succesfully saved to the database!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public void AddProject(Project proj)
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
