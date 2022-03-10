//UC3


int Present = 1;
int Emp_per_rate = 20;
int Emphr = 0;
int empwage = 0;
int Fulltime = 1;

Random random = new Random();
Random random1 = new Random();
int Employeeattendance = random.Next(0, 2);
int Employeetime = random.Next(0, 2);

if (Employeeattendance == Present)
{
    if (Employeetime == Fulltime)
    {
        Console.WriteLine("Employee is Present");
        Emphr = 8;
    }
    else
    {
        Console.WriteLine("Employee is Present");
        Emphr = 4;
    }
}
else
{
    Console.WriteLine("Employee is Absent");
    Emphr = 0;
}
empwage = (Emp_per_rate * Emphr);
Console.WriteLine("Daily Wage" + empwage);