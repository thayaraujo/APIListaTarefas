using ListaTarefas.Application.Models;
using System.Threading.Tasks;

namespace ListaTarefas.Application.UseCases
{
    public interface IUseCaseAsync<TRequest, TResponse>
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}
