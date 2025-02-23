
namespace _0._2
{
    partial class Form2
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
            this.LabelPriority = new System.Windows.Forms.Label();
            this.radioLow = new System.Windows.Forms.RadioButton();
            this.radioMedum = new System.Windows.Forms.RadioButton();
            this.radioHight = new System.Windows.Forms.RadioButton();
            this.labelCompleted = new System.Windows.Forms.Label();
            this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDedline = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelPriority
            // 
            this.LabelPriority.AutoSize = true;
            this.LabelPriority.Location = new System.Drawing.Point(12, 43);
            this.LabelPriority.Name = "LabelPriority";
            this.LabelPriority.Size = new System.Drawing.Size(63, 13);
            this.LabelPriority.TabIndex = 0;
            this.LabelPriority.Text = "Категория:";
            this.LabelPriority.Click += new System.EventHandler(this.LabelPriority_Click);
            // 
            // radioLow
            // 
            this.radioLow.AutoSize = true;
            this.radioLow.Location = new System.Drawing.Point(15, 69);
            this.radioLow.Name = "radioLow";
            this.radioLow.Size = new System.Drawing.Size(57, 17);
            this.radioLow.TabIndex = 1;
            this.radioLow.TabStop = true;
            this.radioLow.Text = "Отдых";
            this.radioLow.UseVisualStyleBackColor = true;
            this.radioLow.CheckedChanged += new System.EventHandler(this.radioLow_CheckedChanged);
            // 
            // radioMedum
            // 
            this.radioMedum.AutoSize = true;
            this.radioMedum.Location = new System.Drawing.Point(84, 69);
            this.radioMedum.Name = "radioMedum";
            this.radioMedum.Size = new System.Drawing.Size(56, 17);
            this.radioMedum.TabIndex = 2;
            this.radioMedum.TabStop = true;
            this.radioMedum.Text = "Учеба";
            this.radioMedum.UseVisualStyleBackColor = true;
            this.radioMedum.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioHight
            // 
            this.radioHight.AutoSize = true;
            this.radioHight.Location = new System.Drawing.Point(158, 69);
            this.radioHight.Name = "radioHight";
            this.radioHight.Size = new System.Drawing.Size(61, 17);
            this.radioHight.TabIndex = 3;
            this.radioHight.TabStop = true;
            this.radioHight.Text = "Работа";
            this.radioHight.UseVisualStyleBackColor = true;
            this.radioHight.CheckedChanged += new System.EventHandler(this.radioHight_CheckedChanged);
            // 
            // labelCompleted
            // 
            this.labelCompleted.AutoSize = true;
            this.labelCompleted.Location = new System.Drawing.Point(18, 345);
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(44, 13);
            this.labelCompleted.TabIndex = 4;
            this.labelCompleted.Text = "Статус:";
            this.labelCompleted.Click += new System.EventHandler(this.labelCompleted_Click);
            // 
            // checkBoxCompleted
            // 
            this.checkBoxCompleted.AutoSize = true;
            this.checkBoxCompleted.Location = new System.Drawing.Point(68, 345);
            this.checkBoxCompleted.Name = "checkBoxCompleted";
            this.checkBoxCompleted.Size = new System.Drawing.Size(112, 17);
            this.checkBoxCompleted.TabIndex = 5;
            this.checkBoxCompleted.Text = "Дело выполнено";
            this.checkBoxCompleted.UseVisualStyleBackColor = true;
            this.checkBoxCompleted.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(18, 103);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(74, 13);
            this.labelStartDate.TabIndex = 6;
            this.labelStartDate.Text = "Дата начала:";
            this.labelStartDate.Click += new System.EventHandler(this.labelStartDate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelDedline
            // 
            this.labelDedline.AutoSize = true;
            this.labelDedline.Location = new System.Drawing.Point(18, 141);
            this.labelDedline.Name = "labelDedline";
            this.labelDedline.Size = new System.Drawing.Size(105, 13);
            this.labelDedline.TabIndex = 8;
            this.labelDedline.Text = "Выберите дедлайн:";
            this.labelDedline.Click += new System.EventHandler(this.labelDedline_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 163);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 9;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(258, 13);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(399, 329);
            this.listBoxTasks.TabIndex = 10;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(180, 396);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(170, 63);
            this.buttonAddTask.TabIndex = 11;
            this.buttonAddTask.Text = "Добавить задачу!";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(55, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Дело:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "Удалить задачу!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.labelDedline);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.checkBoxCompleted);
            this.Controls.Add(this.labelCompleted);
            this.Controls.Add(this.radioHight);
            this.Controls.Add(this.radioMedum);
            this.Controls.Add(this.radioLow);
            this.Controls.Add(this.LabelPriority);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPriority;
        private System.Windows.Forms.RadioButton radioLow;
        private System.Windows.Forms.RadioButton radioMedum;
        private System.Windows.Forms.RadioButton radioHight;
        private System.Windows.Forms.Label labelCompleted;
        private System.Windows.Forms.CheckBox checkBoxCompleted;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDedline;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button1;
    }
}

