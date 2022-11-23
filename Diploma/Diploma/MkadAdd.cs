/* 
* Краткое описание формы MkadAdd: 
* Данная форма отвечает за добавления новой записи в таблицу «mkad».
* Функции, используемые в форме: 
* mkadAdd(Main2 Parent) - инициализация компонентов формы родителя;
* UpdateMkad - изменение содержимого окна при нажатии кнопки «Изменить» в родительском окне;
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
    public partial class MkadAdd : Form
    {
        private readonly Main2 _parent;
        public string id, taking,setting, mkad_km;

        /*Функция для инициализации компонентов формы родителя
        * Формальные параметры:
        * Main2 - форма;
        * Локальные переменные отсутствуют
        */
        public MkadAdd(Main2 Parent)
        {
            InitializeComponent();
            _parent = Parent;
        }

        /*Функция для изменение содержимого окна 
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void UpdateMkad()
        {
            buttonAdd.Text = "Изменить";
            TakeT.Text = taking;
            SetT.Text = setting;
            MkadT.Text = mkad_km;
        }


        /*Функция для добавления записи при нажатии кнопки «Добавить»
        * Формальные параметры:
        * sender - объект который вызвал данное событие; 
        * e - используются для передачи парамеров вызова метода;
        * Локальные переменные отсутствуют
        */
        private void buttonAdd_Click_1(object sender, EventArgs e)
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

        /*Функция для возращения исходного содержимого окна
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void ReturnButton()
        {
            buttonAdd.Text = "Добавить";
            TakeT.PlaceholderText = "Снятие";
            SetT.PlaceholderText = "Постановка";
            MkadT.PlaceholderText = "Мкад в км.";
        }

       /*Функция для очистки данных их полей ввода
       * Формальные параметры отсутствуют
       * Локальные переменные отсутствуют
       */
        public void Clear()
        {
            TakeT.Text = SetT.Text = MkadT.Text = string.Empty;
        }
    }
}
