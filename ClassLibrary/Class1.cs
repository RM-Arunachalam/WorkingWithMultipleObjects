namespace ClassLibrary
{
    public class Employee
    {
        //EmpID, EmpName, SalaryPerHour, NoOfWorkingHours and NetSalary. 
        public int empId;
        public string empName;
        public double salaryPerHour;
        public int noOfWorkingHours;
        public double netSalary;
        public static string OrganizationName;
        public const string TypeOfEmployee = "Contract Based";
        public readonly string DepartmentName;

        public Employee()
        {
            DepartmentName = "Finance Department";
        }

        public double CalculateNetSalary()
        {
            return salaryPerHour*noOfWorkingHours;
        }
    }
}
