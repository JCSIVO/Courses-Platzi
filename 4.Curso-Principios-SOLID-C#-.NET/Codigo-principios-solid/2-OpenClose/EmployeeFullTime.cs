namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {
        // public string Fullname { get; set; }
        // public int HoursWorked { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }
        
        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            // EmployeeFullTime employeeFullTime = ((EmployeeFullTime)employee);
            decimal salary = hourValue * HoursWorked;
            // Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
            return salary;
        }
    }

    public class EmployeeFullTime : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}