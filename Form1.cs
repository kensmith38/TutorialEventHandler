using System.Security.Policy;

namespace TutorialEventHandler
{
    public partial class Form1 : Form
    {
        // Note that "myWorker" does all the work and raises the event ProjectTaskCompleted.
        MyWorker myWorker = new MyWorker();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTaskList.SelectedIndex = 0;
            // Add as many classes as needed to handle the event (ProjectTaskCompleted).
            MyLogger myLogger = new MyLogger(myWorker);
            MyEmailer myEmailer = new MyEmailer(myWorker);
        }
        private void buttonPerformTask_Click(object sender, EventArgs e)
        {
            // myWorker does all the major complex processing for the task
            myWorker.DoWork(textBoxProjectId.Text, comboBoxTaskList.Text);
        }
    }
}
