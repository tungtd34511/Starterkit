using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Starterkit.UI._keenthemes.libs;

namespace Starterkit.UI.Controllers;

public class DashboardsController : Controller
{
    private readonly ILogger<DashboardsController> _logger;
    private readonly IKTTheme _theme;

    public DashboardsController(ILogger<DashboardsController> logger, IKTTheme theme)
    {
        _logger = logger;
        _theme = theme;
    }

    [HttpGet("/")]
    [HttpGet("/dashboards")]
    [Authorize]
    public IActionResult Index()
    {
        return View(_theme.GetPageView("Dashboards", "Index.cshtml"));
    }
}
