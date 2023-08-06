namespace Library.API.Identity
{
    public class UserMangerResponse
    {
        public string Message { get; set; } = string.Empty;
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Erorrs { get; set; }
    }
}
