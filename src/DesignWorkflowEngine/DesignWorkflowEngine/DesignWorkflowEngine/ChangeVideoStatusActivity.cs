using System;

namespace DesignWorkflowEngine
{
    public class ChangeVideoStatusActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to Processing");
        }
    }
}
