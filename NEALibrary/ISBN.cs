using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEALibrary
{
    

    public class ISBN
    {
        private long ISBNCode;
        private bool ISBNValid;
        public ISBN()
        {
        }
        public ISBN(long Isbncode)
        {
            SetISBN(Isbncode);
        }
        public void SetISBN(long Isbncode)
        {

            ISBNCode = Isbncode;
            ISBNLength();
        }
        public long GetISBNCode()
        {
            return ISBNCode;
        }
        private void ISBNLength()
        {
            if (Convert.ToString(ISBNCode).Length == 13)
            {
                ISBNValid = true;
            }
            else
            {
                ISBNValid = false;
            }
        }
        public bool GetISBNValid()
        {
            return ISBNValid;
        }
        public bool CheckDigit()
        {
            if (!ISBNValid)
            {
                return false;
            }
            int sum = 0;
            string ISBNCodeStr = ISBNCode.ToString();
            int checkdigit;
            
            
            for (int i = 0; i < 12; i++)
            {
                int digit = int.Parse(ISBNCodeStr[i].ToString());
                if (i % 2 == 0)
                {
                    sum += digit;
                }
                else
                {
                    sum += digit * 3;
                }
            }
            int modulo = sum % 10;
            if (modulo == 0)
            {
                checkdigit = 0;
            }
            else
            {
                checkdigit = 10 - modulo;
            }
            return checkdigit == int.Parse(ISBNCodeStr[12].ToString());
            
            
        }


    }

}
