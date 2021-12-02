using Microsoft.AspNetCore.Mvc;
using ProjectStipofy.Usuario;
using ProjectStipofy.Validacao;
using Swashbuckle.AspNetCore.Annotations;

namespace ProjectStipofy.Controllers
{
    [Route("stipofy/v1/usuario")]
    [ApiController]
    public class UsuarioController : Controller
    {
        [SwaggerResponse(statusCode: 200, description: "Secesso ao autenticar", Type = typeof(LoginInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidaModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenerico))]

        [HttpPost, Route("Login")]
        [ValidacaoModelCustom]
        public IActionResult Logar (LoginInput loginInput)
        {
            return Ok(loginInput);
        }

        [HttpPost,Route("Registrar")]
        [ValidacaoModelCustom]
        public IActionResult Registrar (RegistrarInput loginInput)
        {
            return Created(" ", loginInput);
        }
    }
}
