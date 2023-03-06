using CarMarketBackend.Domain.Models.JWT;
using Microsoft.AspNetCore.Mvc;

namespace CarMarketBackend.Controllers;

[Controller]
public abstract class BaseController : ControllerBase
{
    // returns the current authenticated account (null if not logged in)
    public Account Account => (Account)HttpContext.Items["Account"];
}