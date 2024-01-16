using desafios_leetcode.Services;
using Microsoft.AspNetCore.Mvc;

namespace desafios_leetcode.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{
    private readonly AppService _appService;

    public Controller(
        AppService appService
    )
    {
        _appService = appService;
    }

    [HttpGet("Exercise 35 - Search Insert Position")]
    public int Exercise_35([FromQuery] int[] nums, [FromQuery] int target)
    {
        return _appService.SearchInsert(nums, target);
    }

    [HttpGet("Exercise 58 - Length of Last Word")]
    public int Exercise_58(string text)
    {
        return _appService.LengthOfLastWord(text);
    }
}
