using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marionettes
{
    public partial class MainForm : Form
    {
        private TaskCompletionSource<int> tcs = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void consumeTaskButton_Click(object sender, EventArgs e)
        {
            consumeTaskButton.Enabled = false;
            consumeTaskLabel.Text = "Waiting for the task to complete...";

            try
            {
                int result = await ComputeAsync();
                consumeTaskLabel.Text = $"The task successfully returned result {result}.";
            }
            catch (TaskFaultedException)
            {
                consumeTaskLabel.Text = "The task was not successful and throwed an exception.";
            }

            consumeTaskButton.Enabled = true;
        }

        private Task<int> ComputeAsync()
        {
            tcs = new TaskCompletionSource<int>();

            completeTaskLabel.Text = "A task has been initiated. Enter the desired result to return and click \"Complete Task\" to complete the task, or click \"Fault\" to fault the task:";
            completeTaskResultInput.Enabled = true;
            completeTaskButton.Enabled = true;
            completeTaskFaultButton.Enabled = true;

            return tcs.Task;
        }

        private void completeTaskButton_Click(object sender, EventArgs e)
        {
            completeTaskFaultButton.Enabled = false;
            completeTaskResultInput.Enabled = false;
            completeTaskButton.Enabled = false;

            int result = (int)Math.Round(completeTaskResultInput.Value);
            completeTaskLabel.Text = $"The task is completed with result {result}.";
            tcs.SetResult(result);

            tcs = null;
        }

        private void completeTaskFaultButton_Click(object sender, EventArgs e)
        {
            completeTaskButton.Enabled = false;
            completeTaskResultInput.Enabled = false;
            completeTaskFaultButton.Enabled = false;

            completeTaskLabel.Text = $"The task is faulted.";
            tcs.SetException(new TaskFaultedException());

            tcs = null;
        }

        private sealed class TaskFaultedException : Exception
        {
        }
    }
}
