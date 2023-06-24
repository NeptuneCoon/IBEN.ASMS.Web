namespace IBEN.ASMS.Web.Models
{
    public class CustomerListModel
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public SearchParams Param { get; set; }

        /// <summary>
        /// 查询到的数据集
        /// </summary>
        public List<CustomerModel> Customers { get; set; }
    }
}
