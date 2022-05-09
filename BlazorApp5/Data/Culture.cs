using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
namespace BlazorApp5.Data
{
    [Route("/[controller]")]
    [ApiController]
    public class Culture : ControllerBase
    {
        public ActionResult SetCulture()
        {
            IRequestCultureFeature culture = HttpContext.Features.Get<IRequestCultureFeature>();
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(new string[] { "en-US", "fr-FR" }
                    .Where(option => option != culture.RequestCulture.Culture.Name)
                    .FirstOrDefault())));

            return Redirect("/");
        }
    }
}