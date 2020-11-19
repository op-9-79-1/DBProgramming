using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace coffershop1
{


	public partial class DBManager
	{
		private string connection_string = "Server=49.50.174.201;Database=s5414441;Uid=s5414441;Pwd=s5414441;Charset=utf8"; //db 설정
		private string update_query = string.Empty;
		private static DBManager instance_ = new DBManager();

		public static DBManager GetInstance()
		{
			return instance_;
		}
		private DBManager()
		{
		}
		public void Insert_A_Update(string query)
		{
			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				MySqlCommand cmdinsert = new MySqlCommand(query, conn);
				cmdinsert.ExecuteNonQuery();

				conn.Close();
			}
		}
		public void Insert_coffee(LoginAccount la, int id, string time)
		{
			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				update_query = @"INSERT INTO order_list(order_time, coffee_sid, user_sid) VALUES ('#time', '#id', '#la')";
				update_query = update_query.Replace("#la", la.id.ToString());
				update_query = update_query.Replace("#id", id.ToString());
				update_query = update_query.Replace("#time", time);

				MySqlCommand cmd = new MySqlCommand(update_query, conn);
				cmd.ExecuteNonQuery();

				conn.Close();
			}
		}
		public LoginAccount Login(string id, string pw)
		{
			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				update_query = @"select id, name, master from account where uid = '#id' && password = '#pw'";
				update_query = update_query.Replace("#id", id);
				update_query = update_query.Replace("#pw", pw);

				MySqlCommand cmd = new MySqlCommand(update_query, conn);
				MySqlDataReader rdr = cmd.ExecuteReader();

				rdr.Read();

				LoginAccount la = new LoginAccount(rdr["id"].ToString(), rdr["name"].ToString(), rdr["master"].ToString());

				return la;
			}
		}
		public DataTable Load1_Table(string time)
		{
			DataTable table = new DataTable();

			int count;
			int price;
			int coffee_count;
			int coffee_price;
			string name;


			DataColumn accountColumn = new DataColumn("사용자", typeof(string));
			DataColumn account_daily_priceColumn = new DataColumn("사용자별 일일 판매량", typeof(string));
			DataColumn account_daily_countColumn = new DataColumn("사용자별 일일 판매액", typeof(string));

			table.Columns.Add(accountColumn);
			table.Columns.Add(account_daily_priceColumn);
			table.Columns.Add(account_daily_countColumn);

			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				update_query = "Select count(*) FROM account WHERE master = '0'";
				MySqlCommand cmd = new MySqlCommand(update_query, conn);
				count = Convert.ToInt32(cmd.ExecuteScalar());

				for (int j = 1; j <= count; j++)
				{
					price = 0;

					update_query = @"Select name from account where id = '#id'";
					update_query = update_query.Replace("#id", j.ToString());
					cmd = new MySqlCommand(update_query, conn);
					MySqlDataReader rdr = cmd.ExecuteReader();

					rdr.Read();
					name = rdr["name"].ToString();
					rdr.Close();

					update_query = @"select count(*) from order_list where order_time LIKE '%#time%' AND user_sid = '#id'";
					update_query = update_query.Replace("#time", time);
					update_query = update_query.Replace("#id", j.ToString());
					cmd = new MySqlCommand(update_query, conn);
					int count_daily = Convert.ToInt32(cmd.ExecuteScalar());

					for (int i = 1; i <= 3; i++)
					{

						update_query = @"select count(*) from order_list where coffee_sid = '#sid' AND order_time LIKE '%#time%' AND user_sid = '#user'";
						update_query = update_query.Replace("#sid", i.ToString());
						update_query = update_query.Replace("#time", time);
						update_query = update_query.Replace("#user", j.ToString());
						cmd = new MySqlCommand(update_query, conn);
						coffee_count = Convert.ToInt32(cmd.ExecuteScalar());

						update_query = @"select price from coffee where id = '#id'";
						update_query = update_query.Replace("#id", i.ToString());
						cmd = new MySqlCommand(update_query, conn);
						coffee_price = Convert.ToInt32(cmd.ExecuteScalar());

						price += coffee_count * coffee_price;
					}
					table.Rows.Add(name, count_daily.ToString(), price.ToString());
				}
				conn.Close();
			}
			return table;
		}
		public DataTable Load2_Table(string time)
		{
			int count;
			int coffee_count1 = 0;
			int coffee_price1 = 0;
			int coffee_count2 = 0;
			int coffee_price2 = 0;
			int coffee_count3 = 0;
			int coffee_price3 = 0;
			string name;

			DataTable table = new DataTable();

			DataColumn accountColumn = new DataColumn("사용자", typeof(string));
			DataColumn account_daily_priceColumn1 = new DataColumn("아메리카노 일일 판매량", typeof(string));
			DataColumn account_daily_countColumn1 = new DataColumn("아메리카노 일일 판매액", typeof(string));
			DataColumn account_daily_priceColumn2 = new DataColumn("라떼 일일 판매량", typeof(string));
			DataColumn account_daily_countColumn2 = new DataColumn("라떼 일일 판매액", typeof(string));
			DataColumn account_daily_priceColumn3 = new DataColumn("카페모카 일일 판매량", typeof(string));
			DataColumn account_daily_countColumn3 = new DataColumn("카페모카 일일 판매액", typeof(string));

			table.Columns.Add(accountColumn);
			table.Columns.Add(account_daily_priceColumn1);
			table.Columns.Add(account_daily_countColumn1);
			table.Columns.Add(account_daily_priceColumn2);
			table.Columns.Add(account_daily_countColumn2);
			table.Columns.Add(account_daily_priceColumn3);
			table.Columns.Add(account_daily_countColumn3);

			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				update_query = "Select count(*) FROM account WHERE master = '0'";
				MySqlCommand cmd = new MySqlCommand(update_query, conn);
				count = Convert.ToInt32(cmd.ExecuteScalar());

				for (int j = 1; j <= count; j++)
				{

					update_query = @"Select name from account where id = '#id'";
					update_query = update_query.Replace("#id", j.ToString());
					cmd = new MySqlCommand(update_query, conn);
					MySqlDataReader rdr = cmd.ExecuteReader();

					rdr.Read();
					name = rdr["name"].ToString();
					rdr.Close();

					for (int i = 1; i <= 3; i++)
					{
						update_query = @"select count(*) from order_list where coffee_sid = '#sid' AND order_time LIKE '%#time%' AND user_sid = '#user'";
						update_query = update_query.Replace("#sid", i.ToString());
						update_query = update_query.Replace("#time", time);
						update_query = update_query.Replace("#user", j.ToString());
						MySqlCommand cmd_count = new MySqlCommand(update_query, conn);

						if (i == 1)
							coffee_count1 = Convert.ToInt32(cmd_count.ExecuteScalar());
						else if (i == 2)
							coffee_count2 = Convert.ToInt32(cmd_count.ExecuteScalar());
						else
							coffee_count3 = Convert.ToInt32(cmd_count.ExecuteScalar());

						update_query = @"select price from coffee where id = '#id'";
						update_query = update_query.Replace("#id", i.ToString());
						MySqlCommand cmd_price = new MySqlCommand(update_query, conn);

						if (i == 1)
							coffee_price1 = Convert.ToInt32(cmd_price.ExecuteScalar()) * coffee_count1;
						else if (i == 2)
							coffee_price2 = Convert.ToInt32(cmd_price.ExecuteScalar()) * coffee_count2;
						else
							coffee_price3 = Convert.ToInt32(cmd_price.ExecuteScalar()) * coffee_count3;
					}
					table.Rows.Add(name, coffee_count1.ToString(), coffee_price1.ToString(), coffee_count2.ToString(), coffee_price2.ToString(), coffee_count3.ToString(), coffee_price3.ToString());
				}
				conn.Close();
			}
			return table;
		}
		public DataTable Load3_Table(string time)
		{
			int count;
			int coffee_count1 = 0;
			int coffee_price1 = 0;
			int coffee_count2 = 0;
			int coffee_price2 = 0;
			int coffee_count3 = 0;
			int coffee_price3 = 0;
			string name;

			DataTable table = new DataTable();

			DataColumn accountColumn = new DataColumn("사용자", typeof(string));
			DataColumn account_monthly_priceColumn1 = new DataColumn("아메리카노 월별 판매량", typeof(string));
			DataColumn account_monthly_countColumn1 = new DataColumn("아메리카노 월별 판매액", typeof(string));
			DataColumn account_monthly_priceColumn2 = new DataColumn("라떼 월별 판매량", typeof(string));
			DataColumn account_monthly_countColumn2 = new DataColumn("라떼 월별 판매액", typeof(string));
			DataColumn account_monthly_priceColumn3 = new DataColumn("카페모카 월별 판매량", typeof(string));
			DataColumn account_monthly_countColumn3 = new DataColumn("카페모카 월별 판매액", typeof(string));

			table.Columns.Add(accountColumn);
			table.Columns.Add(account_monthly_priceColumn1);
			table.Columns.Add(account_monthly_countColumn1);
			table.Columns.Add(account_monthly_priceColumn2);
			table.Columns.Add(account_monthly_countColumn2);
			table.Columns.Add(account_monthly_priceColumn3);
			table.Columns.Add(account_monthly_countColumn3);

			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				update_query = "Select count(*) FROM account WHERE master = '0'";
				MySqlCommand cmd = new MySqlCommand(update_query, conn);
				count = Convert.ToInt32(cmd.ExecuteScalar());

				for (int j = 1; j <= count; j++)
				{

					update_query = @"Select name from account where id = '#id'";
					update_query = update_query.Replace("#id", j.ToString());
					cmd = new MySqlCommand(update_query, conn);
					MySqlDataReader rdr = cmd.ExecuteReader();

					rdr.Read();
					name = rdr["name"].ToString();
					rdr.Close();

					for (int i = 1; i <= 3; i++)
					{
						update_query = @"select count(*) from order_list where coffee_sid = '#sid' AND order_time LIKE '%#time%' AND user_sid = '#user'";
						update_query = update_query.Replace("#sid", i.ToString());
						update_query = update_query.Replace("#time", time);
						update_query = update_query.Replace("#user", j.ToString());
						MySqlCommand cmd_count = new MySqlCommand(update_query, conn);

						if (i == 1)
							coffee_count1 = Convert.ToInt32(cmd_count.ExecuteScalar());
						else if (i == 2)
							coffee_count2 = Convert.ToInt32(cmd_count.ExecuteScalar());
						else
							coffee_count3 = Convert.ToInt32(cmd_count.ExecuteScalar());

						update_query = @"select price from coffee where id = '#id'";
						update_query = update_query.Replace("#id", i.ToString());
						MySqlCommand cmd_price = new MySqlCommand(update_query, conn);

						if (i == 1)
							coffee_price1 = Convert.ToInt32(cmd_price.ExecuteScalar()) * coffee_count1;
						else if (i == 2)
							coffee_price2 = Convert.ToInt32(cmd_price.ExecuteScalar()) * coffee_count2;
						else
							coffee_price3 = Convert.ToInt32(cmd_price.ExecuteScalar()) * coffee_count3;
					}
					table.Rows.Add(name, coffee_count1.ToString(), coffee_price1.ToString(), coffee_count2.ToString(), coffee_price2.ToString(), coffee_count3.ToString(), coffee_price3.ToString());
				}
				conn.Close();
			}
			return table;
		}
		public void Login_Log(LoginAccount la)
		{
			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				update_query = @"insert into Login_log(account_id, Login) values ('#account', '#time')";
				update_query = update_query.Replace("#account", la.id);
				update_query = update_query.Replace("#time", DateTime.Now.ToString("yyyy-MM-dd HH시mm분"));

				MySqlCommand cmd = new MySqlCommand(update_query, conn);
				cmd.ExecuteNonQuery();

				conn.Close();
			}
		}
		public void Logout_Log(LoginAccount la)
		{
			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				update_query = @"insert into Login_log(account_id, Logout) values ('#account', '#time')";
				update_query = update_query.Replace("#account", la.id);
				update_query = update_query.Replace("#time", DateTime.Now.ToString("yyyy-MM-dd HH시mm분"));
				MySqlCommand cmd = new MySqlCommand(update_query, conn);
				cmd.ExecuteNonQuery();

				conn.Close();
			}
		}
		public DataTable show_login_log()
		{
			int count;
			DataTable table = new DataTable();

			DataColumn accountColumn = new DataColumn("사용자", typeof(string));
			DataColumn account_daily_priceColumn = new DataColumn("로그인 시간", typeof(string));
			DataColumn account_daily_countColumn = new DataColumn("로그아웃 시간", typeof(string));

			table.Columns.Add(accountColumn);
			table.Columns.Add(account_daily_priceColumn);
			table.Columns.Add(account_daily_countColumn);
			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();
				update_query = "Select count(*) FROM account WHERE master = '0'";
				MySqlCommand cmd = new MySqlCommand(update_query, conn);
				count = Convert.ToInt32(cmd.ExecuteScalar());

				for (int i = 1; i <= count; i++)
				{
					update_query = @"Select account_id as '사용자', Login as '로그인 시간', Logout as '로그아웃 시간' from Login_log where account_id = '#id'";
					update_query = update_query.Replace("#id", i.ToString());
					cmd = new MySqlCommand(update_query, conn);
					MySqlDataReader rdr = cmd.ExecuteReader();

					while (rdr.Read())
					{
						table.Rows.Add(rdr["사용자"].ToString(), rdr["로그인 시간"].ToString(), rdr["로그아웃 시간"].ToString());
					}
					rdr.Close();
				}
				conn.Close();
			}
			return table;
		}
		public void coffee_Modify(DataTable table)
		{
			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = "select name as '커피 이름', price as '가격' from coffee";
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			adapter.SelectCommand = new MySqlCommand(update_query, conn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

			adapter.UpdateCommand = builder.GetUpdateCommand();
			adapter.Update(table);
		}
		public DataSet coffee_select()
		{

			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = "select name as '커피 이름', price as '가격' from coffee";
			MySqlDataAdapter adapter = new MySqlDataAdapter(update_query, conn);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			return ds;
		}

		public int coffee_count()
		{
			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = @"select count(*) from coffee";
			MySqlCommand cmd = new MySqlCommand(update_query, conn);
			int coffee_count = Convert.ToInt32(cmd.ExecuteScalar());

			return coffee_count;
		}

		public ListBox coffee_name()
		{
			ListBox listBox = new ListBox();
			using (MySqlConnection conn = new MySqlConnection(connection_string))
			{
				conn.Open();

				update_query = "select name from coffee";
				MySqlCommand cmd = new MySqlCommand(update_query, conn);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read())
					listBox.Items.Add(rdr["name"].ToString());

				conn.Close();
			}
			return listBox;
		}
		public DataSet order_select(string id, string time)
		{

			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = @"Select sid as '번호', order_time as '주문 시간', (select name from coffee where id = coffee_sid)as '커피 종류', memo as '메모' from order_list where order_time LIKE '%#time%' AND user_sid = '#id'";
			update_query = update_query.Replace("#time", time);
			update_query = update_query.Replace("#id", id);
			MySqlDataAdapter adapter = new MySqlDataAdapter(update_query, conn);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			return ds;
		}
		public void order_Modify(DataTable table, string id, string time)
		{
			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = @"Select sid as '번호', order_time as '주문 시간', (select name from coffee where id = coffee_sid)as '커피 종류', memo as '메모' from order_list where order_time LIKE '%#time%' AND user_sid = '#id'";
			update_query = update_query.Replace("#time", time);
			update_query = update_query.Replace("#id", id);
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			adapter.SelectCommand = new MySqlCommand(update_query, conn);
			MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

			adapter.UpdateCommand = builder.GetUpdateCommand();
			adapter.Update(table);
		}
		public DataSet order_select_time(string id, string day, string time)
		{

			MySqlConnection conn = new MySqlConnection(connection_string);

			update_query = @"Select sid as '번호', order_time as '주문 시간', (select name from coffee where id = coffee_sid)as '커피 종류', memo as '메모' from order_list where order_time LIKE '%#day%' AND user_sid = '#id' AND order_time LIKE '%#time'";
			update_query = update_query.Replace("#day", day);
			update_query = update_query.Replace("#id", id);
			update_query = update_query.Replace("#time", time);
			MySqlDataAdapter adapter = new MySqlDataAdapter(update_query, conn);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			return ds;
		}
	}
}
