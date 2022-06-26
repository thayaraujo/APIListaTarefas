using ListaTarefas.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas.Infra.Repositories
{
    public class ToDoListRepository : IRepository
    {
        public Task Inserir()
        {
            return Task.CompletedTask;
        }
    }
}
