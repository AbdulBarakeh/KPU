using System;

namespace CprDLL
{
    public class CprCheck
    {
        public enum CprError
        {
            NoError,
            FormatError,
            DateError,
            Check11Error
        }
        public bool Check(string cprTxt, out CprError error)
        {
            bool validCPR = true;
            error = CheckFormat(cprTxt);
            if (error != CprError.NoError)
            {
                validCPR = false;
            }
            error = CheckDate(cprTxt);
            if (error != CprError.NoError)
            {
                validCPR = false;
            }
            error = Check11Test(cprTxt);
            if (error != CprError.NoError)
            {
                validCPR = false;
            }

            return validCPR;
        }

        public CprError Check11Test(string cprTxt)
        {
            CprError cprError = CprError.NoError;

            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += int.Parse(cprTxt.Substring(i, 1)) * (4 - i);
            }
            for (int i = 3; i < 10; i++)
            {
                sum += int.Parse(cprTxt.Substring(i, 1)) * (10 - i);
            }
            if (sum % 11 != 0)
            {
                cprError = CprError.Check11Error;
            }

            return cprError;
        }
        public  CprError CheckFormat(string cprTxt)
        {
            CprError cprError = CprError.NoError;
            if (cprTxt.Length != 10)
            {
                cprError = CprError.FormatError;
                //throw  new FormatException();
            }
            return cprError;
        }
        public  CprError CheckDate(string cprTxt)
        {
            CprError cprError = CprError.NoError;
            string date = cprTxt.Substring(0, 6);
            string dateyfied = default;
            for (int i = 0; i < date.Length; i++)
            {
                if (i == 2)
                {
                    dateyfied = date.Insert(2, "-");
                }
                if (i == 4)
                {
                    dateyfied = dateyfied.Insert(5, "-");
                }
            }
            bool validDate = DateTime.TryParse(dateyfied, out DateTime res);
            if (!validDate)
            {
                cprError = CprError.DateError;
                //throw new Exception("Date is not valid: " + dateyfied);
            }
            return cprError;
        }
    }
}
