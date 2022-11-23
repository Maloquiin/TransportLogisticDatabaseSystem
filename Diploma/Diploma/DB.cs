using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma
{
    //DB - класс для подключения к базе данных и взаимодействия
    class DB
    {

        /*Функция для подключения 
        * Формальные параметры отсутствуют
        * Локальные переменные:
        * sql - строка подключения;
        * con - подключение к бд.
        */
        public static MySqlConnection GetConnection()
        {
            string sql = "server=127.0.0.1;port=3306;username=admin;password=admin;database=settlement";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        /*Функция для добавления в таблицу клиенты 
        * Формальные параметры:
        * std - переменные для заглушек.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void AddClient(ClientSQL std)
        {
            
            string sql = "INSERT INTO clients (Name, Cost_downtime, Cost_mkad, Stavka20, Stavka40) VALUES (@Name,@Costd,@Costm,@Stavka20,@Stavka40);";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@Costd", MySqlDbType.VarChar).Value = std.Cost_downtime;
            cmd.Parameters.Add("@Costm", MySqlDbType.VarChar).Value = std.Cost_mkad;
            cmd.Parameters.Add("@Stavka20", MySqlDbType.VarChar).Value = std.Stavka20;
            cmd.Parameters.Add("@Stavka40", MySqlDbType.VarChar).Value = std.Stavka40;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено","Инфо",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка добавления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для изменения в таблице клиенты 
        * Формальные параметры:
        * std - переменные для заглушек;
        * id - номер строки для изменения.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void UpdateClient(ClientSQL std, string id)
        {
            string sql = "UPDATE clients SET Name = @Name, Cost_downtime = @Costd, Cost_mkad = @Costm, Stavka20 = @Stavka20, Stavka40 = @Stavka40 WHERE id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@Costd", MySqlDbType.VarChar).Value = std.Cost_downtime;
            cmd.Parameters.Add("@Costm", MySqlDbType.VarChar).Value = std.Cost_mkad;
            cmd.Parameters.Add("@Stavka20", MySqlDbType.VarChar).Value = std.Stavka20;
            cmd.Parameters.Add("@Stavka40", MySqlDbType.VarChar).Value = std.Stavka40;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно обновлено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка обновления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для удаления в таблице клиенты 
        * Формальные параметры:
        * id - номер строки для изменения.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void DeleteClient(string id)
        {
            string sql = "DELETE FROM clients WHERE id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно удалено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка удаления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для вывода из таблицы 
        * Формальные параметры:
        * quary - запрос;
        * dgv - DataGridView для вывода данных.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд;
        * adapter - адаптер для запроса;
        * tbl - таблица;
        */
        public static void Display(string quary, DataGridView dgv)
        {
            string sql = quary;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql,con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        /*Функция для добавления в таблице мкад 
        * Формальные параметры:
        * std - переменные для заглушек.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void AddMkad(MkadSQL std)
        {

            string sql = "INSERT INTO mkad (taking,setting, mkad_km) VALUES (@taking, @setting, @mkad_km);";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@taking", MySqlDbType.VarChar).Value = std.Taking;
            cmd.Parameters.Add("@setting", MySqlDbType.VarChar).Value = std.Setting;
            cmd.Parameters.Add("@mkad_km", MySqlDbType.VarChar).Value = std.Mkad_km;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка добавления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для изменения в таблице мкад 
        * Формальные параметры:
        * std - переменные для заглушек;
        * id - номер строки для изменения.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void UpdateMkad(MkadSQL std, string id)
        {
            string sql = "UPDATE mkad SET taking = @taking, setting = @setting, mkad_km=@mkad_km WHERE id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@taking", MySqlDbType.VarChar).Value = std.Taking;
            cmd.Parameters.Add("@setting", MySqlDbType.VarChar).Value = std.Setting;
            cmd.Parameters.Add("@mkad_km", MySqlDbType.VarChar).Value = std.Mkad_km;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно обновлено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка обновления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для удаления в таблице мкад 
        * Формальные параметры:
        * id - номер строки для изменения.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void DeleteMkad(string id)
        {
            string sql = "DELETE FROM mkad WHERE id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно удалено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка удаления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для добавления в таблице авто 
        * Формальные параметры:
        * std - переменные для заглушек.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void AddAuto(AutoSQL std)
        {

            string sql = "INSERT INTO auto (DateDel, TypeCon, NumCon, id_client, Adress, Zpu, HoursPause, id_mkad1, OptAdress, OverLoad, Expe, DateOplata, id_drivers) " +
                "VALUES (@DateDel, @TypeCon, @NumCon, @id_client, @Adress, @Zpu, @HoursPause, @id_mkad, @OptAdress, @OverLoad, @Expe, @DateOplata, @id_drivers)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@DateDel", MySqlDbType.VarChar).Value = std.DateDel;
            cmd.Parameters.Add("@TypeCon", MySqlDbType.VarChar).Value = std.TypeDel;
            cmd.Parameters.Add("@NumCon", MySqlDbType.VarChar).Value = std.NumCon;
            cmd.Parameters.Add("@id_client", MySqlDbType.VarChar).Value = std.Id_client;
            cmd.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = std.Adress;
            cmd.Parameters.Add("@Zpu", MySqlDbType.VarChar).Value = std.Zpu;
            cmd.Parameters.Add("@HoursPause", MySqlDbType.VarChar).Value = std.HoursPause;
            cmd.Parameters.Add("@id_mkad", MySqlDbType.VarChar).Value = std.Id_mkad;
            cmd.Parameters.Add("@OptAdress", MySqlDbType.VarChar).Value = std.OptAdress;
            cmd.Parameters.Add("@OverLoad", MySqlDbType.VarChar).Value = std.OverLoad;
            cmd.Parameters.Add("@Expe", MySqlDbType.VarChar).Value = std.Expe;
            cmd.Parameters.Add("@DateOplata", MySqlDbType.VarChar).Value = std.DateOplata;
            cmd.Parameters.Add("@id_drivers", MySqlDbType.VarChar).Value = std.Id_drivers;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка добавления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для изменения в таблице авто 
        * Формальные параметры:
        * std - переменные для заглушек;
        * id - номер строки для изменения.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void UpdateAuto(AutoSQL std, string id)
        {
            string sql = "UPDATE auto SET DateDel = @DateDel, TypeCon = @TypeCon, NumCon = @NumCon, id_client = @id_client, Adress = @Adress, Zpu = @Zpu, HoursPause = @HoursPause, id_mkad1 = @id_mkad, OptAdress = @OptAdress, OverLoad = @OverLoad, Expe = @Expe, DateOplata = @DateOplata, id_drivers = @id_drivers WHERE id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@DateDel", MySqlDbType.VarChar).Value = std.DateDel;
            cmd.Parameters.Add("@TypeCon", MySqlDbType.VarChar).Value = std.TypeDel;
            cmd.Parameters.Add("@NumCon", MySqlDbType.VarChar).Value = std.NumCon;
            cmd.Parameters.Add("@id_client", MySqlDbType.VarChar).Value = std.Id_client;
            cmd.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = std.Adress;
            cmd.Parameters.Add("@Zpu", MySqlDbType.VarChar).Value = std.Zpu;
            cmd.Parameters.Add("@HoursPause", MySqlDbType.VarChar).Value = std.HoursPause;
            cmd.Parameters.Add("@id_mkad", MySqlDbType.VarChar).Value = std.Id_mkad;
            cmd.Parameters.Add("@OptAdress", MySqlDbType.VarChar).Value = std.OptAdress;
            cmd.Parameters.Add("@OverLoad", MySqlDbType.VarChar).Value = std.OverLoad;
            cmd.Parameters.Add("@Expe", MySqlDbType.VarChar).Value = std.Expe;
            cmd.Parameters.Add("@DateOplata", MySqlDbType.VarChar).Value = std.DateOplata;
            cmd.Parameters.Add("@id_drivers", MySqlDbType.VarChar).Value = std.Id_drivers;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно обновлено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка обновления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для удаления в таблице авто
        * Формальные параметры:
        * id - номер строки для изменения.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void DeleteAuto(string id)
        {
            string sql = "DELETE FROM auto WHERE id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно удалено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка удаления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для добавления в таблице водители 
        * Формальные параметры:
        * std - переменные для заглушек.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void AddDr(DrSQL std)
        {

            string sql = "INSERT INTO drivers (NameD) VALUES (@NameD);";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NameD", MySqlDbType.VarChar).Value = std.NameD;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка добавления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для изменения в таблице водители 
        * Формальные параметры:
        * std - переменные для заглушек;
        * id - номер строки для изменения.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void UpdateDr(DrSQL std, string id)
        {
            string sql = "UPDATE drivers SET NameD = @NameD WHERE id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NameD", MySqlDbType.VarChar).Value = std.NameD;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно обновлено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка обновления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /*Функция для удаления в таблице водители 
        * Формальные параметры:
        * id - номер строки для изменения.
        * Локальные переменные:
        * sql - строка запроса;
        * con - подключение к бд;
        * cmd - запрос с подключение к бд.
        */
        public static void DeleteDr(string id)
        {
            string sql = "DELETE FROM drivers WHERE id = @ID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно удалено", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка удаления /n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
