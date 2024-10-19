using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDSupportLogsManager.Shared.Model.Reports
{
    public class CategoryPerMonthReport
    {
        public string Month { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int Count { get; set; }
    }
}
