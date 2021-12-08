using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FormsApp.Model;

namespace FormsApp
{
    class CDataAcessLayer
    {
        private string __stringConnection;


        public CDataAcessLayer()
        {
            __stringConnection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LoginPracticing;Data Source=DESKTOP-B9L1G5M";

        }


        public bool CheckExistingUser(string username)
        {
            bool userExist = false;


            using (var conn = new SqlConnection(this.__stringConnection))
            {


                conn.Open();

                string queryCheck = @"SELECT COUNT(*)
                                    FROM Userlogin
                                    WHERE userName = @userName";

                using (var command = new SqlCommand(queryCheck, conn))
                {

                    command.Parameters.Add(new SqlParameter("@userName", username));

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        userExist = true;
                        break;
                    }

                }
                conn.Close();
            }

            return userExist;

        }


        public int VerifyLogin(string username, string password)
        {
            int userId = 0;


            using (var conn = new SqlConnection(this.__stringConnection))
            {


                conn.Open();

                string queryCheck = @"SELECT *
                                    FROM Userlogin
                                    WHERE userName = @userName and userPass = @userPass";

                using (var command = new SqlCommand(queryCheck, conn))
                {

                    command.Parameters.Add(new SqlParameter("@userName", username));
                    command.Parameters.Add(new SqlParameter("@userPass", password));

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        userId = Convert.ToInt32(reader["idUser"]);
                        break;
                    }

                }
                conn.Close();
            }

            return userId;

        }

        //Probablemente las validaciones esten del lado del usuario
        public bool RegisterUser(string userName, string userPass, byte idUserRol)
        {
            int rowAfected;

            using (var conn = new SqlConnection(this.__stringConnection))
            {
                conn.Open();

                string queryIns = @"INSERT INTO Userlogin (userName,userPass,idUserRol)
                                    VALUES(@userName, @userPass, @idUserRol)";

                using (var command = new SqlCommand(queryIns, conn))
                {
                    command.Parameters.Add(new SqlParameter("@userName", userName));
                    command.Parameters.Add(new SqlParameter("@userPass", userPass));
                    command.Parameters.Add(new SqlParameter("@idUserRol", idUserRol));

                    rowAfected = command.ExecuteNonQuery();

                }

                conn.Close();
            }


            return (rowAfected > 0) ? true : false;

        }


        public List<CRolUsers> GetRolUsers()
        {
            List<CRolUsers> listaRoles = new List<CRolUsers>(); 

            using (var conn = new SqlConnection(this.__stringConnection))
            {

                conn.Open();

                string queryCheck = @"SELECT *
                                    FROM RolUsers";

                using (var command = new SqlCommand(queryCheck, conn))
                {

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        CRolUsers cRol = new CRolUsers();

                        cRol.IdRolUser = Convert.ToInt32(reader["idUserRol"]);
                        cRol.RolName = (reader["rolName"]).ToString();
                        cRol.DateCreating = Convert.ToDateTime(reader["dateCreating"]);

                        listaRoles.Add(cRol);

                    }

                }
                
                conn.Close();
            }

            return listaRoles;
        } 

    }
}
