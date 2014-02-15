namespace SpeedWay
{
    partial class ChooseRace
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
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nameinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(113, 151);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Addition";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(113, 197);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(108, 23);
            this.subtract.TabIndex = 1;
            this.subtract.Text = "Subtraction";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(113, 243);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(108, 23);
            this.multiply.TabIndex = 2;
            this.multiply.Text = "Multiplication";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(113, 289);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(108, 23);
            this.divide.TabIndex = 3;
            this.divide.Text = "Division";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose A Race";
            // 
            // Nameinput
            // 
            this.Nameinput.Location = new System.Drawing.Point(113, 99);
            this.Nameinput.Name = "Nameinput";
            this.Nameinput.Size = new System.Drawing.Size(108, 20);
            this.Nameinput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter your name and select a race.";
            // 
            // ChooseRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nameinput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseRace";
            this.Text = "Choose Race";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nameinput;
        private System.Windows.Forms.Label label2;
    }
}