using System.Threading.Tasks;
using Celerik.NetCore.Services;
using {{namespace}}.Model;

namespace {{namespace}}.Services
{
    public interface I{{main-entity}}Service
    {
        Task<ApiResponse<{{main-entity}}Dto, Get{{main-entity}}Status>> Get{{main-entity}}Async(Get{{main-entity}}Payload payload);
    }
}
