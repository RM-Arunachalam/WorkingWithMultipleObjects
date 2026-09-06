using ClassLibrary;

namespace Assignment
{
    class Sample
    {
        public static void Main(string[] args)
        {
            int i = 0;
            string userchoice = "no";
            do
            {
                System.Console.WriteLine("Employee " + ++i + " details");
                Employee emp = new Employee();
                System.Console.Write("\nEnter EmpId:");
                emp.empId=int.Parse(System.Console.ReadLine());
                System.Console.Write("\nEnter Emp Name:");
                emp.empName = System.Console.ReadLine();
                System.Console.Write("\nEnter Emp No of  working hours:");
                emp.noOfWorkingHours = int.Parse(System.Console.ReadLine());
                System.Console.Write("\nEnter Emp salary per hour:");
                emp.salaryPerHour = System.Convert.ToDouble(System.Console.ReadLine());
                Employee.OrganizationName = "Harsha Inc.";//static field
                System.Console.WriteLine("\nEmp Organization Name:" + Employee.OrganizationName);
                System.Console.WriteLine("\nEmp Type:" + Employee.TypeOfEmployee);
                System.Console.WriteLine("\nEmp Department:" + emp.DepartmentName);
                System.Console.Write("\nCalculate Employee Net salary:"+emp.CalculateNetSalary());
                System.Console.Write("\nDo you want to continue to next employee-Yes/No?");
                userchoice =System.Console.ReadLine().ToLower();
            } while (userchoice!="no" &userchoice!="n" );
        }
    }
}