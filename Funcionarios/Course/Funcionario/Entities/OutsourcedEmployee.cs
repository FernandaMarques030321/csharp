namespace Course.Entities
{
    class OutsourcedEmployee : Employee
    { 
        public double AdditionalCharge { get; set; }
        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuesPerHour, double additionalCharge)
           : base (name, hours,valuesPerHour)
        {
            AdditionalCharge = additionalCharge;

        }

        public override double Payment()
        {
            return base.Payment() + 1.1 *AdditionalCharge;
        }
    }
}
