using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma
{
    public partial class MainAdd : Form
    {
        private readonly Main2 _parent;
        public string id,Date,TypeCon, NumCon, id_client, adress, zpu, hoursPause, id_mkad, optAdress, overLoad, expe, id_drivers, dateOplata;

        private void DrGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_driversT.Text = DrGrid[0, e.RowIndex].Value.ToString();
        }

        private void MkadGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id_mkadT.Text = MkadGrid[0, e.RowIndex].Value.ToString();
        }

        private void KlientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_clientT.Text = KlientsGrid[0, e.RowIndex].Value.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(DateT.Text, @"([1950-2050]{4,4})-([1-12]{1,2})-([1-31]{1,2})", RegexOptions.IgnoreCase)))
            {
                MessageBox.Show("Правильный формат yyyy-mm-dd");
                return;
            }
            if (!(TypeConT.Text=="20" || TypeConT.Text == "40"))
            {
                MessageBox.Show("Введите тип контейнера (20/40)");
                return;
            }
            if (NumConT.Text == "")
            {
                MessageBox.Show("Введите номер контейнера");
                return;
            }
            if (!(Regex.IsMatch(id_clientT.Text, @"\d", RegexOptions.IgnoreCase)))
            {
                
                MessageBox.Show("Введите ID клиента");
                return;
            }
            if (!(Regex.IsMatch(id_mkadT.Text, @"\d", RegexOptions.IgnoreCase)))
            {

                MessageBox.Show("Введите ID назначения");
                return;
            }
            if (!(Regex.IsMatch(id_driversT.Text, @"\d", RegexOptions.IgnoreCase)))
            {

                MessageBox.Show("Введите ID водителя");
                return;
            }
            if (!(Regex.IsMatch(zpuT.Text, @"\d", RegexOptions.IgnoreCase) || zpuT.Text == ""))
            {

                MessageBox.Show("Введите значение (ЗПУ)");
                return;
            }
            if (!(Regex.IsMatch(hoursPauseT.Text, @"\d", RegexOptions.IgnoreCase) || hoursPauseT.Text==""))
            {

                MessageBox.Show("Введите значение (Часы простоя)");
                return;
            }
            if (!(Regex.IsMatch(optAdressT.Text, @"\d", RegexOptions.IgnoreCase) || optAdressT.Text == ""))
            {

                MessageBox.Show("Введите значение (Дополнительно)");
                return;
            }
            if (!(Regex.IsMatch(overLoadT.Text, @"\d", RegexOptions.IgnoreCase) || overLoadT.Text == ""))
            {

                MessageBox.Show("Введите значение (Перегруз)");
                return;
            }
            if (!(Regex.IsMatch(expeT.Text, @"\d", RegexOptions.IgnoreCase) || expeT.Text == ""))
            {

                MessageBox.Show("Введите значение (Экспедиция)");
                return;
            }

            if (buttonAdd.Text == "Добавить")
            {
                AutoSQL std = new AutoSQL(DateT.Text.Trim(), TypeConT.Text.Trim(), NumConT.Text.Trim(), id_clientT.Text.Trim(), adressT.Text.Trim(), zpuT.Text.Trim(), hoursPauseT.Text.Trim(), id_mkadT.Text.Trim(), optAdressT.Text.Trim(), overLoadT.Text.Trim(), expeT.Text.Trim(), dateOplataT.Text.Trim(), id_driversT.Text.Trim());
                DB.AddAuto(std);
                Clear();
                this.Hide();
            }
            if (buttonAdd.Text == "Изменить")
            {
                AutoSQL std = new AutoSQL(DateT.Text.Trim(), TypeConT.Text.Trim(), NumConT.Text.Trim(), id_clientT.Text.Trim(), adressT.Text.Trim(), zpuT.Text.Trim(), hoursPauseT.Text.Trim(), id_mkadT.Text.Trim(), optAdressT.Text.Trim(), overLoadT.Text.Trim(), expeT.Text.Trim(), dateOplataT.Text.Trim(), id_driversT.Text.Trim());
                DB.UpdateAuto(std, id);
                this.Hide();

            }
            _parent.Display();
        }

        public MainAdd(Main2 Parent)
        {
            InitializeComponent();
            _parent = Parent;
        }

        private void MainAdd_Shown(object sender, EventArgs e)
        {
            Display1();
        }

        public void Display1()
        {
            DB.Display("SELECT id,Name FROM clients", KlientsGrid);
            DB.Display("SELECT id,taking,setting,mkad_km FROM mkad", MkadGrid);
            DB.Display("SELECT id,NameD FROM drivers", DrGrid);
        }
        public void UpdateMain()
        {
            buttonAdd.Text = "Изменить";
            DateTime D = DateTime.Parse(Date);
            DateT.Text = D.ToString("yyyy-MM-dd");
            TypeConT.Text = TypeCon;
            NumConT.Text = NumCon;
            for (int i=0;i<KlientsGrid.RowCount;i++)
            if (id_client == KlientsGrid[1, i].Value.ToString()) 
                {id_clientT.Text = KlientsGrid[0, i].Value.ToString();}
            zpuT.Text = zpu;
            hoursPauseT.Text = hoursPause;
            for (int i = 0; i < MkadGrid.RowCount; i++)
                if (id_mkad == MkadGrid[1, i].Value.ToString())
                {id_mkadT.Text = MkadGrid[0, i].Value.ToString();}
            optAdressT.Text = optAdress;
            overLoadT.Text = overLoad;
            expeT.Text = expe;
            for (int i = 0; i < DrGrid.RowCount; i++)
                if (id_drivers == DrGrid[1, i].Value.ToString())
                {id_driversT.Text = DrGrid[0, i].Value.ToString();}
            dateOplataT.Text = dateOplata;

        }
        public void ReturnButton()
        {
            buttonAdd.Text = "Добавить";
            DateT.PlaceholderText = "Дата (год-месяц-день)";
            TypeConT.PlaceholderText = "Тип Контейнера";
            NumConT.PlaceholderText = "Номер контейнера";
            id_clientT.PlaceholderText = "ID Клиента";
            adressT.PlaceholderText = "Адрес";
            zpuT.PlaceholderText = "ЗПУ";
            hoursPauseT.PlaceholderText = "Часы простоя";
            id_mkadT.PlaceholderText = "ID назначения";
            optAdressT.PlaceholderText = "Дополнительно";
            overLoadT.PlaceholderText = "Перегруз";
            expeT.PlaceholderText = "Экспедиция";
            id_driversT.PlaceholderText = "ID Водителя";
            dateOplataT.PlaceholderText = "Дата оплаты";

        }



        public void Clear()
        {
            DateT.Text = TypeConT.Text = NumConT.Text = id_clientT.Text = adressT.Text = hoursPauseT.Text = id_mkadT.Text = optAdressT.Text = overLoadT.Text = expeT.Text = id_driversT.Text = dateOplataT.Text = string.Empty;
        }
    }
}
