namespace IBEN.ASMS.Web.Dtos
{
    public class APIDataResult<T>
    {
        public string Code { get; set; } = default!;
        public string? Message { get; set; }

        public T? Data { get; set; }
    }
}
