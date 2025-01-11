using Microsoft.AspNetCore.Mvc;

namespace dotnet_sandbox.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public string GetProducts()
    {
        return "OK";
    }
}
