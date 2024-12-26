using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_tutoriall.model.proc;
using MVC_tutoriall.model.request;
using MVC_tutoriall.model.response;

namespace MVC_tutoriall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastoController : ControllerBase
    {
        [HttpPost]

        [Route("grabar")]
        public Respuesta ro_1_3([FromBody] r_fechas fechas)
        {

            Respuesta res = p_Gasto.buscarFechas(fechas);
            return res;
        }
    }
}
