using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Entities.Entity
{
    public class ParentTask
    {
        public virtual int ParentTaskId { get; set; }
        public virtual string ParentTaskName { get; set; }
    }
}
