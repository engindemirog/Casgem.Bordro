using Business.Abstract;
using Business.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForeignLanguagesController : ControllerBase
    {
        IForeignLanguageService _foreignLanguageService;

        public ForeignLanguagesController(IForeignLanguageService foreignLanguageService)
        {
            _foreignLanguageService = foreignLanguageService;
        }

        [HttpPost]
        public ActionResult Add(CreateForeignLanguageRequest createForeignLanguageRequest)
        {
            _foreignLanguageService.Add(createForeignLanguageRequest);
            return Ok();
        }
    }
}
