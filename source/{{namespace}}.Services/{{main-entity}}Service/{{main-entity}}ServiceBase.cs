using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Celerik.NetCore.Services;
using Microsoft.EntityFrameworkCore;
using {{namespace}}.Model;

namespace {{namespace}}.Services
{
    [SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "The payload is validated in a call to Validate(payload)")]
    public abstract class {{main-entity}}ServiceBase<TLoggerCategory, TDbContext>
        : ApiServiceEF<TLoggerCategory, {{short-namespace}}Resources, TDbContext>, I{{main-entity}}Service
            where TDbContext : DbContext
    {
        public {{main-entity}}ServiceBase(ApiServiceArgs<TLoggerCategory> args)
            : base(args) { }

        [ExcludeFromCodeCoverage]
        public {{main-entity}}ServiceBase(ApiServiceArgsEF<TLoggerCategory, TDbContext> args)
            : base(args) { }

        public async Task<ApiResponse<{{main-entity}}Dto, Get{{main-entity}}Status>> Get{{main-entity}}Async(Get{{main-entity}}Payload payload)
        {
            StartLog();
            ApiResponse<{{main-entity}}Dto, Get{{main-entity}}Status> response;

            if (!Validate(payload, out string message, out string property))
                response = Error<Get{{main-entity}}Status>(message, property);
            else
            {
                var entity = await Get{{main-entity}}Async(payload.{{main-entity}}Id);

                if (entity == null)
                    response = Error(Get{{main-entity}}Status.{{main-entity}}IdNotFound);
                else
                    response = Ok<{{main-entity}}Dto, Get{{main-entity}}Status>(entity, Get{{main-entity}}Status.Ok);
            }

            EndLog();
            return response;
        }

        protected abstract Task<EntityFramework.{{main-entity}}> Get{{main-entity}}Async(string {{camel-main-entity}}Id);
    }
}
