using System.Net;

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
        public string Name;
        public string IPAddress;
        public ServiceType ServiceType;
        public DateTime Date;
        public Status Status = Status.InProcess;

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
