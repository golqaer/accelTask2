using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task2.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace Task2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookManageController : BaseController
    {
        public BookManageController(Context context) : base(context) { }

        [HttpPost]
        [Route("Add")]
        public ActionResult<DbBookModel>? Add([FromForm] Models.Api.ApiBookModel model)
        {
            try
            {
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
