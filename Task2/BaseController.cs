using Microsoft.AspNetCore.Mvc;
using Task2.Models.Db;

namespace Task2
{
    public class BaseController : ControllerBase
    {
        protected Context context;

        public BaseController(Context context) : base ()
        {
            this.context = context;
        }
    }
}
