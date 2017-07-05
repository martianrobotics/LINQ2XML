using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LINQ2XML
{
    class Program
    {
        class employee
        {
            public string lastName { get; set; }
            public string firstName { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            //public int stateID { get; set; } // anonymous class
        }

        static void Main(string[] args)
        {
            List<employee> employees = new List<employee>()
            {
                new employee() {firstName="John",lastName="Smith",city="Havertown",state="PA"},
                new employee() {firstName="Jane",lastName="Doe"  ,city="Ewing",state="NJ"},
                new employee() {firstName="Jack",lastName="Jones",city="Fort Washington",state="PA"},
            };

            var XMLEmployees = new XElement("Query", from e in employees
                                                    select new XElement("Employee", 
                                                                new XElement("FirstName", e.firstName),
                                                                new XElement("LastName", e.lastName),
                                                                new XElement("City",e.city),
                                                                new XElement("State",e.state)
                                                                )
                                            );
            // hello github
            Console.WriteLine(XMLEmployees);
            
            
        }
    }
}
