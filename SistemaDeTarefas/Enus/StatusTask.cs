using System.ComponentModel;

namespace ApiDeTarefas.Enus
{
    public enum StatusTask
    {
        [Description("To do")]
        Todo = 1,
        [Description("In Progress")]
        InProgress = 2,
        [Description("Concluded")]
        Concluded = 3
    }
}
