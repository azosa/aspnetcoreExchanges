using Microsoft.AspNetCore.Mvc;
using WebApplication1.Filters;
using WebApplication1.Models;
namespace WebApplication1.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class AjaxController : ControllerBase
    {
        public ​AddNewItemResponse​ Post(ItemModel item) { }
    }
}