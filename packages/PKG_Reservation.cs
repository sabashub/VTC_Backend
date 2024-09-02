using Oracle.ManagedDataAccess.Client;
using System.Data;
using VTC.Models;

namespace VTC.packages
{
    public class PKG_Reservation : PKG_Base
    {


        public PKG_Reservation(string connectionString) : base(connectionString)
        {


        }
        public void Book_Reservation(Reservation reservation)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand("PKG_SABA_VTC_RESERVATIONS.book_reservation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    


                    command.Parameters.Add("p_first_name", OracleDbType.Varchar2).Value = reservation.First_Name;
                    command.Parameters.Add("p_last_name", OracleDbType.Varchar2).Value = reservation.Last_Name;
                    command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = reservation.Email;
                    command.Parameters.Add("p_telephone", OracleDbType.Varchar2).Value = reservation.Telephone;
                    command.Parameters.Add("p_start_point", OracleDbType.Varchar2).Value = reservation.Start_Point;
                    command.Parameters.Add("p_destination", OracleDbType.Varchar2).Value = reservation.Destination;
                    command.Parameters.Add("p_reservation_date", OracleDbType.Varchar2).Value = reservation.Reservation_Date;


                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
