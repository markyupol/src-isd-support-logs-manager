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

        public string SectionValue => Section.Name;
        public string ShiftValue => Shift.Name;
        public string BizValue => Biz.Name;
        public string DepartmentValue => Department.Name;
        public string ScopeValue => Scope.Name;
        public string CategoryValue => Category.Name;
        public string UserValue => $"{User.FirstName} {User.LastName}";

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

        public string Details { get; set; } = string.Empty;
        public string Cause { get; set; } = string.Empty;
        public string ActionTaken { get; set; } = string.Empty;
    }
}
