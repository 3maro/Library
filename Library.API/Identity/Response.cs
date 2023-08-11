namespace Library.API.Identity
{
    /// <summary>
    /// Represents a response object containing status and message information.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Gets or sets the status of the response.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the message associated with the response.
        /// </summary>
        public string? Message { get; set; }
    }

}
