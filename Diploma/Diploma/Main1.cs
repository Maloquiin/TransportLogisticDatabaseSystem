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
    public partial class Main1 : Form
    {
        ClientAdd form;
        public Main1()
        {
            InitializeComponent();
            form = new ClientAdd(this);
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
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        public void Display()
        {
            DB.Display("SELECT id,Name,Cost_downtime,Cost_mkad, Stavka20, Stavka40 FROM clients", KlientsGrid);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ReturnButton();
            form.ShowDialog();

        }

        private void Main1_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            DB.Display("SELECT id,Name,Cost_downtime,Cost_mkad, Stavka20, Stavka40 FROM clients WHERE Name LIKE'%" + SearchText.Text +"%'", KlientsGrid);
        }
        DataGridViewRow row = new DataGridViewRow();
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (row.Index != -1)
            {
                if (MessageBox.Show("Действительно хотите изменить?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                
                form.Clear();
                form.id = row.Cells[0].Value.ToString();
                form.name = row.Cells[1].Value.ToString();
                form.cost_downtime = row.Cells[2].Value.ToString();
                form.cost_mkad = row.Cells[3].Value.ToString();
                form.stavka20 = row.Cells[4].Value.ToString();
                form.stavka40 = row.Cells[5].Value.ToString();
                form.UpdateClient();
                form.ShowDialog();
                Display();
                }
                
            }
            else MessageBox.Show("Вы не выбрали элемент для изменения!");
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (row.Index != -1)
            {
                if (MessageBox.Show("Действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                
                DB.DeleteClient(row.Cells[0].Value.ToString());
                Display();
                }
                
            }
            else MessageBox.Show("Вы не выбрали элемент для удаления!");
            return;
        }

        private void KlientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = KlientsGrid.Rows[e.RowIndex];
            }
            }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            Display();
        }
        
        private void ButtonKM_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainKM form = new MainKM();
            form.Show();
        }

        private void OwnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main2 Main2 = new Main2();
            Main2.Show();
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainD MainD = new MainD();
            MainD.Show();
        }

        private void KlientsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
