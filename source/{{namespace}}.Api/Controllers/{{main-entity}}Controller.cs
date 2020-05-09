using System.Threading.Tasks;
using Celerik.NetCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using {{namespace}}.Model;
using {{namespace}}.Services;

namespace {{namespace}}.Api
{
    /// <summary>
    /// Provides functions to {{purpose}}.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class {{main-entity}}Controller : ControllerBase
    {
        /// <summary>
        /// Reference to the current I{{main-entity}}Service instance.
        /// </summary>
        private readonly I{{main-entity}}Service _{{camel-main-entity}}Svc;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="{{camel-main-entity}}Svc">Reference to the current
        /// I{{main-entity}}Service instance.</param>
        public {{main-entity}}Controller(I{{main-entity}}Service {{camel-main-entity}}Svc)
            => _{{camel-main-entity}}Svc = {{camel-main-entity}}Svc;

        /// <summary>
        /// Gets a {{main-entity}}.
        /// </summary>
        /// <param name="payload">Payload to filter the {{main-entity}} by
        /// {{main-entity}}Id.</param>
        /// <returns>{{main-entity}} matching the passed-in filter.</returns>
        /// <response code="200">Returns the {{main-entity}}.</response>
        [HttpGet]
        [Route("Get{{main-entity}}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse<{{main-entity}}Dto, Get{{main-entity}}Status>>> Get{{main-entity}}([FromQuery]Get{{main-entity}}Payload payload)
            => Ok(await _{{camel-main-entity}}Svc.Get{{main-entity}}Async(payload));
    }
}
