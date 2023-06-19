namespace Расчет_потерь_на_сетях_водоснабжения
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.damageType = new System.Windows.Forms.ListBox();
            this.AddData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // damageType
            // 
            this.damageType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.damageType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.damageType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.damageType.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.damageType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.damageType.FormattingEnabled = true;
            this.damageType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.damageType.ItemHeight = 19;
            this.damageType.Items.AddRange(new object[] {
            "   Утечки воды при повреждениях",
            "   Свищевые повреждения",
            "   Трещины",
            "   Переломы, разрывы",
            "   Утечки через уплотнения сетевой арматуры",
            "   Утечки через водоразборные колонки (на проток)",
            "   Утечки на водоразборных колонках (при вкл/выкл)",
            "   Естественная убыль",
            "   Расходы воды на отогрев трубопроводов",
            "   Скрытые утечки и потери по невыявленным причинам"});
            this.damageType.Location = new System.Drawing.Point(1, 68);
            this.damageType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.damageType.Name = "damageType";
            this.damageType.Size = new System.Drawing.Size(394, 228);
            this.damageType.TabIndex = 0;
            this.damageType.SelectedIndexChanged += new System.EventHandler(this.choiceTypeofDamage);
            // 
            // AddData
            // 
            this.AddData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.AddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddData.Font = new System.Drawing.Font("Aviano Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.AddData.Image = ((System.Drawing.Image)(resources.GetObject("AddData.Image")));
            this.AddData.Location = new System.Drawing.Point(12, 302);
            this.AddData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(115, 24);
            this.AddData.TabIndex = 1;
            this.AddData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddData.UseVisualStyleBackColor = false;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(414, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(962, 666);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveData
            // 
            this.saveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(66)))), ((int)(((byte)(108)))));
            this.saveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveData.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.saveData.Image = ((System.Drawing.Image)(resources.GetObject("saveData.Image")));
            this.saveData.Location = new System.Drawing.Point(410, 763);
            this.saveData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(162, 32);
            this.saveData.TabIndex = 3;
            this.saveData.UseVisualStyleBackColor = false;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбор вида повреждения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(66)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(404, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Расчет потерь";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(395, 1);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1016, 815);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(101, 712);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 78);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1409, 815);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddData);
            this.Controls.Add(this.damageType);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет потерь на сетях водоснабжения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox damageType;
        private System.Windows.Forms.Button AddData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

