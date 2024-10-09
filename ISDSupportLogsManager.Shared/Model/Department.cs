namespace ISDSupportLogsManager.Shared.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public int BizId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
