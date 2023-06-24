namespace IBEN.ASMS.Web.Dtos
{
    public class PagingDataDto<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public T? Data { get; set; }
    }
}
