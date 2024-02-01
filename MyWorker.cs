using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialEventHandler
{
    // Reference: https://learn.microsoft.com/en-us/dotnet/standard/events/
    // Reference: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/event
    // Reference: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines
    // ======================================================================================
    // This class (MyWorker) performs the task and raises the event ProjectTaskCompleted.
    // ======================================================================================
    public class MyWorker
    {
        public event EventHandler<ProjectTaskEventArgs> ProjectTaskCompleted;
        protected virtual void OnProjectTaskCompleted(ProjectTaskEventArgs projectTaskEventArgs)
        {
            ProjectTaskCompleted?.Invoke(this, projectTaskEventArgs);
        }
        public void DoWork(string projectId, string taskDesc)
        {
            // <Here is where all the code would exist to complete the task.>

            // set the event args
            ProjectTaskEventArgs projectTaskEventArgs = new ProjectTaskEventArgs
            {
                ProjectID = projectId,
                TaskDesc = taskDesc,
                DateTaskCompleted = DateTime.Now
            };
            // call the method which raises the event
            OnProjectTaskCompleted(projectTaskEventArgs);
        }
    }
}
