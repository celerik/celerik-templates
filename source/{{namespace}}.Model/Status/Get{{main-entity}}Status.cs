namespace {{namespace}}.Model
{
    /// <summary>
    /// Defines all posible status codes for the Get-{{main-entity}} process.
    /// </summary>
    public enum Get{{main-entity}}Status
    {
        /// <summary>
        /// Something in the request payload is invalid.
        /// </summary>
        BadRequest = 400,

        /// <summary>
        /// The {{main-entity}}Id has an invalid format.
        /// </summary>
        {{main-entity}}IdFormat = 461,

        /// <summary>
        /// The {{main-entity}}Id was not found.
        /// </summary>
        {{main-entity}}IdNotFound = 462,

        /// <summary>
        /// The process ran successfully.
        /// </summary>
        Ok = 200
    }
}
