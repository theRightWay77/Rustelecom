using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.CompilerServices;

namespace Rustelecom.Models
{
    public enum ServiceType
    {
        Internet,
        VideoControl,
        IPTelephony
    }
    public enum Status
    {
        InProcess,
        Refused
    }
  
    public class Contract
    {       
        static int forId = 1;
        public readonly int Id;

        [Required(ErrorMessage = "Введите имя заказчика")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "Имя должно включать 5-35 символов")]
        public string Name { get; set; }

        [Required]
        public string IPAddress { get; set; }

        [Required]
        public ServiceType ServiceType { get; set; }

        [Required(ErrorMessage ="Введите дату в будущем")]
        public DateTime Date { get; set; }
        public Status Status { get; set; } = Status.InProcess;

        public Contract()
        {
            Id = forId++;
        }

        public Contract(string name, string iPAddress, ServiceType serviceType, DateTime date) 
        {
            Id = forId++;
            Name = name;
            IPAddress = iPAddress;
            ServiceType = serviceType;
           Date = date;
        }
    }
}
