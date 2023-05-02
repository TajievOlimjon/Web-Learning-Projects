using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApiR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            return Ok(user);
        }
    }
}
public class User
{
    public int Id { get; set; }
    [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Некорректное эл.почта")]
    [Display(Name = "Job applicant email")]
    public string Email { get; set; }
}
