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
    public partial class MkadAdd : Form
    {
        private readonly MainKM _parent;
        public string id, taking, setting, mkad_km;

        

        public MkadAdd(MainKM Parent)
        {
            InitializeComponent();
            _parent = Parent;
        }
        public void UpdateMkad()
        {
            buttonAdd.Text = "Изменить";
            TakeT.Text = taking;
            SetT.Text = setting;
            MkadT.Text = mkad_km;
        }
        public void ReturnButton()
        {
            buttonAdd.Text = "Добавить";
            TakeT.PlaceholderText = "Снятие";
            SetT.PlaceholderText = "Постановка";
            MkadT.PlaceholderText = "Мкад в км.";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (TakeT.Text.Trim().Length < 2)
            {
                MessageBox.Show("Напишите снятие");
                return;
            }

            if (SetT.Text.Trim().Length < 2)
            {
                MessageBox.Show("Напишите постановку");
                return;
            }
            if (MkadT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Напишите расстояние по Мкад");
                return;
            }
            if (buttonAdd.Text == "Добавить")
            {
                MkadSQL std = new MkadSQL(TakeT.Text.Trim(), SetT.Text.Trim(), MkadT.Text.Trim());
                DB.AddMkad(std);
                Clear();
                this.Hide();
            }
            if (buttonAdd.Text == "Изменить")
            {
                MkadSQL std = new MkadSQL(TakeT.Text.Trim(), SetT.Text.Trim(), MkadT.Text.Trim());
                DB.UpdateMkad(std, id);
                this.Hide();

            }
            _parent.Display();
        }

        public void Clear()
        {
            TakeT.Text = SetT.Text = MkadT.Text = string.Empty;
        }

        
    }
}
