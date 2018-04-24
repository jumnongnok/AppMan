using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string b = "";
            string c = "";
            string d = "";
            string e = "";
            Console.WriteLine("By Mr.Nitiphat Jumnongnok");
            Console.WriteLine("=================Formula==============");
            Console.WriteLine("Enter Number 1 To Case1 (A*B)+C");
            Console.WriteLine("Enter Number 2 To Case2 (a*b+c)/d");
            Console.WriteLine("Enter Number 3 To Case3 (a-b+c/d*e)+f");
            Console.Write("Enter Number = ");
            int caseWs = int.Parse(Console.ReadLine());

            switch (caseWs)
            {
                case 1:
                    string formulaC1 = "(a*b)+c";
                    Console.WriteLine("Case1 = (A*B)+C");

                    Console.WriteLine("Enter Num A:");
                    a = Console.ReadLine();
                    Console.WriteLine("Enter Num B:");
                    b = Console.ReadLine();
                    Console.WriteLine("Enter Num C:");
                    c = Console.ReadLine();

                    formulaC1 = formulaC1.Replace("a", a).Replace("b", b).Replace("c", c);

                    Console.WriteLine("Formula: {0}\tResult: {1}", formulaC1, Evaluate(formulaC1));
                    Console.ReadLine();
                    break;
                case 2:
                    string formulaC2 = "(a*b+c)/d";
                    Console.WriteLine("Case2 = (A*B+C)/D");

                    Console.WriteLine("Enter Num A:");
                    a = Console.ReadLine();
                    Console.WriteLine("Enter Num B:");
                    b = Console.ReadLine();
                    Console.WriteLine("Enter Num C:");
                    c = Console.ReadLine();
                    Console.WriteLine("Enter Num D:");
                    d = Console.ReadLine();

                    formulaC2 = formulaC2.Replace("a", a).Replace("b", b).Replace("c", c).Replace("d",d);

                    Console.WriteLine("Formula: {0}\tResult: {1}", formulaC2, Evaluate(formulaC2));
                    Console.ReadLine();
                    break;
                case 3:
                    string formulaC3 = "(a-b+c/d*e)";
                    Console.WriteLine("Case3 = (A-B+C/D*E)");

                    Console.WriteLine("Enter Num A:");
                    a = Console.ReadLine();
                    Console.WriteLine("Enter Num B:");
                    b = Console.ReadLine();
                    Console.WriteLine("Enter Num C:");
                    c = Console.ReadLine();
                    Console.WriteLine("Enter Num D:");
                    d = Console.ReadLine();
                    Console.WriteLine("Enter Num E:");
                    e = Console.ReadLine();

                    formulaC3 = formulaC3.Replace("a", a).Replace("b", b).Replace("c", c).Replace("d", d).Replace("e",e);

                    Console.WriteLine("Formula: {0}\tResult: {1}", formulaC3, Evaluate(formulaC3));
                    Console.ReadLine();

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
        public static double Evaluate(string expression)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("myExpression", string.Empty.GetType(), expression);
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            return double.Parse((string)row["myExpression"]);
        }
    }
}
