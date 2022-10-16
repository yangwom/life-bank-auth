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
    [HttpGet]
    [Route("Client/PlataformWelcome")]
    [Authorize]
    public ActionResult<string> PlataformWelcome()
    {
        return "Que ótimo ter você aqui novamente, sinta-se a vontade!";
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
