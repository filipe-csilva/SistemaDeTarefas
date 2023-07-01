using ApiDeTarefas.Enus;
using ApiDeTarefas.Models;

namespace ApiDeTarefas.Data.Dtos
{
    public class UpdateTaskDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public StatusTask Status { get; set; }
        public int UserId { get; set; }
        public virtual UserMd? User { get; set; }
    }
}
