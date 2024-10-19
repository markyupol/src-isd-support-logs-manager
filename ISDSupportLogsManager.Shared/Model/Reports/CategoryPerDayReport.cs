using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDSupportLogsManager.Shared.Model.Reports
{
    public class CategoryPerDayReport
    {
        public DateTime Day { get; set; }
        public string Category { get; set; } = string.Empty;
        public int Count { get; set; }
    }
}
