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
    public partial class DrAdd : Form
    {
        private readonly MainD _parent;
        public string id, NameD;

        public DrAdd(MainD Parent)
        {
            InitializeComponent();
            _parent = Parent;
        }
        public void UpdateDr()
        {
            buttonAdd.Text = "Изменить";
            TakeT.Text = NameD;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (TakeT.Text.Trim().Length < 2)
            {
                MessageBox.Show("Напишите имя");
                return;
            }

            if (buttonAdd.Text == "Добавить")
            {
                DrSQL std = new DrSQL(TakeT.Text.Trim());
                DB.AddDr(std);
                Clear();
                this.Hide();
            }
            if (buttonAdd.Text == "Изменить")
            {
                DrSQL std = new DrSQL(TakeT.Text.Trim());
                DB.UpdateDr(std, id);
                this.Hide();

            }
            _parent.Display();
        }

        public void ReturnButton()
        {
            buttonAdd.Text = "Добавить";
            TakeT.PlaceholderText = "Имя";
        }

        public void Clear()
        {
            TakeT.Text =  string.Empty;
        }

    }
}
