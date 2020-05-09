namespace {{namespace}}.Model
{
    /// <summary>
    /// Defines the arguments needed to get a {{main-entity}}.
    /// </summary>
    public class Get{{main-entity}}Payload
    {
        /// <summary>
        /// The unique identifier of the {{main-entity}}.
        /// </summary>
        public string {{main-entity}}Id { get; set; }
    }
}
