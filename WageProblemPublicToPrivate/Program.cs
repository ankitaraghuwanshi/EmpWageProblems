using System;

namespace WageProblem
{
    class Company
    {
        public float EmpWagePerHour = 20;
        public int FullTimeWorkingHrsPerDay = 8;
        public int PartTimeWorkingHoursPerDay = 4;
        public int MaxWorkingHrs = 100;
        public int MaxWorkingDays = 20;
        public string CompanyName;

        public Company(string CompanyName, int EmpWagePerHour, int FullTimeWorkingHrsPerDay, int PartTimeWorkingHoursPerDay, int MaxWorkingHrs, int MaxWorkingDays)
        {
            this.CompanyName = CompanyName;
            this.EmpWagePerHour = EmpWagePerHour;
            this.FullTimeWorkingHrsPerDay = FullTimeWorkingHrsPerDay;
            this.PartTimeWorkingHoursPerDay = PartTimeWorkingHoursPerDay;
            this.MaxWorkingDays = MaxWorkingDays;
            this.MaxWorkingHrs = MaxWorkingHrs;
        }
    }    
    class EmployeeWageComputation
    {
        private const int IsFullTime = 1;
        private const int IsPartTime = 2;
        private const int IsAbsent = 0;
        float EmpDailyWage = 0;
        private float TotalWage = 0;
        private Dictionary<string, Company> Companies = new Dictionary<string, Company>();

        private void AddCompany(string CompanyName, int EmpWagePerHour, int FullTimeWorkingHrsPerDay, int PartTimeWorkingHoursPerDay, int MaxWorkingDays, int MaxWorkingHrs)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePerHour, FullTimeWorkingHrsPerDay, PartTimeWorkingHoursPerDay, MaxWorkingDays, MaxWorkingDays);
            Companies.Add(CompanyName.ToLower(), company); 
        }

        private int IsEmployeePresent()
        {
            return new Random().Next(0, 3);

        }
        public void CalculateEmpWage(string CompanyName)
        {
            int DayNumber = 0;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;

            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("company not exist");
            Companies.TryGetValue(CompanyName.ToLower(), out Company Company);

            while (DayNumber <= Company.MaxWorkingDays && TotalWorkingHrs <= Company.MaxWorkingHrs)
            {
                switch (IsEmployeePresent())
                {

                    case IsAbsent:
                        EmpWorkingHrs = 0;
                        break;

                    case IsPartTime:
                        EmpWorkingHrs = Company.PartTimeWorkingHoursPerDay;
                        break;

                    case IsFullTime:
                        EmpWorkingHrs = Company.FullTimeWorkingHrsPerDay;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * Company.EmpWagePerHour;
                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;
            }
            Console.WriteLine("\nCompany name :" + CompanyName);
            Console.WriteLine("Total Working Days :" + (DayNumber) + "\nTotal working hours " + TotalWorkingHrs + "\n total employee Wage :" + TotalWage);

        }            
        static void Main(string[] args)
        {
            Console.WriteLine(" welcome to Employee Wage computation");

            EmployeeWageComputation employeeWageComputation = new EmployeeWageComputation();
            employeeWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeWageComputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            employeeWageComputation.CalculateEmpWage("TATA");
            employeeWageComputation.CalculateEmpWage("MAHINDRA");

        }

    }

       
    
    
    

}
           

