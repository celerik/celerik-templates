using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Celerik.NetCore.Services;
using Celerik.NetCore.Util;
using Microsoft.EntityFrameworkCore;
using {{namespace}}.EntityFramework;

namespace {{namespace}}.Services
{
    public class {{main-entity}}ServiceMock<TLoggerCategory>
        : {{main-entity}}ServiceBase<TLoggerCategory, DbContext>
    {
        private readonly List<EntityFramework.{{main-entity}}> _entities = null;

        public {{main-entity}}ServiceMock(ApiServiceArgs<TLoggerCategory> args)
            : base(args) =>
            _entities = EmbeddedFileUtility.ReadJson<List<EntityFramework.{{main-entity}}>>(
                "Assets.Mock.{{main-entity}}.json"
            );

        protected override async Task<EntityFramework.{{main-entity}}> Get{{main-entity}}Async(string {{camel-main-entity}}Id)
        {
            var entity = _entities.FirstOrDefault(
                c => c.{{main-entity}}Id == {{camel-main-entity}}Id);

            return await Task.FromResult(entity);
        }

        protected override async Task SaveAsync(
            ApiChangeAction operation,
            object entity,
            bool commit = true)
        {
            if (entity is EntityFramework.{{main-entity}} && operation == ApiChangeAction.Insert)
                _entities.Add(entity as EntityFramework.{{main-entity}});
            else if (entity is EntityFramework.{{main-entity}} && operation == ApiChangeAction.Delete)
                _entities.Remove(entity as EntityFramework.{{main-entity}});

            await Task.FromResult(0);
        }
    }
}
