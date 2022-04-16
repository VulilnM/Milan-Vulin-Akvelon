using Akvelon_Internship_Test_Task.Models;
using Akvelon_Internship_Test_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<Project> GetAllProjects()
        {
            return _repo.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Project GetProjectById(int id)
        {
            return _repo.GetById(id);
        }

        [HttpPost]
        public void AddProject(Project proj)
        {
            _repo.Add(proj);
        }

        [HttpDelete]
        public void RemoveProject(Project proj)
        {
            _repo.Remove(proj);
        }

        [HttpPut]
        public void UpdateProject(Project proj)
        {
            _repo.Update(proj);
        }

    }
}
