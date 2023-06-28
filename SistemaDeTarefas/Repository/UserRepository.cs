using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repository.Interfaces;

namespace SistemaDeTarefas.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly SystemContext _dbContext;

        public UserRepository(SystemContext systemContext)
        {
            _dbContext = systemContext;
        }

        public async Task<UserMd> SearchUserById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<UserMd>> SearchAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<UserMd> AddUser(UserMd user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return user;
            //return Task.FromResult(user);
        }

        public async Task<UserMd> UpdateUserById(UserMd user, int id)
        {
            UserMd userById = await SearchUserById(id);

            if(userById == null)
                throw new Exception($"The user by {id} not found.");

            userById.Name = user.Name;
            userById.Email = user.Email;

            _dbContext.Users.Update(userById);
            _dbContext.SaveChanges();

            return userById;
        }

        public async Task<bool> Drop(int id)
        {
            UserMd userById = await SearchUserById(id);

            if (userById == null)
                throw new Exception($"The user by {id} not found.");

            _dbContext.Users.Remove(userById);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
