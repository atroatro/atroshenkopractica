namespace АтрошенкоШвейнаяФабрика
{
    partial class FormRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.famLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.otchLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.tbxlogin = new System.Windows.Forms.TextBox();
            this.tbxpass = new System.Windows.Forms.TextBox();
            this.tbxfam = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.tbxotch = new System.Windows.Forms.TextBox();
            this.tbxphone = new System.Windows.Forms.MaskedTextBox();
            this.CbxShowPass = new System.Windows.Forms.CheckBox();
            this.atrshweinafabrika1DataSet1 = new АтрошенкоШвейнаяФабрика.atrshweinafabrika1DataSet();
            this.usersTableAdapter1 = new АтрошенкоШвейнаяФабрика.atrshweinafabrika1DataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager1 = new АтрошенкоШвейнаяФабрика.atrshweinafabrika1DataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxpassrepeat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrshweinafabrika1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(11, 121);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(77, 25);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(11, 198);
            this.passLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(92, 25);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Пароль:";
            // 
            // famLabel
            // 
            this.famLabel.AutoSize = true;
            this.famLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.famLabel.Location = new System.Drawing.Point(406, 172);
            this.famLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.famLabel.Name = "famLabel";
            this.famLabel.Size = new System.Drawing.Size(110, 25);
            this.famLabel.TabIndex = 7;
            this.famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(406, 246);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 25);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Имя:";
            // 
            // otchLabel
            // 
            this.otchLabel.AutoSize = true;
            this.otchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchLabel.Location = new System.Drawing.Point(406, 316);
            this.otchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otchLabel.Name = "otchLabel";
            this.otchLabel.Size = new System.Drawing.Size(111, 25);
            this.otchLabel.TabIndex = 11;
            this.otchLabel.Text = "Отчество:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(6, 361);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(108, 25);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Телефон:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 106);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация заказчика";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReg
            // 
            this.BtnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnReg.Location = new System.Drawing.Point(16, 410);
            this.BtnReg.Margin = new System.Windows.Forms.Padding(2);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(206, 48);
            this.BtnReg.TabIndex = 2;
            this.BtnReg.Text = "Зарегистрировать";
            this.BtnReg.UseVisualStyleBackColor = false;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.Location = new System.Drawing.Point(525, 410);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(204, 48);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tbxlogin
            // 
            this.tbxlogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUsers, "login", true));
            this.tbxlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxlogin.Location = new System.Drawing.Point(110, 118);
            this.tbxlogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxlogin.Name = "tbxlogin";
            this.tbxlogin.Size = new System.Drawing.Size(147, 31);
            this.tbxlogin.TabIndex = 4;
            // 
            // tbxpass
            // 
            this.tbxpass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUsers, "pass", true));
            this.tbxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxpass.Location = new System.Drawing.Point(118, 198);
            this.tbxpass.Margin = new System.Windows.Forms.Padding(2);
            this.tbxpass.Name = "tbxpass";
            this.tbxpass.Size = new System.Drawing.Size(142, 31);
            this.tbxpass.TabIndex = 6;
            this.tbxpass.UseSystemPasswordChar = true;
            // 
            // tbxfam
            // 
            this.tbxfam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUsers, "fam", true));
            this.tbxfam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxfam.Location = new System.Drawing.Point(553, 172);
            this.tbxfam.Margin = new System.Windows.Forms.Padding(2);
            this.tbxfam.Name = "tbxfam";
            this.tbxfam.Size = new System.Drawing.Size(123, 31);
            this.tbxfam.TabIndex = 8;
            // 
            // tbxname
            // 
            this.tbxname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUsers, "name", true));
            this.tbxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxname.Location = new System.Drawing.Point(553, 246);
            this.tbxname.Margin = new System.Windows.Forms.Padding(2);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(123, 31);
            this.tbxname.TabIndex = 10;
            // 
            // tbxotch
            // 
            this.tbxotch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUsers, "otch", true));
            this.tbxotch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxotch.Location = new System.Drawing.Point(553, 310);
            this.tbxotch.Margin = new System.Windows.Forms.Padding(2);
            this.tbxotch.Name = "tbxotch";
            this.tbxotch.Size = new System.Drawing.Size(123, 31);
            this.tbxotch.TabIndex = 12;
            // 
            // tbxphone
            // 
            this.tbxphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUsers, "phone", true));
            this.tbxphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxphone.Location = new System.Drawing.Point(118, 355);
            this.tbxphone.Margin = new System.Windows.Forms.Padding(2);
            this.tbxphone.Mask = "+0(000) 000-00-00";
            this.tbxphone.Name = "tbxphone";
            this.tbxphone.Size = new System.Drawing.Size(150, 31);
            this.tbxphone.TabIndex = 15;
            // 
            // CbxShowPass
            // 
            this.CbxShowPass.AutoSize = true;
            this.CbxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxShowPass.Location = new System.Drawing.Point(16, 263);
            this.CbxShowPass.Margin = new System.Windows.Forms.Padding(2);
            this.CbxShowPass.Name = "CbxShowPass";
            this.CbxShowPass.Size = new System.Drawing.Size(322, 29);
            this.CbxShowPass.TabIndex = 17;
            this.CbxShowPass.Text = "Показывать символы пароля";
            this.CbxShowPass.UseVisualStyleBackColor = true;
            // 
            // atrshweinafabrika1DataSet1
            // 
            this.atrshweinafabrika1DataSet1.DataSetName = "atrshweinafabrika1DataSet";
            this.atrshweinafabrika1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AccessoriesTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.FabricsTableAdapter = null;
            this.tableAdapterManager1.OrderTableAdapter = null;
            this.tableAdapterManager1.ProductsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = АтрошенкоШвейнаяФабрика.atrshweinafabrika1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = this.usersTableAdapter1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Повтор пароля:";
            // 
            // tbxpassrepeat
            // 
            this.tbxpassrepeat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsUsers, "pass", true));
            this.tbxpassrepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxpassrepeat.Location = new System.Drawing.Point(182, 307);
            this.tbxpassrepeat.Margin = new System.Windows.Forms.Padding(2);
            this.tbxpassrepeat.Name = "tbxpassrepeat";
            this.tbxpassrepeat.Size = new System.Drawing.Size(142, 31);
            this.tbxpassrepeat.TabIndex = 19;
            this.tbxpassrepeat.UseSystemPasswordChar = true;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxpassrepeat);
            this.Controls.Add(this.CbxShowPass);
            this.Controls.Add(this.tbxphone);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.otchLabel);
            this.Controls.Add(this.tbxotch);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.famLabel);
            this.Controls.Add(this.tbxfam);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.tbxpass);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.tbxlogin);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД \"Швейная фабрика\"";
            this.Load += new System.EventHandler(this.FormRegistration_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrshweinafabrika1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.BindingSource BsUsers;
        private System.Windows.Forms.TextBox tbxlogin;
        private System.Windows.Forms.TextBox tbxpass;
        private System.Windows.Forms.TextBox tbxfam;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.TextBox tbxotch;
        private System.Windows.Forms.MaskedTextBox tbxphone;
        private System.Windows.Forms.CheckBox CbxShowPass;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label famLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label otchLabel;
        private System.Windows.Forms.Label phoneLabel;
        private atrshweinafabrika1DataSet atrshweinafabrika1DataSet1;
        private atrshweinafabrika1DataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private atrshweinafabrika1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxpassrepeat;
    }
}