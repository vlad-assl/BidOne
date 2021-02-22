using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using BidOne.TechincalTask.Models;
using BidOne.TechincalTask.Web.Models;
using BidOne.TechnicalTask.Lib.Models;
using BidOne.TechnicalTask.Lib.Services.Interfaces;

namespace BidOne.TechincalTask.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWriteJsonToFileService _writeJsonToFileService;

        public HomeController(IWriteJsonToFileService writeJsonToFileService)
        {
            _writeJsonToFileService = writeJsonToFileService;
        }
        public HomeController()
        {

        }
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

        public ActionResult AjaxMethod(Person person)
        {
            JsonResponse response = new JsonResponse();
            if (ModelState.IsValid)
            {
                Person p = new Person
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName
                };

                string fileName = p.FirstName + "_" + p.LastName + ".json";

                string filePath = Server.MapPath("~/App_Data/" + AppSettings.FilePath + "/");

                bool successfullySaved = _writeJsonToFileService.WriteJsonToFile(p.FirstName, p.LastName, filePath, fileName);

               
                if (successfullySaved)
                {
                    Response.StatusCode = (int)HttpStatusCode.OK; ;
                    response.Type = "Operation";
                    response.Message = "File saved successfully";

                }
                else
                {
                    Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    response.Type = "Validation";
                    response.Message = "Error saving the json file";
                    response.Errors = new List<JsonValidationError>();
                }
                return Json(response, JsonRequestBehavior.AllowGet);

            }
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            response.Type = "Validation";
            response.Message = "File saved successfully";
            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}