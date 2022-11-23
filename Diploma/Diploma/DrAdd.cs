/* 
* Краткое описание формы DrAdd: 
* Данная форма отвечает за добавления новой записи в таблицу «drivers».
* Функции, используемые в форме: 
* DrAdd(Main2 Parent) - инициализация компонентов формы родителя;
* UpdateDr - изменение содержимого окна при нажатии кнопки «Изменить» в родительском окне;
* buttonAdd_Click - добавление записи при нажатии кнопки «Добавить»;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma
{
    public partial class DrAdd : Form
    {
        private readonly Main2 _parent;
        public string id, NameD;

        /*Функция для инициализации компонентов формы родителя
        * Формальные параметры:
        * Main2 - форма;
        * Локальные переменные отсутствуют
        */
        public DrAdd(Main2 Parent)
        {
            InitializeComponent();
            _parent = Parent;
        }

        /*Функция для изменение содержимого окна 
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void UpdateDr()
        {
            buttonAdd.Text = "Изменить";
            TakeT.Text = NameD;
        }

        /*Функция для добавления записи при нажатии кнопки «Добавить»
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
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

        /*Функция для возращения исходного содержимого окна
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void ReturnButton()
        {
            buttonAdd.Text = "Добавить";
            TakeT.PlaceholderText = "Имя";
        }

       /*Функция для очистки данных их полей ввода
       * Формальные параметры отсутствуют
       * Локальные переменные отсутствуют
       */
        public void Clear()
        {
            TakeT.Text =  string.Empty;
        }
    }
}
