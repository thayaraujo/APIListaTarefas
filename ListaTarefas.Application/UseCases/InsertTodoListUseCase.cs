using ListaTarefas.Application.Models;
using System.Threading.Tasks;

namespace ListaTarefas.Application.UseCases
{
    public class InsertTodoListUseCase : IUseCaseAsync<TaskListRequest, TaskListResponse>
    {
        //implementação da interface
        public Task<TaskListResponse> ExecuteAsync(TaskListRequest request)
        {
            return Task.FromResult(new TaskListResponse());
        }

    }
}
