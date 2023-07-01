using ApiDeTarefas.Enus;
using ApiDeTarefas.Models;

namespace ApiDeTarefas.Data.Dtos
{
    public class UpdateUserDto
    {
        public int Id { get; internal set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
