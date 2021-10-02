namespace DesignWorkflowEngine
{
    public class WorkflowEngine
    {
        public WorkflowEngine()
        {
        }

        public void Run(Workflow workflow)
        {
            //workflow.Execute();
            foreach (var activity in workflow.GetActivities())
                activity.Execute();
        }
    }
}
