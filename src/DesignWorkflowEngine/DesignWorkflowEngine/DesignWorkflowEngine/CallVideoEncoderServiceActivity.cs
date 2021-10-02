using System;

namespace DesignWorkflowEngine
{
    public class CallVideoEncoderServiceActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding ");
        }
    }
}
