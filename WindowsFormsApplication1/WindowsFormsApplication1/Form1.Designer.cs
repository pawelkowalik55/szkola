namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.spd_up = new System.Windows.Forms.Button();
            this.spd_down = new System.Windows.Forms.Button();
            this.spd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbgear = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.Czas = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Czas.SuspendLayout();
            this.SuspendLayout();
            // 
            // spd_up
            // 
            this.spd_up.Location = new System.Drawing.Point(210, 31);
            this.spd_up.Name = "spd_up";
            this.spd_up.Size = new System.Drawing.Size(118, 23);
            this.spd_up.TabIndex = 0;
            this.spd_up.Text = "zwiększ prędkość";
            this.spd_up.UseVisualStyleBackColor = true;
            this.spd_up.Click += new System.EventHandler(this.spd_up_Click);
            // 
            // spd_down
            // 
            this.spd_down.Location = new System.Drawing.Point(210, 60);
            this.spd_down.Name = "spd_down";
            this.spd_down.Size = new System.Drawing.Size(118, 23);
            this.spd_down.TabIndex = 1;
            this.spd_down.Text = "zmniejsz predkosc";
            this.spd_down.UseVisualStyleBackColor = true;
            this.spd_down.Click += new System.EventHandler(this.spd_down_Click);
            // 
            // spd
            // 
            this.spd.Location = new System.Drawing.Point(6, 19);
            this.spd.Name = "spd";
            this.spd.ReadOnly = true;
            this.spd.Size = new System.Drawing.Size(100, 20);
            this.spd.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prędkość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "km/h";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.distance);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 75);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Przebyty dystans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "km";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(6, 20);
            this.distance.Name = "distance";
            this.distance.ReadOnly = true;
            this.distance.Size = new System.Drawing.Size(100, 20);
            this.distance.TabIndex = 0;
            this.distance.TextChanged += new System.EventHandler(this.distance_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbgear);
            this.groupBox3.Location = new System.Drawing.Point(18, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 72);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biegi";
            // 
            // tbgear
            // 
            this.tbgear.Location = new System.Drawing.Point(5, 20);
            this.tbgear.Name = "tbgear";
            this.tbgear.ReadOnly = true;
            this.tbgear.Size = new System.Drawing.Size(100, 20);
            this.tbgear.TabIndex = 0;
            this.tbgear.TextChanged += new System.EventHandler(this.tbgear_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(210, 194);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(118, 24);
            this.start.TabIndex = 9;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Czas
            // 
            this.Czas.Controls.Add(this.textBox1);
            this.Czas.Location = new System.Drawing.Point(13, 178);
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(176, 70);
            this.Czas.TabIndex = 10;
            this.Czas.TabStop = false;
            this.Czas.Text = "Czas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 338);
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.spd_down);
            this.Controls.Add(this.spd_up);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Czas.ResumeLayout(false);
            this.Czas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button spd_up;
        private System.Windows.Forms.Button spd_down;
        private System.Windows.Forms.TextBox spd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbgear;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox Czas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

