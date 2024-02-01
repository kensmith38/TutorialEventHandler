using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialEventHandler
{
    public class MyLogger
    {
        public MyLogger(MyWorker myWorker)
        {
            myWorker.ProjectTaskCompleted += HandleProjectTaskCompleted;
        }
        public void HandleProjectTaskCompleted(object? sender, ProjectTaskEventArgs projectTaskEventArgs)
        {
            //<here is where you put all the code for logging>
            Debug.WriteLine($"Logged info for the completed project task: " 
                + $"\n    Project ID: {projectTaskEventArgs.ProjectID} "
                + $"\n    Task desc: {projectTaskEventArgs.TaskDesc} "
                + $"\n    Date completed: {projectTaskEventArgs.DateTaskCompleted.ToShortDateString()} ");
        }
    }
}
