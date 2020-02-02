// Darren Hannay
// Started Date: 02/02/2020
// Completed Date: ??/0?/2020
namespace DMHannayFYP
{
    using System.Windows.Forms;
    using System.Data;
    using System.Data.SqlClient;
    using System;
    using System.Text;

    public class ClsEmployee : ClsUtilities
    {
        public ClsEmployee()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        ~ClsEmployee()
        {
            SaveToDB = false;
            UpdateToDB = false;
            DeleteFromDB = false;
        }
        public Form RefToGridForm { get; set; }
        public static void LoadNewForm()
        {
            // Load a new instance of the create user form.
        }
        public static void LoadSelectedForm(int EmployeeID)
        {
            // Load a instance of the create user form with the details from the selected user.
            EmployeeID = 1;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Pending>")]
        public static string HashingSHA1(string ValueToHash)
        {
            var sha1 = System.Security.Cryptography.SHA512.Create();    // Create the Highest Hash Value
            var inputValueToHash = Encoding.ASCII.GetBytes(ValueToHash);
            var hashing = sha1.ComputeHash(inputValueToHash);
            sha1.Dispose();
            var stringbuilder = new StringBuilder();
            for(var a = 0; a<hashing.Length; a++)
            {
                stringbuilder.Append(hashing[a].ToString("X2"));
            }
            return stringbuilder.ToString();
        }
    }
}
