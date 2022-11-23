/*
*Краткое описание формы MainAdd: 
*Данный форма содержит функции для добавления новой записи в таблицу «auto».
* Функции, используемые в форме: 
* DrGrid_CellClick - выбор строки водителя для заполнения данных;
* MkadGrid_CellClick - выбор строки МКАДа для заполнения данных;
* KlientsGrid_CellClick - выбор строки клиента для заполнения данных;
* buttonAdd_Click - добавление записи при нажатии кнопки «Добавить»;
* MainAdd(Main2 Parent) - инициализация компонентов формы родителя;
* MainAdd_Shown - отображение таблиц при появлении окна;
* Display1 - отображение таблиц из системы учета;
* UpdateMain - изменение содержимого окна при нажатии кнопки «Изменить» в родительском окне;
* ReturnButton - кнопка возращения исходного содержимого окна;
* Clear - кнопка очистки данных их полей ввода.
*/

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

        /*Функция для выбора строки водителя
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void DrGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_driversT.Text = DrGrid[0, e.RowIndex].Value.ToString();
        }

        /*Функция для выбора строки МКАДа
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void MkadGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id_mkadT.Text = MkadGrid[0, e.RowIndex].Value.ToString();
        }

        /*Функция для выбора строки клиента
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void KlientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_clientT.Text = KlientsGrid[0, e.RowIndex].Value.ToString();
        }

        /*Функция для добавление записи при нажатии кнопки «Добавить»
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные:
        * D - хранения даты;
        * success - проверка даты.
        */
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DateTime D;
            bool success = DateTime.TryParse(TimePicker.Value.ToString(), out D);
            if (!(success))
            {
                MessageBox.Show("Правильный формат dd-mm-yyyy");
                return;
            }
            if (NumConT.Text == "")
            {
                MessageBox.Show("Введите номер контейнера");
                return;
            }
            if (!(Regex.IsMatch(adressT.Text, @"\d", RegexOptions.IgnoreCase)))
            {

                MessageBox.Show("Введите адрес");
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
            if (!(Regex.IsMatch(zpuT.Text, @"\d", RegexOptions.IgnoreCase) || zpuT.Text.Trim().Length == 0))
            {

                MessageBox.Show("Введите значение (ЗПУ)");
                return;
            }
            if (!(Regex.IsMatch(hoursPauseT.Text, @"\d", RegexOptions.IgnoreCase) || hoursPauseT.Text.Trim().Length == 0))
            {

                MessageBox.Show("Введите значение (Часы простоя)");
                return;
            }
            if (!(Regex.IsMatch(optAdressT.Text, @"\d", RegexOptions.IgnoreCase) || optAdressT.Text.Trim().Length == 0))
            {

                MessageBox.Show("Введите значение (Дополнительно)");
                return;
            }
            if (!(Regex.IsMatch(overLoadT.Text, @"\d", RegexOptions.IgnoreCase) || overLoadT.Text.Trim().Length == 0))
            {

                MessageBox.Show("Введите значение (Перегруз)");
                return;
            }
            if (!(Regex.IsMatch(expeT.Text, @"\d", RegexOptions.IgnoreCase) || expeT.Text.Trim().Length == 0))
            {

                MessageBox.Show("Введите значение (Экспедиция)");
                return;
            }
            if(TogKon.Checked == false){
                TypeCon = "20";
            }
            else TypeCon = "40";

            if (buttonAdd.Text == "Добавить")
            {
                AutoSQL std = new AutoSQL(D.ToString("yyyy-MM-dd"), TypeCon, NumConT.Text.Trim(), id_clientT.Text.Trim(), adressT.Text.Trim(), zpuT.Text.Trim(), hoursPauseT.Text.Trim(), id_mkadT.Text.Trim(), optAdressT.Text.Trim(), overLoadT.Text.Trim(), expeT.Text.Trim(), dateOplataT.Text.Trim(), id_driversT.Text.Trim());
                DB.AddAuto(std);
                Clear();
                this.Hide();
            }
            if (buttonAdd.Text == "Изменить")
            {
                AutoSQL std = new AutoSQL(D.ToString("yyyy-MM-dd"), TypeCon, NumConT.Text.Trim(), id_clientT.Text.Trim(), adressT.Text.Trim(), zpuT.Text.Trim(), hoursPauseT.Text.Trim(), id_mkadT.Text.Trim(), optAdressT.Text.Trim(), overLoadT.Text.Trim(), expeT.Text.Trim(), dateOplataT.Text.Trim(), id_driversT.Text.Trim());
                DB.UpdateAuto(std, id);
                this.Hide();

            }
            _parent.Display();
        }

        /*Функция для инициализация компонентов формы родителя
        * Формальные параметры:
        * Main2 - форма;
        * Локальные переменные отсутствуют
        */
        public MainAdd(Main2 Parent)
        {
            InitializeComponent();
            _parent = Parent;
        }

        /*Функция для отображения таблиц при появлении окна
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void MainAdd_Shown(object sender, EventArgs e)
        {
            Display1();
        }

        /*Функция для отображение таблиц из системы учета
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void Display1()
        {
            DB.Display("SELECT id,Name FROM clients ORDER BY Name ASC", KlientsGrid);
            DB.Display("SELECT id,taking,setting,mkad_km FROM mkad ORDER BY taking ASC", MkadGrid);
            DB.Display("SELECT id,NameD FROM drivers ORDER BY NameD ASC", DrGrid);
        }

        /*Функция для изменения содержимого окна
        * Формальные параметры отсутствуют
        * Локальные переменные:
        * D - хранения даты.
        */
        public void UpdateMain()
        {
            dateOplataT.PlaceholderText = "Дата оплаты";
            buttonAdd.Text = "Изменить";
            DateTime D = DateTime.Parse(Date);
            TimePicker.Value = D;
            if (TypeCon == "20")
            {
                TogKon.Checked = false;
            }else TogKon.Checked = true;
            NumConT.Text = NumCon;
            adressT.Text = adress;
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
                {
                    id_driversT.Text = DrGrid[0, i].Value.ToString();}
            dateOplataT.Text = dateOplata;

        }

        /*Функция для возращения исходного содержимого окна
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void ReturnButton()
        {
            buttonAdd.Text = "Добавить";
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

        /*Функция для очистки данных их полей ввода
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void Clear()
        {
            TogKon.Checked = false;
            TypeConT.Text = NumConT.Text = id_clientT.Text = adressT.Text = hoursPauseT.Text = id_mkadT.Text = optAdressT.Text = overLoadT.Text =zpuT.Text = expeT.Text = id_driversT.Text = dateOplataT.Text = string.Empty;
        }
    }
}