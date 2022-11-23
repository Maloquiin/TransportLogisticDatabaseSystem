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
    public partial class Main2 : Form
    {
        MainAdd form;
        public Main2()
        {
            InitializeComponent();
            form = new MainAdd(this);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Black;
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Red;
        }

        Point lastPoint;
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ClientsMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main1 form = new Main1();
            form.Show();
        }

        private void ButtonKM_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainKM form = new MainKM();
            form.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        public void Display()
        {
            DB.Display("SELECT auto.id, auto.DateDel, auto.TypeCon, auto.NumCon, clients.Name, auto.Adress,IF(auto.TypeCon = 20, clients.Stavka20, clients.Stavka40), auto.Zpu, auto.HoursPause,IF(auto.HoursPause = 0, 0, clients.Cost_downtime), mkad.taking, mkad.setting,auto.OptAdress, auto.OverLoad, auto.Expe, mkad.mkad_km,clients.Cost_mkad, drivers.NameD, auto.DateOplata,IF(auto.TypeCon = 20, clients.Stavka20, clients.Stavka40) + auto.Zpu + auto.HoursPause * IF(auto.HoursPause = 0, 0, clients.Cost_downtime) + auto.OptAdress + auto.OverLoad + auto.Expe + mkad.mkad_km * clients.Cost_mkad As Total FROM auto, clients, mkad, drivers WHERE auto.id_client = clients.id AND auto.id_mkad = mkad.id AND auto.id_drivers = drivers.id; ", Grid2);
        }

        private void Main2_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            Display();
        }
        DataGridViewRow row = new DataGridViewRow();
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (row.Index != -1)
            {
                if (MessageBox.Show("Действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    DB.DeleteAuto(row.Cells[0].Value.ToString());
                    Display();
                }

            }
            else MessageBox.Show("Вы не выбрали элемент для удаления!");
            return;
        }

        private void Grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = Grid2.Rows[e.RowIndex];
            }
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DB.Display("SELECT auto.id, auto.DateDel, auto.TypeCon, auto.NumCon, clients.Name, auto.Adress,IF(auto.TypeCon = 20, clients.Stavka20, clients.Stavka40), auto.Zpu, auto.HoursPause,IF(auto.HoursPause = 0, 0, clients.Cost_downtime), mkad.taking, mkad.setting,auto.OptAdress, auto.OverLoad, auto.Expe, mkad.mkad_km,clients.Cost_mkad, drivers.NameD, auto.DateOplata,IF(auto.TypeCon = 20, clients.Stavka20, clients.Stavka40) + auto.Zpu + auto.HoursPause * IF(auto.HoursPause = 0, 0, clients.Cost_downtime) + auto.OptAdress + auto.OverLoad + auto.Expe + mkad.mkad_km * clients.Cost_mkad As Total FROM auto, clients, mkad, drivers WHERE auto.id_client = clients.id AND auto.id_mkad = mkad.id AND auto.id_drivers = drivers.id AND (clients.Name LIKE'%" + SearchText.Text + "%' OR drivers.NameD LIKE'%" + SearchText.Text + "%')", Grid2);
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainD MainD = new MainD();
            MainD.Show();
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ReturnButton();
            form.ShowDialog();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (row.Index != -1)
            {
                if (MessageBox.Show("Действительно хотите изменить?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    form.Display1();
                    form.Clear();
                    form.id = row.Cells[0].Value.ToString();
                    form.Date = row.Cells[1].Value.ToString();
                    form.TypeCon = row.Cells[2].Value.ToString();
                    form.NumCon = row.Cells[3].Value.ToString();
                    form.id_client =row.Cells[4].Value.ToString();
                    form.adress = row.Cells[5].Value.ToString();
                    form.zpu = row.Cells[7].Value.ToString();
                    form.hoursPause = row.Cells[8].Value.ToString();
                    form.id_mkad = row.Cells[10].Value.ToString();
                    form.optAdress = row.Cells[12].Value.ToString();
                    form.overLoad = row.Cells[13].Value.ToString();
                    form.expe = row.Cells[14].Value.ToString();
                    form.dateOplata = row.Cells[18].Value.ToString();
                    form.id_drivers = row.Cells[17].Value.ToString();
                    form.UpdateMain();
                    form.ShowDialog();
                    Display();
                }
            }
            else MessageBox.Show("Вы не выбрали элемент для изменения!");
        }
    }
}
