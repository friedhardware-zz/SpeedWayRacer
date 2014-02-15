namespace SpeedWay
{
    partial class Race
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
            this.number = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answerField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitRace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(13, 13);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(18, 20);
            this.number.TabIndex = 0;
            this.number.Text = "1";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(149, 159);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(26, 29);
            this.x.TabIndex = 1;
            this.x.Text = "0";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.Location = new System.Drawing.Point(266, 159);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(26, 29);
            this.y.TabIndex = 2;
            this.y.Text = "0";
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.Location = new System.Drawing.Point(207, 159);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(27, 29);
            this.sign.TabIndex = 3;
            this.sign.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // answer
            // 
            this.answerField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerField.Location = new System.Drawing.Point(383, 153);
            this.answerField.Name = "answer";
            this.answerField.Size = new System.Drawing.Size(100, 35);
            this.answerField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "/100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Press Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitRace
            // 
            this.ExitRace.Location = new System.Drawing.Point(533, 13);
            this.ExitRace.Name = "ExitRace";
            this.ExitRace.Size = new System.Drawing.Size(75, 23);
            this.ExitRace.TabIndex = 8;
            this.ExitRace.Text = "Exit Race";
            this.ExitRace.UseVisualStyleBackColor = true;
            this.ExitRace.Click += new System.EventHandler(this.ExitRace_Click);
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 376);
            this.ControlBox = false;
            this.Controls.Add(this.ExitRace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.number);
            this.Name = "Race";
            this.Text = "Racer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answerField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitRace;
    }
}