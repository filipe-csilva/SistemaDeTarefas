﻿using ApiDeTarefas.Enus;

namespace ApiDeTarefas.Data.Dtos
{
    public class CreateTaskDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public StatusTask Status { get; set; } = StatusTask.Todo;
        public int UserId { get; set; }
    }
}
