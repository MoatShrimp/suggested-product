
using Microsoft.AspNetCore.Mvc;

namespace Product.Api.Controllers;

[ApiController, Route("api/v1/[controller]")]
public class HelloController : ControllerBase
{
  [HttpGet]
  public string SayHello() => "Hello Frontend";
}
