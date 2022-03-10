//UC4


namespace wageproblems
{
    class program
    {

        public const int is_part_time = 1;//constant
        public const int is_full_time = 2;//constant
        public const int emp_hr_per_rate = 20;//constant

        static void Main(string[] args)
        {
            int emphr = 0;
            int empwage = 0;
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
            empwage = (emp_hr_per_rate - emp_hr_per_rate * emphr);
            Console.WriteLine("Daily employee wage:" + empwage);
        }

    }
}
