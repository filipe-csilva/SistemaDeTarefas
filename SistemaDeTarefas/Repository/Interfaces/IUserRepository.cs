using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserMd>> SearchAllUsers();
        Task<UserMd?> SearchUserById(int id);
        Task<UserMd> AddUser(UserMd user);
        Task<UserMd> UpdateUserById(UserMd user, int id);
        Task<bool> DropUser(int id);
    }
}
