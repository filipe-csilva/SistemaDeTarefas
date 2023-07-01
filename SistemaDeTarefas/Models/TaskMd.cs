using ApiDeTarefas.Enus;

namespace ApiDeTarefas.Models
{
    public class TaskMd
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public StatusTask Status { get; set; }
        public int UserId { get; set; }
        public virtual UserMd? User { get; set; }
    }
}
