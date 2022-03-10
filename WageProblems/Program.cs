//UC5


namespace WageProblems
{
    class program
    {

        public const int is_part_time = 1;//constant
        public const int is_full_time = 2;//constant
        public const int emp_hr_per_rate = 20;//constant
        public const int num_of_working_days = 20;
        static void Main(string[] args)
        {
            int emphr = 0;
            int empwage = 0;
            int totalempwage = 0;

            for (int day = 0; day < num_of_working_days; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case is_part_time:
                        emphr = 4;
                        break;
                    case is_full_time:
                        emphr = 8;
                        break;
                    default:
                        emphr = 0;
                        break;
                }
                empwage = (emp_hr_per_rate * emphr);
                totalempwage += empwage;
                Console.WriteLine("Daily employee wage:" + empwage);
            }
            Console.WriteLine("Total_Emp_Wage:" + totalempwage);
        }

    }
}

