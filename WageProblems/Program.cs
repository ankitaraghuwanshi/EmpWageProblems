//UC6


namespace WageProblems
{
    class program
    {

        public const int is_part_time = 1;//constant
        public const int is_full_time = 2;//constant
        public const int emp_hr_per_rate = 20;//constant
        public const int num_of_working_days = 100;//constant
        public const int max_hr_month = 10;//constant
        static void Main(string[] args)
        {
            int emphr = 0;
            int totalemphr = 0;
            int totalworkingdays = 0;

            while (totalemphr <= max_hr_month && totalworkingdays < num_of_working_days)
            {
                totalworkingdays++;
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
                totalemphr += emphr;
                Console.WriteLine("Day=" + totalworkingdays + "Emphr =" + emphr);
            }
            int totalempwage = (emp_hr_per_rate * emphr);
            Console.WriteLine("Total_Emp_Wage:" + totalempwage);
        }

    }
}