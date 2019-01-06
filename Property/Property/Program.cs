using System;

namespace PropertyTest2
{
    class Emp : System.Object
    {
        private string name;
        /*public void SetName(string name) { this.name = name+"님"; }  //세터, setter
        public string GetName() { return this.name; }   //게터, getter*/

        public string Name  //일반속성
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value + "님";
            }
        }

        public int Sabun    //자동구현속성
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "[사원]" + Name + Sabun;
        }

    }

    class EmpTest
    {
        static void Main()
        {
            Emp e = new Emp();
            e.Name = "홍";   //L.Value
            e.Sabun = 1004;
            string s = e.Name;
            Console.WriteLine(e.Name);  //R.Value
            Console.WriteLine(e);
        }
    }
}