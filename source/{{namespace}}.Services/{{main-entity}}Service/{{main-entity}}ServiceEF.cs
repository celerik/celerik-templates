using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Celerik.NetCore.Services;
using Microsoft.EntityFrameworkCore;
using {{namespace}}.EntityFramework;

namespace {{namespace}}.Services
{
    [ExcludeFromCodeCoverage]
    public class {{main-entity}}ServiceEF<TLoggerCategory>
        : {{main-entity}}ServiceBase<TLoggerCategory, {{short-namespace}}DbContext>
    {
        public {{main-entity}}ServiceEF(ApiServiceArgsEF<TLoggerCategory, {{short-namespace}}DbContext> args)
            : base(args) { }

        protected override async Task<EntityFramework.{{main-entity}}> Get{{main-entity}}Async(string {{camel-main-entity}}Id)
        {
            var entity = await DbContext.{{main-entity}}
                .FirstOrDefaultAsync(c => c.{{main-entity}}Id == {{camel-main-entity}}Id);

            return entity;
        }
    }
}
