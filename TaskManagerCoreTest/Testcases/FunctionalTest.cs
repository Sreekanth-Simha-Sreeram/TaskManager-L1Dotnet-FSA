using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities.Entity;
using TaskManager.BusinessLayer.ServicesImplimentation;

namespace TaskManagerCoreTest.FunctionalTest
{
    class FunctionalTest
    {

        ProjectManagerServices projectManager;
        UserServices user_services;
        Tasks tasks;

       [SetUp]
        public void init()
        {
            projectManager = new ProjectManagerServices();
            user_services = new UserServices();
        }

        [Test]
        public void AddTaskTest()
        {
            //Arrange
          tasks = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 20
            };

            //Action
            var IsAdded = projectManager.AddTask(tasks);

            //Action
            Assert.AreEqual(true, IsAdded);
        }


        [Test]
        public void ViewTasksTestForManager()
        {
            List<Tasks> listTask = new List<Tasks>();
            User users = new User();

            //Action
            var listOfTaskForManager = projectManager.ViewTask();

            //Assert
            Assert.AreEqual(listTask, listOfTaskForManager);
        }


        [Test]
        public void Test_For_UpdatingTaskTest()
        {
            Tasks task = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 20
            };

            //Action
            var updatedtask = projectManager.UpdateTask(task.TaskId);
            var gotUpadtedTask = projectManager.GetTaskById(task.TaskId);

            //Assert
            Assert.AreEqual(gotUpadtedTask, updatedtask);
        }


        public void EndTaskTest()
        {
            //Arrange
            Tasks task = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 20
            };

            //Action

            var IsEnded = projectManager.EndTask(task);

            //Action
            Assert.AreEqual(true, IsEnded);
        }

        
        [Test]
        public void TestSearchTask()
        {
            //Arrange 
            Tasks task = new Tasks()
            {
                TaskId = 1,
                ParentTaskId = 2,
                TaskName = "MvcCrud",
                StartDate = new DateTime(2020, 02, 18),
                EndDate = new DateTime(2020, 02, 20),
                Priority = 20
            };
            User user = new User();

            //Action
            var Searchedtask=user_services.SearchTask(task,user);
            var searched = user_services.getTaskById(task.TaskId);
           
            //Assert
            Assert.AreEqual(searched, Searchedtask);
        }

        [Test]
        public void ViewTasksForUserTest()
        {
            List<Tasks> listTask = new List<Tasks>();
            listTask.Add(tasks);
            User users = new User();

            //Action
           
             var listOfTaskForUser = user_services.ViewTask(users);

            //Assert
            Assert.AreEqual(listTask, listOfTaskForUser);
        }

    }
}

    
