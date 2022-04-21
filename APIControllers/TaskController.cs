using Akvelon_Internship_Test_Task.Models;
using Akvelon_Internship_Test_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
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
        [SwaggerOperation(Summary = "Returns all the tasks in the database.")]
        [SwaggerResponse(200, "Everything is fine, returnig all tasks!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public IEnumerable<Task> GetAllTasks()
        {
            IEnumerable<Task> _tasks = _repo.GetAll();
            foreach (Task t in _tasks)
            {
                // Finds the related project for the task specified
                t.Project = _repo.FindProjectForTask(t);
            }

            return _tasks; 
        }

        [HttpGet]
        [Route("{id}")]
        [SwaggerOperation(Summary = "Returns the specific task with the specified taskId.")]
        [SwaggerResponse(200, "Everything is fine, returnig the task!")]
        [SwaggerResponse(400, "Bad request, please check the parameter again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public Task GetTaskById(int id)
        {
            Task _task = _repo.GetById(id);

            // Finds the related project for the task specified
            _task.Project = _repo.FindProjectForTask(_task);

            return _task;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Adds a task to the database.")]
        [SwaggerResponse(201, "Task succesfully saved to the database!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public void AddTask(Task task)
        {
            _repo.Add(task);
        }

        [HttpDelete]
        [Route("{id}")]
        [SwaggerOperation(Summary = "Deletes the specified task form the database (task with the specified id) if it exists.")]
        [SwaggerResponse(200, "Everything is fine, task deleted!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public void RemoveTask(int taskId)
        {
            _repo.Remove(taskId);
        }

        [HttpDelete]
        [Route("removeTasks")]
        [SwaggerOperation(Summary = "Removes a range of tasks with the specified IDs (if they exist).")]
        [SwaggerResponse(200, "Everything is fine, specified tasks deleted!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public void RemoveTasks(IEnumerable<int> ids)
        {
            _repo.RemoveRange(ids);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Updates the specified task form the database (task with the specified id) if it exists.")]
        [SwaggerResponse(200, "Everything is fine, task updated!")]
        [SwaggerResponse(400, "Bad request, please check the parameters again!")]
        [SwaggerResponse(500, "Server has a problem, something is wrong on the server side!")]
        public void UpdateProject(Task task)
        {
            _repo.Update(task);
        }

    }
}
