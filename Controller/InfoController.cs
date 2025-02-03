using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HNG12.Controller;

[ApiController]
[Route("/")]

public class InfoController : ControllerBase
{
    [HttpGet("/")]
    public IActionResult MyInfo()
    { 
        var response = new
        {
            Gmail = "paschalbaylon99@gmail.com",
            Current_DateTime = DateTime.UtcNow.ToString("O"),
            Github_Url = "https://github.com/Paschalbaylon/Paschal_HNG12.git"
        };
        return Ok(response);
    }
}
