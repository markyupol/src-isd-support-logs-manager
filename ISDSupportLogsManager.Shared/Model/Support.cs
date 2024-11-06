using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDSupportLogsManager.Shared.Model
{
    public class Support
    {
        public Section Section { get; set; } = new Section();
        public Shift Shift { get; set; } = new Shift();
        public Biz Biz { get; set; } = new Biz();
        public Department Department { get; set; } = new Department();
        public Scope Scope { get; set; } = new Scope();
        public Category Category { get; set; } = new Category();
        public User User { get; set; } = new User();

        public DateOnly StartDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public DateOnly EndDate { get; set; }
        public TimeOnly EndTime { get; set; }

        public int ElapsedMinutes
        {
            get
            {
                DateTime startDateTime = StartDate.ToDateTime(StartTime);
                DateTime endDateTime = EndDate.ToDateTime(EndTime);

                TimeSpan elapsed = endDateTime - startDateTime;

                return (int)elapsed.TotalMinutes;
            }
        }

        public DateTime StartDateTime => StartDate.ToDateTime(StartTime);
        public DateTime EndDateTime => StartDate.ToDateTime(EndTime);

        public string StartMonth => StartDate.Month.ToString();

        public string Details { get; set; } = string.Empty;
        public string Cause { get; set; } = string.Empty;
        public string ActionTaken { get; set; } = string.Empty;
    }

    public class SupportLookup
    {
        public string ControlNo { get; set; } = string.Empty;
        public string SectionName { get; set; } = string.Empty;
        public string ShiftName { get; set; } = string.Empty;
        public string BizName { get; set; } = string.Empty;
        public string DepartmentName { get; set; } = string.Empty;
        public string ScopeName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string UserFirstName { get; set; } = string.Empty;
        public string UserLastName { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Cause { get; set; } = string.Empty;
        public string ActionTaken { get; set; } = string.Empty;

        public DateOnly StartDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public DateOnly EndDate { get; set; }
        public TimeOnly EndTime { get; set; }

        public int ElapsedMinutes
        {
            get
            {
                DateTime startDateTime = StartDate.ToDateTime(StartTime);
                DateTime endDateTime = EndDate.ToDateTime(EndTime);

                TimeSpan elapsed = endDateTime - startDateTime;

                return (int)elapsed.TotalMinutes;
            }
        }

        public DateTime StartDateTime => StartDate.ToDateTime(StartTime);
        public DateTime EndDateTime => StartDate.ToDateTime(EndTime);

        public string StartMonth => StartDate.Month.ToString();

        public string UserFullName => $"{UserFirstName} {UserLastName}";
    }
}
