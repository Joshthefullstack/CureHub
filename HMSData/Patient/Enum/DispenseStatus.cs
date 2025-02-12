using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.Patient.Enum
{
    public enum DispenseStatus
    {
        Pending = 0,
        InProgress,
        Dispensed,
        PartiallyDispensed,
        Cancelled
    }
}
