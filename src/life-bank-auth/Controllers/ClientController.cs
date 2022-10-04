using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LifeBankAuth.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    /// <summary>
    /// Message function that does needs authorization
    /// </summary>
    /// <returns>Returns a message</returns>
    public ActionResult<string> PlataformWelcome()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Message function that needs authorization claims based
    /// </summary>
    /// <returns>Returns a message</returns>
    public ActionResult<string> NewPromoAlert()
    {
        throw new NotImplementedException();
    }
}
