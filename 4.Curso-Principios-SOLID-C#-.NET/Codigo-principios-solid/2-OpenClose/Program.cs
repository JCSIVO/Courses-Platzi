using OpenClose;

CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Irene Sanchez", 200)
});


void ShowSalaryMonthly(List<Employee> employees) 
{
    foreach (var employee in employees)
    {
        //if (employee is EmployeeFullTime) 
        //{
        //    decimal hourValue = 30000M;
        //    EmployeeFullTime employeeFullTime = ((EmployeeFullTime)employee);
        //    decimal salary = hourValue * employeeFullTime.HoursWorked;
        //    Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
        //}
        //else 
        //{
        //    decimal hourValue = 20000M;
        //    EmployeePartTime employeePartTime = ((EmployeePartTime)employee);
        //    decimal salary = hourValue * employeePartTime.HoursWorked;
        //    if (employeePartTime.HoursWorked > 160) {
        //        decimal effortCompensation = 5000M;
        //        int extraDays = employeePartTime.HoursWorked - 160;
        //        salary += effortCompensation * extraDays;
        //    }
            Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
        // }
    }

}

CalculateSalaryMonthly(new List<IEmployee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180)
});


void CalculateSalaryMonthly(List<IEmployee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly()} ");
    }
}