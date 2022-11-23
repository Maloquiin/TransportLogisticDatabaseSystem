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
    public partial class ClientAdd : Form
    {
        private readonly Main1 _parent;
        public string id, name, cost_downtime, cost_mkad, stavka20, stavka40;
        public ClientAdd(Main1 Parent)
        {
            InitializeComponent();
            _parent = Parent;
        }


        public void UpdateClient()
        {
            buttonAdd.Text = "Изменить";
            ClientT.Text = name;
            CostdT.Text = cost_downtime;
            CostmT.Text = cost_mkad;
            Stavka20F.Text = stavka20;
            Stavka40F.Text = stavka40;
        }
        public void ReturnButton()
        {
            buttonAdd.Text = "Добавить";
            ClientT.PlaceholderText = "Клиент";
            CostdT.PlaceholderText = "Цена за простой";
            CostmT.PlaceholderText = "Цена за 1км МКАДА";
            Stavka20F.PlaceholderText = "Ставка за 20т";
            Stavka40F.PlaceholderText = "Ставка за 40т";
        }

        public void Clear()
        {
            ClientT.Text = CostdT.Text = CostmT.Text = Stavka20F.Text = Stavka40F.Text = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if(ClientT.Text.Trim().Length < 2)
            {
                MessageBox.Show("Напишите название организации");
                return;
            }

            if (CostmT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Напишите цену за 1км Мкада");
                return;
            }
            if (buttonAdd.Text == "Добавить")
            {
                ClientSQL std = new ClientSQL(ClientT.Text.Trim(), CostdT.Text.Trim(), CostmT.Text.Trim(), Stavka20F.Text.Trim(), Stavka40F.Text.Trim());
                DB.AddClient(std);
                Clear();
                this.Hide();
            }
            if (buttonAdd.Text == "Изменить")
            {
                ClientSQL std = new ClientSQL(ClientT.Text.Trim(), CostdT.Text.Trim(), CostmT.Text.Trim(), Stavka20F.Text.Trim(), Stavka40F.Text.Trim());
                DB.UpdateClient(std,id);
                this.Hide();

            }
                _parent.Display();
        }

    }
}
