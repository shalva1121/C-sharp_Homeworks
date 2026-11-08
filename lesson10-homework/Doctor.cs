namespace lesson10_homework
{
    internal class Doctor
    {
        private string _specialization;

        public string Specialization
        {
            get { return _specialization; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    _specialization = value;
                }
            }
        }

        public void PerformDuty()
        {
            Console.WriteLine($"{FullName}");
        }

        public decimal CalculateBonus(int patientCount)
        {
            return *patientCount;
        }
    }
}
