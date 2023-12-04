namespace EnglishNew
{
    partial class glavUroki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glavUroki));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelslide = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Button();
            this.alfavit = new System.Windows.Forms.Button();
            this.pesnya = new System.Windows.Forms.Button();
            this.uroki = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(77)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.panelslide);
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.alfavit);
            this.panel1.Controls.Add(this.pesnya);
            this.panel1.Controls.Add(this.uroki);
            this.panel1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 58);
            this.panel1.TabIndex = 0;
            // 
            // panelslide
            // 
            this.panelslide.BackColor = System.Drawing.Color.Turquoise;
            this.panelslide.Location = new System.Drawing.Point(67, 52);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(179, 3);
            this.panelslide.TabIndex = 1;
            // 
            // info
            // 
            this.info.FlatAppearance.BorderSize = 0;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.ForeColor = System.Drawing.SystemColors.Control;
            this.info.Location = new System.Drawing.Point(783, 3);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(179, 55);
            this.info.TabIndex = 4;
            this.info.Text = "О программе";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.button4_Click);
            // 
            // alfavit
            // 
            this.alfavit.FlatAppearance.BorderSize = 0;
            this.alfavit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alfavit.ForeColor = System.Drawing.SystemColors.Control;
            this.alfavit.Location = new System.Drawing.Point(547, 3);
            this.alfavit.Name = "alfavit";
            this.alfavit.Size = new System.Drawing.Size(179, 55);
            this.alfavit.TabIndex = 3;
            this.alfavit.Text = "Алфавит";
            this.alfavit.UseVisualStyleBackColor = true;
            this.alfavit.Click += new System.EventHandler(this.button3_Click);
            // 
            // pesnya
            // 
            this.pesnya.FlatAppearance.BorderSize = 0;
            this.pesnya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesnya.ForeColor = System.Drawing.SystemColors.Control;
            this.pesnya.Location = new System.Drawing.Point(304, 3);
            this.pesnya.Name = "pesnya";
            this.pesnya.Size = new System.Drawing.Size(179, 55);
            this.pesnya.TabIndex = 2;
            this.pesnya.Text = "Песня";
            this.pesnya.UseVisualStyleBackColor = true;
            this.pesnya.Click += new System.EventHandler(this.button2_Click);
            // 
            // uroki
            // 
            this.uroki.FlatAppearance.BorderSize = 0;
            this.uroki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uroki.ForeColor = System.Drawing.SystemColors.Control;
            this.uroki.Location = new System.Drawing.Point(67, 3);
            this.uroki.Name = "uroki";
            this.uroki.Size = new System.Drawing.Size(179, 55);
            this.uroki.TabIndex = 1;
            this.uroki.Text = "Уроки";
            this.uroki.UseVisualStyleBackColor = true;
            this.uroki.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            "Урок 1",
            "Урок 2",
            "Урок 3",
            "Урок 4",
            "Урок 5"});
            this.listBox1.Location = new System.Drawing.Point(12, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(81, 368);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Location = new System.Drawing.Point(99, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(913, 515);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // glavUroki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 614);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "glavUroki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уроки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.glavUroki_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button alfavit;
        private System.Windows.Forms.Button pesnya;
        private System.Windows.Forms.Button uroki;
        private System.Windows.Forms.Panel panelslide;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

