using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dalegate_Real_Use_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 0
            #endregion

            List<Empolyee> empList = new List<Empolyee>();
            empList.Add(new Empolyee() { ID = 101, Name = "Mary", Salary = 5000, Experince = 5 });
            empList.Add(new Empolyee() { ID = 102, Name = "Atmar", Salary = 1000, Experince = 4 });
            empList.Add(new Empolyee() { ID = 103, Name = "Mursal", Salary = 500, Experince = 6 });
            empList.Add(new Empolyee() { ID = 104, Name = "Jazmin", Salary = 50500, Experince = 2 });

            //you need this too
            //Ispermotable isPromotabl = new Ispermotable(Permote); you need this too
            //insid this you can write lamda and even you dont need isPromotabl
            //Empolyee.PermoteEmpolyee(empList, isPromotabl); 
            Empolyee.PermoteEmpolyee(empList, emp=>emp.Experince >=5);
        }
        #region 1
        /*to use lamda you can get rid of this function all together
         * public static bool Permote(Empolyee emp)
        {
            if (emp.Experince >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      */
        #endregion

    }
    delegate bool Ispermotable(Empolyee empl);
    class Empolyee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experince { get; set; }
        
        public static void PermoteEmpolyee(List<Empolyee> empolyeeList, Ispermotable IsEiligiableToPromote)
        {
            foreach (Empolyee empolyee in empolyeeList)
            {
              
                if (IsEiligiableToPromote(empolyee))
                {
                    Console.WriteLine(empolyee.Name + "permpted");
                }
            }

        }
    }

}

