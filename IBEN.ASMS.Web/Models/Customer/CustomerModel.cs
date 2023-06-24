using System.ComponentModel.DataAnnotations;

namespace IBEN.ASMS.Web.Models
{
    /// <summary>
    /// 视图模型Customer
    /// </summary>
    public class CustomerModel
    {
        /// <summary>
        /// 客户唯一编号
        /// </summary>           
        public string? CustomerId { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string? CustomerName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>           
        [StringLength(11)]
        [Required]
        public string? Mobile { get; set; }

        /// <summary>
        /// 项目地址
        /// </summary>           
        [Required]
        public string? ProjectAddr { get; set; }

        /// <summary>
        /// 合同面积
        /// </summary>           
        public string? ContractArea { get; set; }

        /// <summary>
        /// 合同金额
        /// </summary>           
        [Required]
        public string? ContractAmt { get; set; }

        /// <summary>
        /// 自述面积
        /// </summary>           
        [Required]
        public string? SelfStatementArea { get; set; }

        /// <summary>
        /// 施工内容
        /// </summary>           
        [Required]
        public List<string>? ConstructItems { get; set; }

        /// <summary>
        /// 施工内容
        /// </summary>
        public string? ConstructItemsDisplayText { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>           
        public DateTime CreateAt { get; set; }
    }
}
