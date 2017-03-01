using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ADP_Tests.tests.Total_Solution_tests
{
   public class JenkinsTest
   {
       private int age = 32;
       private string variable = System.Environment.GetEnvironmentVariable("BRET ID");

        [Test]
       public void Test()
       {

           Console.WriteLine(variable);
       }
   }
}
