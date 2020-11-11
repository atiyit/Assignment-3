using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

[ApiController]
[Route("[controller]")]
public class adultController : ControllerBase
{
    private IAdultService AdultService;

    public adultController(IAdultService adultService)
    {
        AdultService = adultService;
    }

    
    [HttpPut]
    public IActionResult AddAdult([FromBody] Adult adult)
    {
        try
        {
            AdultService.AddAdultAsync(adult);
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpGet]
    public async Task<ActionResult<IList<Adult>>> GetAdults()
    {
        try
        {
            IList<Adult> adults= await AdultService.GetAdultAsync();
            return Ok(adults);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500,e.Message);
        }
    }
    
}
