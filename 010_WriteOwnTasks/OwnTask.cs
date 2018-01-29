using System;  
using Microsoft.Build.Framework;  
using Microsoft.Build.Utilities;  
  
namespace MeetUpTasks  
{  
    public class OwnTask : Task  
    {  
        public override bool Execute()  
        {  
            return true;  
        }  
    }  
}  
