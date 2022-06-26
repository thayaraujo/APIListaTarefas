using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaTarefas.Application.Models;
using ListaTarefas.Application.UseCases;

namespace ListaTarefas.API.Controllers
{
    [ApiController]
    [Route("api/listatarefas")]
    public class ListaTarefasController : ControllerBase
    {
        private readonly ILogger<ListaTarefasController> _logger;
        private readonly IUseCaseAsync<TaskListRequest, TaskListResponse> _insertUseCase;

        public ListaTarefasController(ILogger<ListaTarefasController> logger,
            IUseCaseAsync<TaskListRequest, TaskListResponse> insertUseCase)
        {
            _logger = logger;
            _insertUseCase = insertUseCase;
        }

        [HttpGet]
        public IEnumerable<TaskListResponse> Get()
        {
            var tasks = new List<TaskListResponse>();
            tasks.Add(new TaskListResponse());
            tasks.Add(new TaskListResponse());

            return tasks;
        }

        [HttpPost]
        public async Task<TaskListResponse> Post([FromBody] TaskListRequest taskListRequest)
        {
            var response = await _insertUseCase.ExecuteAsync(taskListRequest);
            return response;
        }
    }
}
