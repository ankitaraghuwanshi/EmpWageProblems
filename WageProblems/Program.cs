//UC1

int present = 1;
Random random = new Random();
int Employeeattendance = random.Next(0, 2);
if (Employeeattendance == present)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is absent");
}