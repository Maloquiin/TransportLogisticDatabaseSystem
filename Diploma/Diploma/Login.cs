/* 
* Краткое описание формы Login: 
* Данная форма отвечает за авторизацию пользователя с подключением к удаленному серверу.
* Функции, используемые в форме: 
* Login - инициализация компонентов формы;
* closeLabel_Click - закрытие программы;
* PanelLogin_MouseMove - реализация перемещения окна приложения при нажатие левой кнопки мыши;
* PanelLogin_MouseDown - реализация перемещения окна приложения при нажатие левой кнопки мыши;
* LoginButton_Click - реализация авторизации с подключением к серверу для проверки входных данных.
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma
{
    public partial class Login : Form
    {

        /*Функция для инициализации компонентов формы
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public Login()
        {
            InitializeComponent();
        }

        /*Функция для закрытия программы 
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        /*Функции для перемещения окна приложения при нажатие левой кнопки мыши 
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void PanelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void PanelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void LogoPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void LogoPic_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        /*Функции для смена цвета 
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Red;
        }
        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }

        /*Функции для авторизации с подключением к серверу для проверки входных данных 
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные:
        * db - SQL;
        * users - таблица с пользователями;
        * adapter - адаптер для выполнения запроса; 
        * login - команда запроса;
        * Main2 - форма главного окна.
        */
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string LoginUser = LoginF.Text;
            string PassUser = PassF.Text;

            SQL db = new SQL();

            DataTable users = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            try
            {
            MySqlCommand login = new MySqlCommand("SELECT * FROM users WHERE login = @ul AND pass = @up;", db.get());
            login.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LoginUser;
            login.Parameters.Add("@up", MySqlDbType.VarChar).Value = PassUser;
            adapter.SelectCommand = login;
            adapter.Fill(users);
            }
            catch (Exception)
            {
                MessageBox.Show("Нет подключения к системе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (users.Rows.Count > 0)
            {
                this.Hide();
                Main2 Main2 = new Main2();
                Main2.Show();
            }
            else error.Visible=true;
        }
    }
}
