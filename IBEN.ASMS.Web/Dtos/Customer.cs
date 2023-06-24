using System.Security.Principal;

namespace IBEN.ASMS.Web.Dtos
{
    public class Customer
    {
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        public int Id { get; set; }

        /// <summary>
        /// Desc:客户唯一编号
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string? CustomerId { get; set; }

        /// <summary>
        /// Desc:客户姓名
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string? CustomerName { get; set; }

        /// <summary>
        /// Desc:手机号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string? Mobile { get; set; }

        /// <summary>
        /// Desc:项目地址
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string? ProjectAddr { get; set; }

        /// <summary>
        /// Desc:合同面积
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string? ContractArea { get; set; }

        /// <summary>
        /// Desc:合同金额
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string? ContractAmt { get; set; }

        /// <summary>
        /// Desc:自述面积
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string? SelfStatementArea { get; set; }

        /// <summary>
        /// Desc:施工内容
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string? ConstructItems { get; set; }

        /// <summary>
        /// Desc:
        /// Default:CURRENT_TIMESTAMP
        /// Nullable:False
        /// </summary>           
        public DateTime CreateAt { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? UpdateAt { get; set; }
    }
}
