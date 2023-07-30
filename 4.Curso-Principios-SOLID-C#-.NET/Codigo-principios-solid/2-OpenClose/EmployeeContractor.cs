namespace OpenClose
{
    public class EmployeeContractor : Employee
    {
        // public string Fullname { get; set; }
        // public int HoursWorked { get; set; }

        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}