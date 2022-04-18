using Akvelon_Internship_Test_Task.Models;
using Akvelon_Internship_Test_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace TestTaskProjAkv.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IGenericRepository<Task> _repo;

        public TaskController(IGenericRepository<Task> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Task> GetAllTasks()
        {
            return _repo.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Task GetTaskById(int id)
        {
            return _repo.GetById(id);
        }

        [HttpPost]
        public void AddTask(Task task)
        {
            _repo.Add(task);
        }

        [HttpDelete]
        [Route("{id}")]
        public void RemoveTask(int taskId)
        {
            _repo.Remove(taskId);
        }

        [HttpPut]
        public void UpdateProject(Task task)
        {
            _repo.Update(task);
        }

    }
}
