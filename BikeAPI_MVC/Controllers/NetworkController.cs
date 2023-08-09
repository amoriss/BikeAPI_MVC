using BikeAPI_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeAPI_MVC.Controllers;
public class NetworkController : Controller
{
    public IActionResult Index()
    {
        var networksResponse = CityBikeAPI.CallAPI();
        return View(networksResponse);
    }
}
