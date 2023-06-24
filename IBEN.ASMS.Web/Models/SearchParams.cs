namespace IBEN.ASMS.Web.Models
{
    public class SearchParams
    {
        /// <summary>
        /// 查询关键词
        /// </summary>
        public string? key { get; set; }
        /// <summary>
        /// 当前页
        /// </summary>
        public int pi { get; set; }
        /// <summary>
        /// 页容量
        /// </summary>
        public int ps { get; set; }
    }
}
