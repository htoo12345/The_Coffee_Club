﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeClub.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TheCoffeeClub.DAO
{
    public class CoffeeServer : ICoffeeDAO
    {
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------

        public List<CoffeeModel> GetCoffeeList()
        {
            List<CoffeeModel> coffeeListModels = new List<CoffeeModel>();

            string connectionString = "Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            if (sqlConnection != null)
            {
                string query = "select * from Owner Order by No";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    CoffeeModel dbCoffeeModel = new CoffeeModel()
                    {
                        No = Convert.ToInt32(sqlDataReader["No"]),
                        Coffee = sqlDataReader["Coffee"].ToString(),
                        Price = Convert.ToInt32(sqlDataReader["Price"]),
                    };

                    coffeeListModels.Add(dbCoffeeModel);

                }  // end of while loop

                sqlDataReader.Close();
                sqlConnection.Close();
            } // end of if 
            return coffeeListModels;

        } // end of GetCoffeeList

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
       

        public void DeleteCoffee(CoffeeModel coffeeModel)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"delete from Owner where No={coffeeModel.No}";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                       // MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error occur "+error.Message);
            }
        }

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------

        public void UpdateCoffee(CoffeeModel coffeeModel)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"update Owner set Coffee = '{coffeeModel.Coffee}' , Price = {coffeeModel.Price} where No= {coffeeModel.No} ";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        //return  true;
                        //MessageBox.Show("correct");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error occur when {error.Message}!","Error Occur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //return false;
        }

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------

        public void InsertCoffee(CoffeeModel coffeeModel)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=CoffeeClubMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"insert into Owner values ({coffeeModel.No},'{coffeeModel.Coffee}',{coffeeModel.Price})";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        //MessageBox.Show($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------------
    }
}