using ListaTarefas.Application.Models;
using ListaTarefas.Core.Repositories;
using System.Threading.Tasks;

namespace ListaTarefas.Application.UseCases
{
    public class InsertTodoListUseCase : IUseCaseAsync<TaskListRequest, TaskListResponse>
    {
        private readonly IRepository _todoListRepository;

        public InsertTodoListUseCase(IRepository todoListRepository)
        {
            _todoListRepository = todoListRepository;
        }

        //implementação da interface
        public Task<TaskListResponse> ExecuteAsync(TaskListRequest request)
        {
            _todoListRepository.Inserir();
            return Task.FromResult(new TaskListResponse());
        }

    }
}
