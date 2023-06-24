using IBEN.ASMS.Web.Dtos;
using IBEN.ASMS.Web.Models;
using IBEN.ASMS.Web.Utils;
using Microsoft.AspNetCore.Mvc;

namespace IBEN.ASMS.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IConfiguration _configuration;
        public CustomerController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult List(SearchParams param)
        {
            CustomerListModel model = new CustomerListModel();
            if (param.pi <= 0) param.pi = 1;
            if (param.ps <= 0) param.ps = 15;
            model.Param = param; // 将查询参数回传至视图模型，以便完成查询参数的状态保持

            // 查询数据
            string apiUrl = _configuration["ApiHost"] + $"/customer/query?key={param.key}&pi={param.pi}&ps={param.ps}";
            PagingDataDto<List<Customer>>? data = APIInvoker.Get<PagingDataDto<List<Customer>>>(apiUrl);

            // 将数据填充到视图模型
            if (data != null && data.Data != null)
            {
                model.Customers = new List<CustomerModel>();
                foreach (var item in data.Data)
                {
                    model.Customers.Add(new CustomerModel
                    {
                        CustomerId = item.CustomerId,
                        CustomerName = item.CustomerName,
                        ProjectAddr = item.ProjectAddr,
                        ContractArea = item.ContractArea,
                        ContractAmt = item.ContractAmt,
                        SelfStatementArea = item.SelfStatementArea,
                        Mobile = item.Mobile,
                        CreateAt = item.CreateAt,
                        ConstructItemsDisplayText = item.ConstructItems
                    });
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            CustomerModel model = new CustomerModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddHandler(CustomerModel customer)
        {
            if(customer != null)
            {
                string apiUrl = _configuration["ApiHost"] + "/Customer/Add";

                Dtos.Customer cus = new Customer();
                cus.CustomerName = customer.CustomerName;
                cus.ProjectAddr = customer.ProjectAddr;
                cus.ContractArea = customer.ContractArea;
                cus.ContractAmt = customer.ContractAmt;
                cus.SelfStatementArea = customer.SelfStatementArea;
                cus.ConstructItems = string.Join(",", customer.ConstructItems!);
                cus.CreateAt = DateTime.Now;
                

                int result = APIInvoker.Post<int>(apiUrl, cus);
            }

            return RedirectToAction("List", "Customer");
        }
    }
}
