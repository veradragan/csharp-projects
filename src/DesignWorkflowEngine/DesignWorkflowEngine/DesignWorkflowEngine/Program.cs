using System;

namespace DesignWorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // todo: use consistent naming for activities
            // todo: use verbs for actions (e.g. mail -> send mail)
            
            var workflow = new Workflow();
            workflow.RegisterActivity(new UploadVideoActivity());
            workflow.RegisterActivity(new CallVideoEncoderServiceActivity());
            workflow.RegisterActivity(new SendEmailActivity());
            workflow.RegisterActivity(new ChangeVideoStatusActivity());
            

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
