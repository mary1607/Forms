namespace Talon
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_patient = new System.Windows.Forms.TextBox();
            this.txt_speciality = new System.Windows.Forms.TextBox();
            this.txt_doctor = new System.Windows.Forms.TextBox();
            this.txt_office = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Талон на прием к врачу";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Врач:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Пациент:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "ФИО:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Кабинет:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Дата:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Время:";
            // 
            // txt_patient
            // 
            this.txt_patient.Location = new System.Drawing.Point(112, 62);
            this.txt_patient.Name = "txt_patient";
            this.txt_patient.Size = new System.Drawing.Size(126, 20);
            this.txt_patient.TabIndex = 7;
            // 
            // txt_speciality
            // 
            this.txt_speciality.Location = new System.Drawing.Point(112, 111);
            this.txt_speciality.Name = "txt_speciality";
            this.txt_speciality.Size = new System.Drawing.Size(126, 20);
            this.txt_speciality.TabIndex = 8;
            // 
            // txt_doctor
            // 
            this.txt_doctor.Location = new System.Drawing.Point(112, 137);
            this.txt_doctor.Name = "txt_doctor";
            this.txt_doctor.Size = new System.Drawing.Size(126, 20);
            this.txt_doctor.TabIndex = 9;
            // 
            // txt_office
            // 
            this.txt_office.Location = new System.Drawing.Point(112, 185);
            this.txt_office.Name = "txt_office";
            this.txt_office.Size = new System.Drawing.Size(126, 20);
            this.txt_office.TabIndex = 10;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(112, 237);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(126, 20);
            this.txt_time.TabIndex = 12;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(110, 272);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(102, 22);
            this.btn_print.TabIndex = 13;
            this.btn_print.Text = "Печать";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(112, 211);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker.TabIndex = 14;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(313, 300);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_office);
            this.Controls.Add(this.txt_doctor);
            this.Controls.Add(this.txt_speciality);
            this.Controls.Add(this.txt_patient);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_patient;
        private System.Windows.Forms.TextBox txt_speciality;
        private System.Windows.Forms.TextBox txt_doctor;
        private System.Windows.Forms.TextBox txt_office;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

