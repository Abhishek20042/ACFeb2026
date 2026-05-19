namespace Payroll
{
    //user-defined reference type
    class Employee
    {
        private int hours;
        private float rate;

        public Employee(int h, float r)
        {
            hours = h;
            rate = r;
        }

        public Employee() : this(0, 50)
        {
        }

        //a property provides methods for reading/writing a value 
        //using field like syntax
        public int Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public float HourlyRate
        {
            get { return rate; }
            set { rate = value; }
        }

        //calculated property
        public int Workdays
        {
            get { return hours / 8; }
            set { hours = 8 * value; }
        }

        //a method defined with 'virtual' keyword can be overridden
        //in the derived class
        public virtual double Income()
        {
            double amount = hours * rate;
            int ot = hours - 180;
            if(ot > 0)
                amount += 50 * ot;
            return amount;
        }
    }
}