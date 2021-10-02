using System;

namespace DesignWorkflowEngine
{
    public class SendEmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending mail to the owner of the video notifying them that the video started processing");
        }
    }
}
