using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace TrainingCenter
{
    class Trainee : Person
    {
		
		//const string DBC = "Data Source=DESKTOP-NC87HB1;Initial Catalog=TrainingCenter;Integrated Security=True";
		public void InsertInTrainee(Trainee T)
        {			
				// Create All Tables
				 string Query = " INSERT  INTO Trainee (TraineeFirstName,TraineeLastName,TraineeGender,TraineePhone,TraineeEmail) VALUES('"
				+ T.Firstname+"','"+T.Lastname+"','"+T.Gender+"','"+T.Phone+"','"+T.Email+"'); SELECT @@identity;";
			SqlConnection conn = new SqlConnection(DBC);
				SqlCommand cmd = new SqlCommand(Query, conn);

				conn.Open();
				T.ID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
				conn.Close();
		
		
		}

		public void InsertInLogin(Trainee T)
		{

			string Query = " INSERT  INTO LoginData (TraineeID ,StaffID,Username,ThePassword,TheRole) VALUES('"
				+ T.ID + "','" + 0 + "','" + T.Email+ "','" + T.password + "','" + T.role+ "');";
			SqlConnection conn = new SqlConnection(DBC);
			SqlCommand cmd = new SqlCommand(Query, conn);

			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public bool CheckEmailExist(string email)
		{
			string count;
			string Query = "select count(TraineeEmail) from Trainee where TraineeEmail= '" + email + "'";
			SqlConnection conn = new SqlConnection(DBC);
			SqlCommand cmd = new SqlCommand(Query, conn);

			conn.Open();
			count=cmd.ExecuteScalar().ToString();
			conn.Close();

			if (count == "0")
				return false;
			else
				return true;
		}

		
	}
}
