namespace DMHV2
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Text.RegularExpressions;

    public class clsUtils
    {
        // Global properties
        // These are used by all objects
        public bool SaveToDB { get; set; }
        public bool UpdateToDB { get; set; }
        public bool DeleteFromDB { get; set; }
        public int NoRecords { get; set; }
        public int Result { get; set; }
        public int UserID { get; set; }
        public string AddressLine1;
        public string AddressLine2;
        public string AddressLine3;
        public string AddressLine4;
        public string PostCode;
        public string Telephone;
        public string ContactName;
        public string Fax;
        public string eMail;
        public string WebsiteAddress;
        public string Memo;
        public string StockCode;
        public string ShopRef;
        public string WarehouseRef;
        public string SupplierRef;
        public string SeasonName;
        public int DeliveredQtyHangers;
        public int DeliveredQtyBoxes;
        public int DeliveredQtyGarments;
        public DateTime MovementDate;
        public int AdjustmentID;
        public int Qty;
        public string MovementType;
        public decimal Value;
        public string WarehouseName;
        public string ShopName;
        public string ToShopRef;
        public string ToShopName;
        public string FromShopRef;
        public string FromShopName;
        public int CurrQty;
        public int CurrentQty;
        public int ID;
        public int SalesID;
        public decimal SalesAmount;
        public int smtiid;
        public int smtoid;
        public int TOQty;
        public int TIQty;
        public int TotalLossItems;
        public int TotalGainItems;
        public int TotalItems;
        public string Reference;
        public int ShopDelID;
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
        public DateTime GetSundayDate(DateTime DatePicked, int DateType)
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

        public int GetConnID()
        {
            // open stream file to load c:\FPYData\conset.txt into memory
            // send back value to calling function.
            string content = File.ReadAllText(@"C:\FPYData\conset.txt");
            int idToPass = Convert.ToInt32(content);
            return idToPass;
        }
        public int GetBackupConnID(int ida)
        {
            // open stream file to load c:\FPYData\conset.txt into memory
            // send back value to calling function.
            if (ida == 2)
                return 4;
            else
                return 3;
        }
        // URL: https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        // User: Microsoft developers
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,  RegexOptions.None, TimeSpan.FromMilliseconds(200));
                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();
                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }
            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
