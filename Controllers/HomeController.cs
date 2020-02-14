using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewReport(Guid id)
        {
            return View();
        }
        public ActionResult GetReport()
        {
            System.Web.Routing.RouteValueDictionary routeValues = StiMvcViewer.GetRouteValues();
            if (routeValues["id"] != null)
            {
                var reportId = Guid.Parse(routeValues["id"].ToString());
            }
            else
            {
                throw new Exception("no id");
            }
            return StiMvcViewer.GetReportResult(new StiReport());
        }
        public ActionResult ViewerEvent()
        {
            //根据权限控制查看功能
            return StiMvcViewer.ViewerEventResult();
        }
    }
}