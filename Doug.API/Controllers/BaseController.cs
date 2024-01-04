using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Doug.API.Controllers
{
    [ApiController]
    [Authorize]
    public abstract class BaseController : ControllerBase
    {
        protected IActionResult ResultOk(object objResult)
            => Ok(new Resultados(objResult));
    }
}

public class Resultados
{
    public Resultados(bool success, object? result = null, string? menssagem = null)
    {
        Success = success;
        Mensagem = menssagem;
        Result = result;
    }
    public Resultados( object result)
    {
        Success = true;
        Result = result;
    }
    public Resultados(string menssagem)
    {
        Success = true;
        Mensagem = menssagem;
    }

    public bool Success { get; private set; }
    public string? Mensagem { get; private set; }
    public object? Result { get; private set; }


}
