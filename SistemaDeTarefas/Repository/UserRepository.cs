using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ApiDeTarefas.Data;
using ApiDeTarefas.Models;
using ApiDeTarefas.Repository.Interfaces;

namespace ApiDeTarefas.Repository
{
    public class UserRepository : GenericRepository<UserMd>, IUserRepository
    {
        public UserRepository(SystemContext context) : base(context)
        {
        }
    }
}
