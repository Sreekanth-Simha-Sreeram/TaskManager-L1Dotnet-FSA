using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Entities.Entity;

namespace TaskManager.BusinessLayer.Interfaces
{
   public interface IProjectManager
    {
        bool AddTask(Tasks OfTask);
        List<Tasks> ViewTask();
        Tasks UpdateTask(int Id);
        void EndTask(int Id);
    }
}
