/*Дипломный проект по теме
*"Разработка системы учета грузоперевозок транспортной компании" 
*Разработала: Марков Николай Викторович, группа ТМП-81. Специальность: 09.02.03.
*Дата: 20.03.2021 
*Язык программирования: C#. 
*Среда разработки: MS Visual Studio 
*Задание:
*Разработать программу для хранения и обработки данных,
*для эксплуатации в отделе автомобильных перевозок,
*разработать понятный интерфейс для пользователя. 

* Краткое описание формы Main2: 
* Данная форма главное окно программы.
* Функции, используемые в модуле: 
* Main2 - инициализация компонентов формы;
* closeLabel_Click - закрытие программы;
* Header_MouseMove - реализация перемещения окна приложения при нажатие левой кнопки мыши;
* Header_MouseDown - реализация перемещения окна приложения при нажатие левой кнопки мыши;
* FullScreen_Click - открытие программы на весь экран;
* MainButton_Click - переход на главную страницу;
* ClientsMenuButton_Click - переход на страницу с клиентами;
* ButtonD_Click - переход на страницу с водителями;
* ButtonKM_Click - переход на страницу с километрами;
* ExitButton_Click - выход из аккаунта;
* Display - отображение содержимого таблицы;
* Main2_Shown - вызов функции «Display» при появлении окна;
* ReloadButton_Click - при нажатии кнопки для перезагрузки содержимого;
* buttonDelete_Click - при нажатии кнопки удаление выбранной строки из системы учета;
* Grid2_CellClick - выбор строки для действия на главной странице;
* KlientsGrid_CellClick - выбор строки для действия на странице клиентов;
* DrGrid_CellClick - выбор строки для действия на странице с водителями;
* KmGrid_CellClick - выбор строки для действия на странице «Настройка КМ»;
* SearchText_TextChanged - поиск при введении запроса;
* AddButton_Click - при нажатии кнопки добавление записи в систему учета;
* buttonChange_Click - при нажатии кнопки изменение выбранной строки.
*/

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
        ClientAdd form2;
        DrAdd form3;
        MkadAdd form4;
        int flag = 1;

        /*Функция для инициализации компонентов формы
        * Формальные параметры отсутствуют
        * Локальные переменные:
        * form - главная форма добавления;
        * form2 - форма добавления клиента;
        * form3 - форма добавления водителя;
        * form4 - форма добавления МКАДа;
        */
        public Main2()
        {
            InitializeComponent();
            form = new MainAdd(this);
            form2 = new ClientAdd(this);
            form3 = new DrAdd(this);
            form4 = new MkadAdd(this);
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

        /*Функции для смена цвета 
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Black;
        }
        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Red;
        }

        /*Функции для перемещения окна приложения при нажатие левой кнопки мыши 
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
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

        /*Функция для открытия программы на весь экран 
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
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

        /*Функции для перехода на страницу 
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void MainButton_Click(object sender, EventArgs e)
        {
            flag = 1;
            SearchText.PlaceholderText = "Поиск по 'клиент' или 'авто'";
            Display();
            MainButton.FillColor = Color.FromArgb(255, 52, 12);
            ClientsMenuButton.FillColor = ButtonD.FillColor = ButtonKM.FillColor = Color.FromArgb(245, 132, 38);
        }
        private void ClientsMenuButton_Click(object sender, EventArgs e)
        {
            SearchText.PlaceholderText = "Поиск...";
            flag = 2;
            Display();
            ClientsMenuButton.FillColor = Color.FromArgb(255, 52, 12);
            MainButton.FillColor = ButtonD.FillColor = ButtonKM.FillColor = Color.FromArgb(245, 132, 38);
        }
        private void ButtonD_Click(object sender, EventArgs e)
        {
            SearchText.PlaceholderText = "Поиск...";
            flag = 3;
            Display();
            ButtonD.FillColor = Color.FromArgb(255, 52, 12);
            ClientsMenuButton.FillColor = MainButton.FillColor = ButtonKM.FillColor = Color.FromArgb(245, 132, 38);
        }
        private void ButtonKM_Click(object sender, EventArgs e)
        {
            SearchText.PlaceholderText = "Поиск...";
            flag = 4;
            Display();
            ButtonKM.FillColor = Color.FromArgb(255, 52, 12);
            ClientsMenuButton.FillColor = MainButton.FillColor = ButtonD.FillColor = Color.FromArgb(245, 132, 38);
        }

       /*Функция для перехода на страницу 
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные:
        * form - форма авторизации;
        */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        /*Функция для отображения содержимого таблицы
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void Display()
        {
            switch (flag)
            {
                case 1:
                    KlientsGrid.Visible = DrGrid.Visible = KmGrid.Visible = false;
                    Grid2.Visible = true;
                    DB.Display("SELECT auto.id,auto.DateDel, auto.TypeCon, auto.NumCon, clients.Name, auto.Adress,IF(auto.TypeCon = 20, clients.Stavka20, clients.Stavka40), auto.Zpu, auto.HoursPause,IF(auto.HoursPause = 0, 0, clients.Cost_downtime), mkad.taking, mkad.setting,auto.OptAdress, auto.OverLoad, auto.Expe, mkad.mkad_km+auto.adress,clients.Cost_mkad, drivers.NameD, auto.DateOplata,IF(auto.TypeCon = 20, clients.Stavka20, clients.Stavka40) + auto.Zpu + auto.HoursPause * IF(auto.HoursPause = 0, 0, clients.Cost_downtime) + auto.OptAdress + auto.OverLoad + auto.Expe + (mkad.mkad_km+auto.adress) * clients.Cost_mkad As Total FROM auto, clients, mkad, drivers WHERE auto.id_client = clients.id AND auto.id_mkad1 = mkad.id AND auto.id_drivers = drivers.id ORDER BY auto.DateDel ASC;", Grid2);
                    break;
                case 2:
                    DB.Display("SELECT id,Name,Cost_downtime,Cost_mkad, Stavka20, Stavka40 FROM clients ORDER BY Name ASC", KlientsGrid);
                    KlientsGrid.Visible = true;
                    Grid2.Visible = DrGrid.Visible = KmGrid.Visible = false;
                    break;
                case 3:
                    DrGrid.Visible = true;
                    Grid2.Visible = KlientsGrid.Visible = KmGrid.Visible = false;
                    DB.Display("SELECT  id,NameD from drivers ORDER BY NameD ASC", DrGrid);
                    break;
                case 4:
                    KmGrid.Visible = true;
                    Grid2.Visible = KlientsGrid.Visible = DrGrid.Visible = false;
                    DB.Display("SELECT id,taking,setting,mkad_km FROM mkad ORDER BY taking ASC", KmGrid);
                    break;
            }
              }

        /*Функция для вызова функции Display при появлении окна
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void Main2_Shown(object sender, EventArgs e)
        {
            Display();
            
        }

        /*Функция для перезагрузки содержимого
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void ReloadButton_Click(object sender, EventArgs e)
        {
            Display();
        }

        DataGridViewRow row = new DataGridViewRow();
        DataGridViewRow row2 = new DataGridViewRow();
        DataGridViewRow row3 = new DataGridViewRow();
        DataGridViewRow row4 = new DataGridViewRow();

        /*Функция для удаления выбранной строки из системы учета
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                //Main
                case 1:
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
                    //Client
                case 2:
                    if (row2.Index != -1)
                    {
                        if (MessageBox.Show("Действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            DB.DeleteClient(row2.Cells[0].Value.ToString());
                            Display();
                        }

                    }
                    else MessageBox.Show("Вы не выбрали элемент для удаления!");
                    return;
                    //Dr
                case 3:
                    if (row3.Index != -1)
                    {
                        if (MessageBox.Show("Действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            DB.DeleteDr(row3.Cells[0].Value.ToString());
                            Display();
                        }

                    }
                    else MessageBox.Show("Вы не выбрали элемент для удаления!");
                    return;
                case 4:
                    if (row4.Index != -1)
                    {
                        if (MessageBox.Show("Действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            DB.DeleteMkad(row4.Cells[0].Value.ToString());
                            Display();
                        }

                    }
                    else MessageBox.Show("Вы не выбрали элемент для удаления!");
                    return;
            }
            
        }

        /*Функции для выбора строки под действие 
        * Формальные параметры:
        * sender - объект который вызвал данное событие;
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void Grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = Grid2.Rows[e.RowIndex];
            }
        }
        private void KlientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row2 = KlientsGrid.Rows[e.RowIndex];
            }
        }
        private void DrGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row3 = DrGrid.Rows[e.RowIndex];
            }
        }
        private void KmGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row4 = KmGrid.Rows[e.RowIndex];
            }
        }

        /*Функция для поиска при введении запроса
        * Формальные параметры:
        * sender - объект который вызвал данное событие;
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
                    DB.Display("SELECT auto.id, auto.DateDel, auto.TypeCon, auto.NumCon, clients.Name, auto.Adress,IF(auto.TypeCon = 20, clients.Stavka20, clients.Stavka40), auto.Zpu, auto.HoursPause,IF(auto.HoursPause = 0, 0, clients.Cost_downtime), mkad.taking, mkad.setting,auto.OptAdress, auto.OverLoad, auto.Expe, mkad.mkad_km+auto.adress,clients.Cost_mkad, drivers.NameD, auto.DateOplata,IF(auto.TypeCon = 20, clients.Stavka20, clients.Stavka40) + auto.Zpu + auto.HoursPause * IF(auto.HoursPause = 0, 0, clients.Cost_downtime) + auto.OptAdress + auto.OverLoad + auto.Expe + (mkad.mkad_km+auto.adress) * clients.Cost_mkad As Total FROM auto, clients, mkad, drivers WHERE auto.id_client = clients.id AND auto.id_mkad1 = mkad.id AND auto.id_drivers = drivers.id AND (clients.Name LIKE'%" + SearchText.Text + "%' OR drivers.NameD LIKE'%" + SearchText.Text + "%') ORDER BY auto.DateDel ASC;", Grid2);
                    break;
                case 2:
                    DB.Display("SELECT id,Name,Cost_downtime,Cost_mkad, Stavka20, Stavka40 FROM clients WHERE Name LIKE'%" + SearchText.Text + "%'", KlientsGrid);
                    break;
                case 3:
                    DB.Display("SELECT id, NameD FROM drivers WHERE NameD LIKE'%" + SearchText.Text + "%'", DrGrid);
                    break;
                case 4:
                    DB.Display("SELECT id,taking,setting,mkad_km FROM mkad WHERE taking LIKE'%" + SearchText.Text + "%' OR setting LIKE'%" + SearchText.Text + "%'", KmGrid);
                    break;
            }
        }

        /*Функция для добавления записи в систему учета
        * Формальные параметры:
        * sender - объект который вызвал данное событие;
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void AddButton_Click(object sender, EventArgs e)
        {

            switch (flag)
            {
                case 1:
                    form.Clear();
                    form.ReturnButton();
                    form.ShowDialog();
                    break;
                case 2:
                    form2.Clear();
                    form2.ReturnButton();
                    form2.ShowDialog();
                    break;
                case 3:
                    form3.Clear();
                    form3.ReturnButton();
                    form3.ShowDialog();
                    break;
                case 4:
                    form4.Clear();
                    form4.ReturnButton();
                    form4.ShowDialog();
                    break;
            }

        }

        /*Функция для изменения выбранной строки
        * Формальные параметры:
        * sender - объект который вызвал данное событие;
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void buttonChange_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
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
                            form.id_client = row.Cells[4].Value.ToString();
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
                    break;
                case 2:
                    if (row2.Index != -1)
                    {
                        if (MessageBox.Show("Действительно хотите изменить?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            form2.Clear();
                            form2.id = row2.Cells[0].Value.ToString();
                            form2.name = row2.Cells[1].Value.ToString();
                            form2.cost_downtime = row2.Cells[2].Value.ToString();
                            form2.cost_mkad = row2.Cells[3].Value.ToString();
                            form2.stavka20 = row2.Cells[4].Value.ToString();
                            form2.stavka40 = row2.Cells[5].Value.ToString();
                            form2.UpdateClient();
                            form2.ShowDialog();
                            Display();
                        }

                    }
                    else MessageBox.Show("Вы не выбрали элемент для изменения!");
                    break;
                case 3:
                    if (row3.Index != -1)
                    {
                        if (MessageBox.Show("Действительно хотите изменить?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            form3.Clear();
                            form3.id = row3.Cells[0].Value.ToString();
                            form3.NameD = row3.Cells[1].Value.ToString();
                            form3.UpdateDr();
                            form3.ShowDialog();
                            Display();
                        }
                    }
                    else MessageBox.Show("Вы не выбрали элемент для изменения!"); ;
                    break;
                case 4:
                    if (row4.Index != -1)
                    {
                        if (MessageBox.Show("Действительно хотите изменить?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            form4.Clear();
                            form4.id = row4.Cells[0].Value.ToString();
                            form4.taking = row4.Cells[1].Value.ToString();
                            form4.setting = row4.Cells[2].Value.ToString();
                            form4.mkad_km = row4.Cells[3].Value.ToString();
                            form4.UpdateMkad();
                            form4.ShowDialog();
                            Display();
                        }
                    }
                    else MessageBox.Show("Вы не выбрали элемент для изменения!");
                    break;
            }
        }
    }
}
