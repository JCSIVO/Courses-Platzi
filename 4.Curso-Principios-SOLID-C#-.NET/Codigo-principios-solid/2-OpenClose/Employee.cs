
namespace OpenClose
{

    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public abstract deciaml CalculateSalaryMonthly();

    }

    public interface IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public decimal CalculateSalaryMonthly();
    }
}