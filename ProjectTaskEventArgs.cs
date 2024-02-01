using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialEventHandler
{
    public class ProjectTaskEventArgs : EventArgs
    {
        public string ProjectID { get; set; }
        public string TaskDesc { get; set; }
        public DateTime DateTaskCompleted { get; set; }
    }
}
