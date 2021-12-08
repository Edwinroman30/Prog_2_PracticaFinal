using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {

        /*
         ------------------------RegExp-----------------------------
         Clases Utiles:
             -Regex.
             -Match.
             -MatchCollection.
             -GroupCollection.

          Metodos Utiles:
                -Matches.

          Propiedades Utiles:
                -Groups.

            Referencias:
                https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
                https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=net-6.0
         
         */


        static void Main(string[] args)
        {

            //Modelos o ejemplos

            /*----------RNC-----------
             1-01-08899-2 -> 101088992
             1-31-55300-1 -> 131553001
             */

            /*--------Cedula---------
             402-1327167-5 -> 40213271675
             001-1285166-2 -> 00112851662
             402-3687283-0 -> 40236872830
             066-0022825-5 -> 06600228255
            */

            string ced = "40213271675";

           


            Console.WriteLine(CValidateDocuments.FormatCedula(ced));
            Console.WriteLine(CValidateDocuments.FormatCedula("00112851662"));
            Console.WriteLine(CValidateDocuments.FormatCedula("02600743120"));


            Console.WriteLine("Su RNC: {0}",CValidateDocuments.FormatRNC("101071419"));


        }


    }
}
