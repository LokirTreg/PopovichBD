using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using UI.Areas.Public.Models;
using System.Data;

namespace UI.Areas.Public.Controllers
{
	[Area("Public")]
	public class HomeController : Controller
	{
		static string connectionString = "Data Source=ALEXLAPTOP\\SQLEXPRESS;Initial Catalog=Library;Trusted_Connection=True;TrustServerCertificate=True;Integrated security=True"; 
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult DebtOfHuman(string nameofdebtor)
		{
			string sqlExpression = "Долг_Человека";

			List<DebtOfHumanViewModel> debtOfHumanList = new List<DebtOfHumanViewModel>();
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExpression, connection);
				command.Parameters.AddWithValue("@name_of_debtor", nameofdebtor);
				command.CommandType = System.Data.CommandType.StoredProcedure;

				var reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						DebtOfHumanViewModel DH = new DebtOfHumanViewModel
						{
							DebtSum = reader.GetInt32(0),
							Name = reader.GetString(1)
						};
						debtOfHumanList.Add(DH);
					}
				}
				reader.Close();
			}
			return View(debtOfHumanList);
		}
		public IActionResult CountOfCopies(string title)
		{
			string sqlExpression = "Count_of_copies";

			int count = 0;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExpression, connection);
				command.Parameters.AddWithValue("@title", title);
				command.Parameters.Add("@Count_of_copies", SqlDbType.Int).Direction = ParameterDirection.Output;
				command.CommandType = System.Data.CommandType.StoredProcedure;

				var reader = command.ExecuteReader();

				count = (int)command.Parameters["@Count_of_copies"].Value;
			}
			return View(count);
		}
		public IActionResult View1()
		{
			string sqlExpression = "SELECT * FROM [View_1]";

			List<View1ViewModel> view1s = new List<View1ViewModel>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExpression, connection);

				var reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						View1ViewModel view1row = new View1ViewModel
						{
							Title = reader.GetString(0),
							Name = reader.GetString(1)
						};

						view1s.Add(view1row);
					}
				}
				reader.Close();
			}

			return View(view1s);
		}
		public IActionResult View2()
		{
			string sqlExpression = "SELECT * FROM [View_2]";

			List<View2ViewModel> view2s = new List<View2ViewModel>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExpression, connection);

				var reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						View2ViewModel view2row = new View2ViewModel
						{
							Name = reader.GetString(0)
						};

						view2s.Add(view2row);
					}
				}
				reader.Close();
			}

			return View(view2s);
		}public IActionResult View3()
		{
			string sqlExpression = "SELECT * FROM [View_3]";

			List<View3ViewModel> view3s = new List<View3ViewModel>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExpression, connection);

				var reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						View3ViewModel view3row = new View3ViewModel
						{
							Name_Libra = reader.GetString(0),
							Title = reader.GetString(1),
							Inventor_Nubmber = reader.GetInt32(2)
						};

						view3s.Add(view3row);
					}
				}
				reader.Close();
			}

			return View(view3s);
		}
	}
}