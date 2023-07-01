using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ApiDeTarefas.Data;
using ApiDeTarefas.Models;
using ApiDeTarefas.Repository.Interfaces;

namespace ApiDeTarefas.Repository
{
    public class TaskRepository : GenericRepository<TaskMd>, ITaskRepository
    {
        public TaskRepository(SystemContext context) : base(context)
        {
        }

        public override async Task<ICollection<TaskMd>> GetAll()
        {
            return await _context.Tasks.Include(x => x.User).ToListAsync();
        }

        public override async Task<TaskMd> GetById(object[] keys)
        {
            int id = (int)keys[0];
            
            return await _context.Tasks
                .Where(x => x.Id == id)
                .Include(x => x.User)
                .SingleAsync();
        }
    }
}
