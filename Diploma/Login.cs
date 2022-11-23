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
        public Login()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

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


        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Red;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string LoginUser = LoginF.Text;
            string PassUser = PassF.Text;

            SQL db = new SQL();

            DataTable users = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand login = new MySqlCommand("SELECT * FROM users WHERE login = @ul AND pass = @up;", db.get());
            login.Parameters.Add("@ul", MySqlDbType.VarChar).Value = LoginUser;
            login.Parameters.Add("@up", MySqlDbType.VarChar).Value = PassUser;
            adapter.SelectCommand = login;
            adapter.Fill(users);

            if (users.Rows.Count > 0)
            {
                this.Hide();
                Main2 Main2 = new Main2();
                Main2.Show();
            }
            else error.Visible=true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main2 Main2 = new Main2();
            Main2.Show();
        }
    }
    
}
