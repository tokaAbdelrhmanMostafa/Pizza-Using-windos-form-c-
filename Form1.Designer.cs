namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toping = new System.Windows.Forms.GroupBox();
            this.paper = new System.Windows.Forms.CheckBox();
            this.olives = new System.Windows.Forms.CheckBox();
            this.onion = new System.Windows.Forms.CheckBox();
            this.tomato = new System.Windows.Forms.CheckBox();
            this.mushorom = new System.Windows.Forms.CheckBox();
            this.cheese = new System.Windows.Forms.CheckBox();
            this.whereToEat = new System.Windows.Forms.GroupBox();
            this.EatOut = new System.Windows.Forms.RadioButton();
            this.EatIn = new System.Windows.Forms.RadioButton();
            this.crust = new System.Windows.Forms.GroupBox();
            this.thick = new System.Windows.Forms.RadioButton();
            this.thin = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.large = new System.Windows.Forms.RadioButton();
            this.Meduim = new System.Windows.Forms.RadioButton();
            this.samll = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.order = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.topings = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.where = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.prise = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toping.SuspendLayout();
            this.whereToEat.SuspendLayout();
            this.crust.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toping);
            this.groupBox1.Controls.Add(this.whereToEat);
            this.groupBox1.Controls.Add(this.crust);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // toping
            // 
            this.toping.Controls.Add(this.paper);
            this.toping.Controls.Add(this.olives);
            this.toping.Controls.Add(this.onion);
            this.toping.Controls.Add(this.tomato);
            this.toping.Controls.Add(this.mushorom);
            this.toping.Controls.Add(this.cheese);
            this.toping.Location = new System.Drawing.Point(233, 24);
            this.toping.Name = "toping";
            this.toping.Size = new System.Drawing.Size(354, 158);
            this.toping.TabIndex = 3;
            this.toping.TabStop = false;
            this.toping.Text = "toping";
            // 
            // paper
            // 
            this.paper.AutoSize = true;
            this.paper.Location = new System.Drawing.Point(25, 110);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(131, 24);
            this.paper.TabIndex = 5;
            this.paper.Tag = "5";
            this.paper.Text = "green paper";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.CheckedChanged += new System.EventHandler(this.paper_CheckedChanged);
            // 
            // olives
            // 
            this.olives.AutoSize = true;
            this.olives.Location = new System.Drawing.Point(210, 34);
            this.olives.Name = "olives";
            this.olives.Size = new System.Drawing.Size(80, 24);
            this.olives.TabIndex = 4;
            this.olives.Tag = "5";
            this.olives.Text = "olives";
            this.olives.UseVisualStyleBackColor = true;
            this.olives.CheckedChanged += new System.EventHandler(this.olives_CheckedChanged);
            // 
            // onion
            // 
            this.onion.AutoSize = true;
            this.onion.Location = new System.Drawing.Point(210, 69);
            this.onion.Name = "onion";
            this.onion.Size = new System.Drawing.Size(76, 24);
            this.onion.TabIndex = 3;
            this.onion.Tag = "5";
            this.onion.Text = "onion";
            this.onion.UseVisualStyleBackColor = true;
            this.onion.CheckedChanged += new System.EventHandler(this.onion_CheckedChanged);
            // 
            // tomato
            // 
            this.tomato.AutoSize = true;
            this.tomato.Location = new System.Drawing.Point(198, 109);
            this.tomato.Name = "tomato";
            this.tomato.Size = new System.Drawing.Size(88, 24);
            this.tomato.TabIndex = 2;
            this.tomato.Tag = "5";
            this.tomato.Text = "tomato";
            this.tomato.UseVisualStyleBackColor = true;
            this.tomato.CheckedChanged += new System.EventHandler(this.tomato_CheckedChanged);
            // 
            // mushorom
            // 
            this.mushorom.AutoSize = true;
            this.mushorom.Location = new System.Drawing.Point(25, 65);
            this.mushorom.Name = "mushorom";
            this.mushorom.Size = new System.Drawing.Size(118, 24);
            this.mushorom.TabIndex = 1;
            this.mushorom.Tag = "5";
            this.mushorom.Text = "mushorom";
            this.mushorom.UseVisualStyleBackColor = true;
            this.mushorom.CheckedChanged += new System.EventHandler(this.mushorom_CheckedChanged);
            // 
            // cheese
            // 
            this.cheese.AutoSize = true;
            this.cheese.Location = new System.Drawing.Point(25, 34);
            this.cheese.Name = "cheese";
            this.cheese.Size = new System.Drawing.Size(141, 24);
            this.cheese.TabIndex = 0;
            this.cheese.Tag = "5";
            this.cheese.Text = "Extre cheese";
            this.cheese.UseVisualStyleBackColor = true;
            this.cheese.CheckedChanged += new System.EventHandler(this.cheese_CheckedChanged);
            // 
            // whereToEat
            // 
            this.whereToEat.Controls.Add(this.EatOut);
            this.whereToEat.Controls.Add(this.EatIn);
            this.whereToEat.Location = new System.Drawing.Point(233, 188);
            this.whereToEat.Name = "whereToEat";
            this.whereToEat.Size = new System.Drawing.Size(263, 74);
            this.whereToEat.TabIndex = 2;
            this.whereToEat.TabStop = false;
            this.whereToEat.Text = "where to eat";
            // 
            // EatOut
            // 
            this.EatOut.AutoSize = true;
            this.EatOut.Location = new System.Drawing.Point(121, 42);
            this.EatOut.Name = "EatOut";
            this.EatOut.Size = new System.Drawing.Size(94, 24);
            this.EatOut.TabIndex = 4;
            this.EatOut.TabStop = true;
            this.EatOut.Text = "Eat Out";
            this.EatOut.UseVisualStyleBackColor = true;
            this.EatOut.CheckedChanged += new System.EventHandler(this.EatOut_CheckedChanged);
            // 
            // EatIn
            // 
            this.EatIn.AutoSize = true;
            this.EatIn.Location = new System.Drawing.Point(25, 40);
            this.EatIn.Name = "EatIn";
            this.EatIn.Size = new System.Drawing.Size(79, 24);
            this.EatIn.TabIndex = 3;
            this.EatIn.TabStop = true;
            this.EatIn.Text = "Eat In";
            this.EatIn.UseVisualStyleBackColor = true;
            this.EatIn.CheckedChanged += new System.EventHandler(this.EatIn_CheckedChanged);
            // 
            // crust
            // 
            this.crust.Controls.Add(this.thick);
            this.crust.Controls.Add(this.thin);
            this.crust.Location = new System.Drawing.Point(26, 162);
            this.crust.Name = "crust";
            this.crust.Size = new System.Drawing.Size(200, 100);
            this.crust.TabIndex = 1;
            this.crust.TabStop = false;
            this.crust.Text = "CRUST TYPE";
            // 
            // thick
            // 
            this.thick.AutoSize = true;
            this.thick.Location = new System.Drawing.Point(25, 66);
            this.thick.Name = "thick";
            this.thick.Size = new System.Drawing.Size(119, 24);
            this.thick.TabIndex = 4;
            this.thick.TabStop = true;
            this.thick.Tag = "20";
            this.thick.Text = "thick crust";
            this.thick.UseVisualStyleBackColor = true;
            this.thick.CheckedChanged += new System.EventHandler(this.thick_CheckedChanged);
            // 
            // thin
            // 
            this.thin.AutoSize = true;
            this.thin.Location = new System.Drawing.Point(25, 40);
            this.thin.Name = "thin";
            this.thin.Size = new System.Drawing.Size(110, 24);
            this.thin.TabIndex = 3;
            this.thin.TabStop = true;
            this.thin.Tag = "0";
            this.thin.Text = "thin crust";
            this.thin.UseVisualStyleBackColor = true;
            this.thin.CheckedChanged += new System.EventHandler(this.thin_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.large);
            this.groupBox3.Controls.Add(this.Meduim);
            this.groupBox3.Controls.Add(this.samll);
            this.groupBox3.Location = new System.Drawing.Point(30, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size";
            // 
            // large
            // 
            this.large.AutoSize = true;
            this.large.Location = new System.Drawing.Point(28, 74);
            this.large.Name = "large";
            this.large.Size = new System.Drawing.Size(78, 24);
            this.large.TabIndex = 2;
            this.large.TabStop = true;
            this.large.Tag = "40";
            this.large.Text = "Large";
            this.large.UseVisualStyleBackColor = true;
            this.large.CheckedChanged += new System.EventHandler(this.large_CheckedChanged);
            // 
            // Meduim
            // 
            this.Meduim.AutoSize = true;
            this.Meduim.Location = new System.Drawing.Point(28, 48);
            this.Meduim.Name = "Meduim";
            this.Meduim.Size = new System.Drawing.Size(95, 24);
            this.Meduim.TabIndex = 1;
            this.Meduim.TabStop = true;
            this.Meduim.Tag = "30";
            this.Meduim.Text = "medium";
            this.Meduim.UseVisualStyleBackColor = true;
            this.Meduim.CheckedChanged += new System.EventHandler(this.Meduim_CheckedChanged);
            // 
            // samll
            // 
            this.samll.AutoSize = true;
            this.samll.Location = new System.Drawing.Point(28, 22);
            this.samll.Name = "samll";
            this.samll.Size = new System.Drawing.Size(75, 24);
            this.samll.TabIndex = 0;
            this.samll.TabStop = true;
            this.samll.Tag = "20";
            this.samll.Text = "small";
            this.samll.UseVisualStyleBackColor = true;
            this.samll.CheckedChanged += new System.EventHandler(this.samll_CheckedChanged);
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.order.Location = new System.Drawing.Point(188, 360);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(224, 23);
            this.order.TabIndex = 2;
            this.order.Text = "order Piza";
            this.order.UseVisualStyleBackColor = false;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(532, 360);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(167, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset Form";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Make your pizza";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prise);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.where);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.type);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.topings);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.size);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(606, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 238);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "order summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "size : ";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(142, 46);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(54, 20);
            this.size.TabIndex = 2;
            this.size.Text = "samll";
            this.size.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "toping :";
            // 
            // topings
            // 
            this.topings.AutoSize = true;
            this.topings.Location = new System.Drawing.Point(155, 72);
            this.topings.Name = "topings";
            this.topings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.topings.Size = new System.Drawing.Size(59, 20);
            this.topings.TabIndex = 5;
            this.topings.Text = "chese";
            this.topings.Click += new System.EventHandler(this.topings_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "ctust type:";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(175, 109);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(44, 20);
            this.type.TabIndex = 7;
            this.type.Text = "type";
            this.type.Click += new System.EventHandler(this.type_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "where to eat : ";
            // 
            // where
            // 
            this.where.AutoSize = true;
            this.where.Location = new System.Drawing.Point(186, 150);
            this.where.Name = "where";
            this.where.Size = new System.Drawing.Size(59, 20);
            this.where.TabIndex = 9;
            this.where.Text = "where";
            this.where.Click += new System.EventHandler(this.where_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "total prize :";
            // 
            // prise
            // 
            this.prise.AutoSize = true;
            this.prise.Location = new System.Drawing.Point(191, 208);
            this.prise.Name = "prise";
            this.prise.Size = new System.Drawing.Size(19, 20);
            this.prise.TabIndex = 11;
            this.prise.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.order);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.toping.ResumeLayout(false);
            this.toping.PerformLayout();
            this.whereToEat.ResumeLayout(false);
            this.whereToEat.PerformLayout();
            this.crust.ResumeLayout(false);
            this.crust.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox crust;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton large;
        private System.Windows.Forms.RadioButton Meduim;
        private System.Windows.Forms.RadioButton samll;
        private System.Windows.Forms.GroupBox whereToEat;
        private System.Windows.Forms.RadioButton EatOut;
        private System.Windows.Forms.RadioButton EatIn;
        private System.Windows.Forms.RadioButton thick;
        private System.Windows.Forms.RadioButton thin;
        private System.Windows.Forms.GroupBox toping;
        private System.Windows.Forms.CheckBox paper;
        private System.Windows.Forms.CheckBox olives;
        private System.Windows.Forms.CheckBox onion;
        private System.Windows.Forms.CheckBox tomato;
        private System.Windows.Forms.CheckBox mushorom;
        private System.Windows.Forms.CheckBox cheese;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label where;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label topings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label prise;
        private System.Windows.Forms.Label label13;
    }
}