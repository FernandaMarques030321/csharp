
namespace Course.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuesPerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuesPerHour)
        {
            Name = name;
            Hours = hours;
            ValuesPerHour = valuesPerHour;
        }
        public virtual double Payment()
        {
            return Hours * ValuesPerHour;
        }
    }
}
