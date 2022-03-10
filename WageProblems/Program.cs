//UC2

int Present = 1;
int Empperrate = 20;
int EmpWage = 0;
int Emphours = 0;

Random random = new Random();
int Employeeattendance = random.Next(0, 2);
if (Employeeattendance == Present)
{
    Console.WriteLine("Employee is present");
    Emphours = 8;
}
else
{
    Console.WriteLine("Employee is absent");
    Emphours = 0;
}
EmpWage = (Empperrate * Emphours);
Console.WriteLine("Daily wage" + EmpWage);