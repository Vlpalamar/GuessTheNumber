namespace WindowsFormsApp2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.IsTrueLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.Replay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter u nuber";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(258, 186);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(148, 23);
            this.Play.TabIndex = 2;
            this.Play.Text = "Enter";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // IsTrueLabel
            // 
            this.IsTrueLabel.AutoSize = true;
            this.IsTrueLabel.Location = new System.Drawing.Point(498, 156);
            this.IsTrueLabel.Name = "IsTrueLabel";
            this.IsTrueLabel.Size = new System.Drawing.Size(0, 13);
            this.IsTrueLabel.TabIndex = 3;
            this.IsTrueLabel.Visible = false;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(45, 155);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(0, 13);
            this.CountLabel.TabIndex = 4;
            // 
            // Replay
            // 
            this.Replay.Location = new System.Drawing.Point(258, 186);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(148, 23);
            this.Replay.TabIndex = 5;
            this.Replay.Text = "Play Again";
            this.Replay.UseVisualStyleBackColor = true;
            this.Replay.Visible = false;
            this.Replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Replay);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.IsTrueLabel);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label IsTrueLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button Replay;
    }
}

