using System;

namespace Lab3
{
    class AirLines
    {
        readonly int id;
        public const string func = "Fly";
        public string destination { get; set;}
        public int? number { get; set; }
        public string day { get; set; }
        public int type { get; set; }
        public string time { get;}
        static int counter;
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public string GetDay()
        {
            return (this.day);
        }
        public string GetDestination()
        {
            return (this.destination);
        }


        public override bool Equals(object obj)
        {
            Console.WriteLine("Object equalified? \n" + base.Equals(obj));
            return base.Equals(obj);
        }



        public AirLines(int type, int number, string day, string time, string destination)
        {
            ++counter;
            this.type = type;
            this.number = number;
            this.day = day;
            this.time = time;
            this.destination = destination;
        }
        public AirLines(int id)
        {
            ++counter;
            this.number = null;
        }
        public AirLines()
        {
            ++counter;
        }
        public void DestDay(string destination, string day)
        {
            this.destination = destination;
            this.day = day;
        }
        static AirLines()
        {

        }
        protected AirLines(string time)
        {
            ++counter;
        }
        private void Func1(ref string str1)
        {
            if (str1 == null)
            {
                str1 = "some";
            }
        }
        public void Input(int type, int number, string day, string destination)
        {
            this.type = type;
            this.number = number;
            this.day = day;
            this.destination = destination;
        }
        private void Func2(out string str2)
        {
            str2 = "Jeff";
        }
        public virtual void About()
        {
            Console.Write(type +"\t");
            Console.Write(number + "\t");
            Console.Write(day + "\t");
            Console.Write(destination + "\n");
        }
    }
    partial class AirLine
    {
        public string destination { get; set; }
        public int? number { get; set; }
        public string day { get; set; }
        public int type { get; set; }
    }    
}
