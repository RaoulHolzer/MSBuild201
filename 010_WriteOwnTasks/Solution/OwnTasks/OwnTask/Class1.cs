using Microsoft.Build.Utilities;

namespace MeetUpTasks
{
    public class OwnTask : Task
    {
        public override bool Execute()
        {
            System.Console.WriteLine(MyProperty);
            return true;
        }

        private string myProperty;
        public string MyProperty
        {
            get { return myProperty; }
            set { myProperty = value; }
        }

    }
}
