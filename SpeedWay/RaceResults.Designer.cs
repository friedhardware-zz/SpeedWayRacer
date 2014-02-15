namespace SpeedWay
{
    partial class RaceResults
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(373, 148);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 18);
            this.name.TabIndex = 4;
            this.name.Text = "Blank";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(373, 196);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(16, 18);
            this.score.TabIndex = 5;
            this.score.Text = "0";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(373, 242);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(16, 18);
            this.time.TabIndex = 6;
            this.time.Text = "0";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(374, 80);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(39, 13);
            this.type.TabIndex = 7;
            this.type.Text = "notype";
            // 
            // RaceResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 422);
            this.Controls.Add(this.type);
            this.Controls.Add(this.time);
            this.Controls.Add(this.score);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RaceResults";
            this.Text = "RaceResults";
            this.Load += new System.EventHandler(this.RaceResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label type;
    }
}