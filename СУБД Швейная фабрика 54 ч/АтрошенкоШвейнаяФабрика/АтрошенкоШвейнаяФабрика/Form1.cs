using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АтрошенкоШвейнаяФабрика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        string GetCapcha()
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digit = "0123456789";
            string t1 = letters + digit;
            string capcha = "";
            bool FlagDigit = false;
            Random rnd = new Random();

            for (int i = 1; i <= 3; i++)
            {
                // взять символ из строки с символами для капчи
                char sim = t1[rnd.Next(t1.Length)];
                // если символ - цифра, запомнить это
                if (char.IsDigit(sim)) FlagDigit = true;
                capcha += sim;  // добавить символ к капче
            }
            if (FlagDigit == false)
                capcha += digit[rnd.Next(digit.Length)];
            else
                capcha += letters[rnd.Next(letters.Length)];

            return capcha;
        }
        private void BtnVhod_Click(object sender, EventArgs e)
        {

            // роль пользователя (считывается из ComboBox)
            string role = CmbRole.SelectedItem.ToString();
            // фильтр для таблицы Пользователи
            string TxtFilter = String.Format("login = '{0}' and pass = '{1}' and role = '{2}'", TbxLogin.Text, TbxPass.Text, role);
            // логин для передачи на рабочее место
            string TxtFilterForUser = string.Format("login = '{0}'", TbxLogin.Text);
            BsUsers.Filter = TxtFilter;  // включить фильтр

            if (BsUsers.Count == 0)
            {
                MessageBox.Show(String.Format("Нет пользователя '{0}' с указанным логином и паролем!", role));
                return;
            }

            TbxLogin.Clear(); TbxPass.Clear(); // очистить поля
            this.Visible = false;  // скрыть форму для авторизации

            if (role == "заказчик")
            {
                //// создать форму для заказчика
                //FormZakazchik frm = new FormZakazchik();
                //// отфильтровать авторизовавшегося пользователя
                //frm.BsUsers.Filter = TxtFilterForUser;
                //frm.ShowDialog();
            }

            if (role == "менеджер")
            {
                //// создать форму для менеджера
                //FormManager frm = new FormManager();
                //// отфильтровать авторизовавшегося пользователя
                //frm.BsUsers.Filter = TxtFilterForUser;
                //frm.ShowDialog();
            }

            if (role == "кладовщик")
            {
                // создать форму для кладовщика
                //FormKladovschik frm = new FormKladovschik();
                //// отфильтровать авторизовавшегося пользователя
                //frm.BsUsers.Filter = TxtFilterForUser;
                //frm.ShowDialog();
            }

            //this.Visible = true;  // показать форму для авторизации
            //// загрузить обновленные записи из БД
            //this.usersTableAdapter.Fill(this.fab2021DataSet1.Users);
            //TbxLogin.Focus();
            //TbxCapcha.Clear();
            //LblCapcha.Text = GetCapcha();
        }

        /// <summary>
        /// Скрыть/показать пароль
        /// </summary>
        private void CbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            TbxPass.UseSystemPasswordChar = !TbxPass.UseSystemPasswordChar;
        }

        /// <summary>
        /// Изображение случайных линий поверх капчи
        /// </summary>
        private void LblCapcha_Paint(object sender, PaintEventArgs e)
        {
            // массив цветов
            Color[] colors = { Color.Green, Color.Black, Color.Yellow, Color.White };
            Random rnd = new Random();
            // изобразить от 5 до 10 линий
            for (int i = 1; i <= rnd.Next(5, 11); i++)
            {
                // координаты начала и конца отрезка
                int x1 = rnd.Next(LblCapcha.Width);
                int y1 = rnd.Next(LblCapcha.Height);
                int x2 = rnd.Next(LblCapcha.Width);
                int y2 = rnd.Next(LblCapcha.Height);
                // случайный цвет из массива цветов
                Color col = colors[rnd.Next(colors.Length)];
                // нарисовать линию на метке Label
                e.Graphics.DrawLine(new Pen(col), x1, y1, x2, y2);
            }
        }

        private void LblReg_Click(object sender, EventArgs e)
        {
            FormRegistration frm = new FormRegistration();
            if (frm.ShowDialog() == DialogResult.OK)
               this.usersTableAdapter.Fill(this.atrshweinafabrika1DataSet.Users);
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atrshweinafabrika1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atrshweinafabrika1DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.atrshweinafabrika1DataSet.Users);

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'atrshweinafabrika1DataSet.Users' table. You can move, or remove it, as needed.
        //    this.usersTableAdapter.Fill(this.atrshweinafabrika1DataSet.Users);
        //    CmbRole.SelectedIndex = 0;

        //    LblCapcha.Text = GetCapcha();
        //}


    }
}
