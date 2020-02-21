using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities.Entity;
namespace TaskManagerCoreTest.ExceptionTest
{
    [TestFixture]
    class ExceptionTest
    {


        [Test]
        public void ExceptionTestForPriority()
        {
            //Arrange
            Tasks task = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 31
            };

            Assert.GreaterOrEqual(1, task.Priority);

        }

    }
        
    }

