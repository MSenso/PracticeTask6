namespace PracticeTask6
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
            this.a1_input = new System.Windows.Forms.TextBox();
            this.a2_input = new System.Windows.Forms.TextBox();
            this.a3_input = new System.Windows.Forms.TextBox();
            this.m_input = new System.Windows.Forms.TextBox();
            this.Sequence_output = new System.Windows.Forms.Label();
            this.Equals_output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a1_input
            // 
            this.a1_input.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1_input.Location = new System.Drawing.Point(325, 33);
            this.a1_input.Name = "a1_input";
            this.a1_input.Size = new System.Drawing.Size(110, 41);
            this.a1_input.TabIndex = 0;
            this.a1_input.TextChanged += new System.EventHandler(this.a1_input_TextChanged);
            this.a1_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // a2_input
            // 
            this.a2_input.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2_input.Location = new System.Drawing.Point(325, 95);
            this.a2_input.Name = "a2_input";
            this.a2_input.Size = new System.Drawing.Size(110, 41);
            this.a2_input.TabIndex = 1;
            this.a2_input.TextChanged += new System.EventHandler(this.a2_input_TextChanged);
            this.a2_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // a3_input
            // 
            this.a3_input.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a3_input.Location = new System.Drawing.Point(325, 159);
            this.a3_input.Name = "a3_input";
            this.a3_input.Size = new System.Drawing.Size(110, 41);
            this.a3_input.TabIndex = 2;
            this.a3_input.TextChanged += new System.EventHandler(this.a3_input_TextChanged);
            this.a3_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // m_input
            // 
            this.m_input.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_input.Location = new System.Drawing.Point(325, 225);
            this.m_input.Name = "m_input";
            this.m_input.Size = new System.Drawing.Size(110, 41);
            this.m_input.TabIndex = 3;
            this.m_input.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.m_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // Sequence_output
            // 
            this.Sequence_output.AutoSize = true;
            this.Sequence_output.BackColor = System.Drawing.Color.Transparent;
            this.Sequence_output.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sequence_output.Location = new System.Drawing.Point(46, 307);
            this.Sequence_output.Name = "Sequence_output";
            this.Sequence_output.Size = new System.Drawing.Size(0, 33);
            this.Sequence_output.TabIndex = 4;
            // 
            // Equals_output
            // 
            this.Equals_output.AutoSize = true;
            this.Equals_output.BackColor = System.Drawing.Color.Transparent;
            this.Equals_output.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equals_output.Location = new System.Drawing.Point(46, 355);
            this.Equals_output.Name = "Equals_output";
            this.Equals_output.Size = new System.Drawing.Size(0, 33);
            this.Equals_output.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите а1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(164, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите а2: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(164, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите а3: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(164, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите m: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PracticeTask6.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(598, 435);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Equals_output);
            this.Controls.Add(this.Sequence_output);
            this.Controls.Add(this.m_input);
            this.Controls.Add(this.a3_input);
            this.Controls.Add(this.a2_input);
            this.Controls.Add(this.a1_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1181, 687);
            this.Name = "Form1";
            this.Text = "Рекурсия";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a1_input;
        private System.Windows.Forms.TextBox a2_input;
        private System.Windows.Forms.TextBox a3_input;
        private System.Windows.Forms.TextBox m_input;
        private System.Windows.Forms.Label Sequence_output;
        private System.Windows.Forms.Label Equals_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

