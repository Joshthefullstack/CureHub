using HMSData.Roles.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSApplication.Nurse
{
    public class DoctorGridView
    {
        public string DoctorId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public DoctorSession Session { get; set; }
    }
}
