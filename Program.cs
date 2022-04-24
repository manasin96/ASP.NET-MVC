using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace FootballLeague1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Connection();
        }
        static void Connection()
        {
            //Establishing the connection
            //Here DBCS is the name given for better understanding
            //connectionString="data source=.;database=Ado;integrated security=SSPI"

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Ado;Integrated Security=True");
            {
                // Retreiving all winning Team Names
                SqlCommand cmd = new SqlCommand("Select * from FootballLeague  where Status='Win' ", con);
                //connection is open
                con.Open();
                //Query Execution for Winning Teams 
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("Match_ID = " + dataReader[0] + "    " + "TeamName1 = " + dataReader[1] + "    " + "TeamName2 = " + dataReader[2]+"    " + "WinningTeam =" + dataReader[3]);
                }
                Console.ReadKey();
                con.Close();


            }
            {
                //Retrieving Data about the matches Japan played
                Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                SqlCommand cmd1 = new SqlCommand("Select * from FootballLeague where TeamName1='Japan'or TeamName2='Japan' ", con);
                con.Open();
                SqlDataReader dataReader1 = cmd1.ExecuteReader();
                while(dataReader1.Read())
                {
                    Console.WriteLine("All the matches in which Japan played are:");
                    Console.WriteLine("MatchID = " + dataReader1[0] +"    " +"TeamName1 = " + dataReader1[1] + "    " + "TeamName2 = " + dataReader1[2] + "    " + "Status = " + dataReader1[3] + "WinningTeam = "+dataReader1[4]+"    "+ "Points = "+dataReader1[5]);
                    }
                Console.ReadKey();
                con.Close();
            }
        }
    }
}