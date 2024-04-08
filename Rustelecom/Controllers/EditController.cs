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
        public IActionResult SaveChanges(int id, string name, string iPAddress, ServiceType serviceType, DateTime date)
        {
            Contract contract = ContractRepository.TryGetById(id);
            if(name != null) { contract.Name = name; }
            if(iPAddress != null) { contract.IPAddress = iPAddress; }
            contract.ServiceType = serviceType;
            contract.Date = date;

            return RedirectToAction("Index", "Contract");
        }
    }
}
