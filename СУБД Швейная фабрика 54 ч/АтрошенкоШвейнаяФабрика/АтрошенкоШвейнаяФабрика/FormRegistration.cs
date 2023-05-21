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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.usersBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.atrshweinafabrika1DataSet1);

        }

     

   

        private void FormRegistration_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atrshweinafabrika1DataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.atrshweinafabrika1DataSet1.Users);
            BsUsers.AddNew();
            //LblRole.Text = "заказчик";

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            
            try
            {
                BsUsers.EndEdit();
                this.usersTableAdapter1.Update(this.atrshweinafabrika1DataSet1.Users);
            }
            catch
            {
                MessageBox.Show(@"Логин пользователя должен быть уникальным", "Внимание!", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
                tbxlogin.Focus();
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
