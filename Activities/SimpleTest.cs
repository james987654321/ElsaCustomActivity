using Elsa;
using Elsa.ActivityResults;
using Elsa.Attributes;
using Elsa.Expressions;
using Elsa.Services;
using Elsa.Services.Models;



using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

//https://github.com/elsa-workflows/elsa-core/tree/master/src/samples/aspnet/Elsa.Samples.CustomActivities

namespace ElsaCustomActivity.Activities
{
    [Activity(Category = "Custom Activities", Description = "Simple Test", Outcomes = new[]{ OutcomeNames.Done, "Not Found" })]
    public class SimpleTest : Activity
    {
        [ActivityProperty(Hint = "custom property input")]
        public string testPropertyInput  { get; set; }
        
       

        //protected override async ValueTask<IActivityExecutionResult> OnExecuteAsync(ActivityExecutionContext context)
        protected override IActivityExecutionResult OnExecute()
        {                      
            
            
            switch (testPropertyInput)
            {
                case "Input1": 
                    //do something
                    
                default:
                    break;
            }        
            
            return Outcome("Not Found");
        }

   
    }
}
