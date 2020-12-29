using System;
using MaterialApi.Entities;

namespace MaterialApi.Model
{
    public class WorkerDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string PassportNo { get; set; }
        public string MobileNo { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public int IsActive { get; set; }
    }
}
