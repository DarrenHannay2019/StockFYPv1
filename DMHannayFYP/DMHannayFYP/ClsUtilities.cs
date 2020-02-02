using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHannayFYP
{
    public class ClsUtilities
    {
        // Global properties
        // These are used by all objects
        public bool SaveToDB { get; set; }
        public bool UpdateToDB { get; set; }
        public bool DeleteFromDB { get; set; }
        public int NoRecords { get; set; }
        public int Result { get; set; }
        public int UserID { get; set; }
        public static string GetConnString(int ID)
        {
            // Returns the correct Database connection string for the identity record.
            if (ID == 1)
            {
                return @"Initial Catalog=FYPv1;Data Source=.\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;";
            }
            else if (ID == 2)
            {
                return @"Initial Catalog=FYPv1;Data Source=192.168.1.200;Persist Security Info=False;Integrated Security=false;User ID=FYPUser;Password=@35Adc@*K9z&QJ";
            }
            else if (ID == 3)
            {
                return @"Initial Catalog=master;Data Source=.\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;";
            }
            else
            {
                return @"Initial Catalog=master;Data Source=192.168.1.200;Persist Security Info=False;Integrated Security=false;User ID=FYPUser;Password=@35Adc@*K9z&QJ";
            }
        }
        public static DateTime GetSundayDate(DateTime DatePicked, int DateType)
        {
            // Gives the correct Sunday's Date depending on the function that is calling the function.
            if (DateType == 1)
            {
                return DatePicked.AddDays(0 - DatePicked.DayOfWeek);
            }
            else
            {
                return DatePicked.AddDays(0 - DatePicked.DayOfWeek + 7);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1304:Specify CultureInfo", Justification = "<Pending>")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Pending>")]
        public static string ChangeCase(string TextToConvert, int TextType)
        {
            if (TextType == 1)
            {
                return TextToConvert.ToUpper();
            }
            else if (TextType == 2)
            {
                return TextToConvert.ToLower();
            }
            else
            {
                TextInfo textInfo = new CultureInfo("en-GB", false).TextInfo;
                return textInfo.ToTitleCase(TextToConvert);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Pending>")]
        public static int GetConnID()
        {
            // open stream file to load c:\FPYData\conset.txt into memory
            // send back value to calling function.
            string content = File.ReadAllText(@"C:\FPYData\conset.txt");
            int idToPass = Convert.ToInt32(content);
            return idToPass;
        }
        public static int GetBackupConnID(int ida)
        {
            // open stream file to load c:\FPYData\conset.txt into memory
            // send back value to calling function.
            if (ida == 2)
                return 4;
            else
                return 3;
        }
    }
}

