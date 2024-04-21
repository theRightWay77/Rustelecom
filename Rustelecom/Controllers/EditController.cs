using Microsoft.AspNetCore.Mvc;
using Rustelecom.Models;

namespace Rustelecom.Controllers
{
    public class EditController : Controller
    {
        IContractRepository ContractRepository { get; set; }

        public EditController(IContractRepository contractRepository)
        {
            ContractRepository = contractRepository;
        }

        public IActionResult Index(int id)
        {
            Contract contract = ContractRepository.TryGetById(id);
            return View(contract);
        }
        [HttpPost]
        public IActionResult SaveChanges(int id, string name, string iPAddress, int serviceType, DateTime date)
        {
            Contract contract = ContractRepository.TryGetById(id);
            if(name != null) { contract.Name = name; }
            if(iPAddress != null) { contract.IPAddress = iPAddress; }

            if (serviceType == 0) contract.ServiceType = ServiceType.Internet;
            else if (serviceType == 1) contract.ServiceType = ServiceType.VideoControl;
            else if (serviceType == 2) contract.ServiceType = ServiceType.IPTelephony;

            contract.Date = date;

            return RedirectToAction("Index", "Contract");
        }

       
    }
}
