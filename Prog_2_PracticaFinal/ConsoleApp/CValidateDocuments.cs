using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class CValidateDocuments
    {
        //Clase con metodos para validar documentos y formatear resultados.

        #region Validation
        public static bool  ValidateRNC(string documentoRNC)
        {
            string pattern = @"\d{1}\d{2}\d{5}\d{1}";
            var validRegExp = Regex.IsMatch(documentoRNC, pattern);

            if (documentoRNC.Length == 9 && validRegExp)
                return true;
            else
                return false;
        }

        public static bool ValidateCedula(string documentoCedula)
        {

            string pattern = @"\d{3}\d{7}\d{1}";
            var validExp = Regex.IsMatch(documentoCedula, pattern);

            if (documentoCedula.Length == 11 && validExp)
                return true;
            else
                return false;
        }

        public static bool ValidatePassport(string documentPasaporte)
        {
            string pattern = @"^[A-Z]{2}\d{7}";
            var validExp = Regex.IsMatch(documentPasaporte, pattern);

            if (documentPasaporte.Length == 9 && validExp)
                return true;
            else
                return false;
        }

        #endregion



        #region Format
        public static string FormatRNC(string documentoRNC)
        {
            //Primero ejecutar la validacion.
            if (CValidateDocuments.ValidateRNC(documentoRNC))
            {
                string[] Arrgrnc = new string[4]; //El arreglo esta demas, se puede simplificar mas y ahorrar mas memoria.

                Arrgrnc[0] = documentoRNC.Substring(0, 1);
                Arrgrnc[1] = documentoRNC.Substring(1, 2);
                Arrgrnc[2] = documentoRNC.Substring(3, 5);
                Arrgrnc[3] = documentoRNC.Substring(8, 1);

                string formatResult = "";

                for (int i = 0; i < Arrgrnc.Length; i++)
                {
                    if (i == 0)
                        formatResult = Arrgrnc[i];
                    else
                        formatResult += "-" + Arrgrnc[i];
                }

                return formatResult;

            }
            else
                return "Error, RNC no valido.";
            
        }

        public static string FormatCedula(string documentoCedula)
        {
            //Primero ejecutar la validacion.
            if (CValidateDocuments.ValidateCedula(documentoCedula))
            {
                string[] Arrgrnc = new string[3]; //El arreglo esta demas, se puede simplificar mas y ahorrar mas memoria.

                Arrgrnc[0] = documentoCedula.Substring(0, 3);
                Arrgrnc[1] = documentoCedula.Substring(3, 7);
                Arrgrnc[2] = documentoCedula.Substring(10, 1);

                string formatResult = "";

                for (int i = 0; i < Arrgrnc.Length; i++)
                {
                    if (i == 0)
                        formatResult = Arrgrnc[i];
                    else
                        formatResult += "-" + Arrgrnc[i];
                }

                return formatResult;

            }
            else
                return "Error, Cedula no valido.";
        }



        public static string FormatPasaporte(string documentPasaporte)
        {
            //Primero ejecutar la validacion.
            if (CValidateDocuments.ValidatePassport(documentPasaporte.ToUpper()))
            {
                return documentPasaporte.ToUpper();   
            }
            else
                return "Error, Pasaporte no valido o quizas de una nación no registrada.";
        }





        #endregion






    }


}
