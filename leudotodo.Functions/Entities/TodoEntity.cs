using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace leudotodo.Functions.Entities
{
    public class TodoEntity : TableEntity
    {
        public DateTime CreateTime { get; set; }
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
