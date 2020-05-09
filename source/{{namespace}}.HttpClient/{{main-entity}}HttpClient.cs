using System.Net.Http;
using System.Threading.Tasks;
using Celerik.NetCore.HttpClient;
using {{namespace}}.Model;

namespace {{namespace}}.HttpClient
{
    /// <summary>
    /// HttpClient to {{purpose}}.
    /// </summary>
    /// <example>
    ///     <code>
    ///     // The preferred method of using this client is by registering it
    ///     // from your dependency injection setup:
    ///     services.AddHttpClient&lt;{{main-entity}}HttpClient&gt;(client =>
    ///     {
    ///         client.BaseAddress = new Uri("https://{{lower-short-namespace}}-microservices.azurewebsites.net");
    ///     });
    ///     
    ///     // Then your container registry can inject it via constructor
    ///     // method:
    ///     public SomeClass({{main-entity}}HttpClient {{camel-main-entity}}HttpClient)
    ///     {
    ///         _{{camel-main-entity}}HttpClient = {{camel-main-entity}}HttpClient;
    ///     }
    ///     
    ///     // Or you can also retrieve the client using a ServiceProvider:
    ///     var {{camel-main-entity}}HttpClient = serviceProvider
    ///         .GetRequiredService&lt;{{main-entity}}HttpClient&gt;();
    ///         
    ///     // Alternatively, if you don't want to configure this client using
    ///     // dependency injection, you can directly create an instance of
    ///     // this class (not recommended):
    ///     var {{camel-main-entity}}HttpClient = new {{main-entity}}HttpClient(new HttpClient
    ///     {
    ///         BaseAddress = new Uri("https://{{lower-short-namespace}}-microservices.azurewebsites.net");
    ///     });
    ///     </code>
    /// </example>
    public class {{main-entity}}HttpClient
    {
        /// <summary>
        /// The name of the controller this client points to.
        /// </summary>
        private const string ControllerName = "{{main-entity}}";

        /// <summary>
        /// Reference to the current CelerikHttpClient.
        /// </summary>
        private readonly CelerikHttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="httpClient">Reference to the current HttpClient.
        /// </param>
        public {{main-entity}}HttpClient(System.Net.Http.HttpClient httpClient)
            => _httpClient = new CelerikHttpClient(httpClient);

        /// <summary>
        /// Gets a {{main-entity}}.
        /// </summary>
        /// <param name="payload">Payload to filter the {{main-entity}} by
        /// {{main-entity}}Id.</param>
        /// <returns>The task object representing the asynchronous operation.
        /// </returns>
        /// <example>
        ///     <code>
        ///         var response = await _{{camel-main-entity}}HttpClient.Get{{main-entity}}Async(new Get{{main-entity}}Payload
        ///         {
        ///             {{main-entity}}Id = "9EAEC714-B576-4043-A9E0-10E85DDD7631"
        ///         });
        ///         
        ///         if (response.Success)
        ///         {
        ///             var data = response.Data;
        ///             ...
        ///         }
        ///         else
        ///             DisplayMessage(response.Message, response.MessageType);
        ///     </code>
        /// </example>
        /// <exception cref="HttpRequestException">If there was an error
        /// calling the service.</exception>
        public async Task<ApiResponse<{{main-entity}}Dto, Get{{main-entity}}Status>> Get{{main-entity}}Async(Get{{main-entity}}Payload payload)
            => await _httpClient.SendAsync<{{main-entity}}Dto, Get{{main-entity}}Status>(
                HttpMethod.Get,
                ControllerName,
                "Get{{main-entity}}",
                payload);
    }
}
