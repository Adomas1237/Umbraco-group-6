using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web.WebApi;
//not working
namespace umbracoproject.Controllers
{
    public class ScheduleApiController : UmbracoApiController
    {
        public void AssignGroup(IMember member)
        {
            var MemberService = ApplicationContext.Services.MemberService;

            MemberService.AssignRole(member.Id, "Active");

            MemberService.Save(member);
        }
      
    }
 
}