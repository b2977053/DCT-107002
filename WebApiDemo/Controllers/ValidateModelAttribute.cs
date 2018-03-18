using System;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Net.Http;

namespace WebApiDemo.Controllers
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.ModelState.IsValid == false)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, new
                {
                    MsgNo = "-1",
                    MsgText = "Model Binding Fail"
                });
            }
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //
        }
    }
}