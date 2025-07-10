using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Xml.Linq;
using static company;


#region Q1
public class company
{
    public enum securityy
    {
        guest,
        Developer,
        secretary,
        DBA,
    }
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
    
    char gender;
    public char Gender
    {
        get
        { return gender; }

        set
        {
            if (gender == 'M' || gender == 'F')
                gender = value;
            else throw new Exception("must be F or M ");
        }

    }
    public employee(int id, string Name ,char Gender)
    {
            id = id;
            name = Name;
            gender = Gender;
           

    }
}
}

#endregion

#region Q2
public class Date
{

    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    // Constructor
    public Date(int day, int month, int year)
    {


        Day = day;
        Month = month;
        Year = year;
    }
}
#endregion
namespace assOOP02
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            employee emp = new employee(1, "alaa", 'f');
            Console.WriteLine(emp.ToString());
            #endregion
            #region Q2
            Date hiringDate = new Date(10, 7, 2025);
            Console.WriteLine( hiringDate);
            #endregion

        }
    }
}
