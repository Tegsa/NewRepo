﻿namespace Kliker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer  components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upgradebutton = new System.Windows.Forms.Button();
            this.buttonLevelTextBox = new System.Windows.Forms.TextBox();
            this.A1AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A1UpgradeAmmount = new System.Windows.Forms.Button();
            this.A1UpgradeInterval = new System.Windows.Forms.Button();
            this.A1Label = new System.Windows.Forms.Label();
            this.A1IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1Timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.A2IntervalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.A2UpgradeInterval = new System.Windows.Forms.Button();
            this.A2Timer = new System.Windows.Forms.Timer(this.components);
            this.A3IntervalTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.A3UpgradeInterval = new System.Windows.Forms.Button();
            this.A3Timer = new System.Windows.Forms.Timer(this.components);
            this.A2AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A2label = new System.Windows.Forms.Label();
            this.A2UpgradeAmmount = new System.Windows.Forms.Button();
            this.A3label = new System.Windows.Forms.Label();
            this.A3AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A3UpgradeAmmount = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(648, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 131);
            this.button1.TabIndex = 0;
            this.button1.Text = "!KLIKAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitcoiny : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // upgradebutton
            // 
            this.upgradebutton.Image = ((System.Drawing.Image)(resources.GetObject("upgradebutton.Image")));
            this.upgradebutton.Location = new System.Drawing.Point(754, 413);
            this.upgradebutton.Name = "upgradebutton";
            this.upgradebutton.Size = new System.Drawing.Size(75, 48);
            this.upgradebutton.TabIndex = 2;
            this.upgradebutton.UseVisualStyleBackColor = true;
            this.upgradebutton.Click += new System.EventHandler(this.upgradebutton_Click);
            // 
            // buttonLevelTextBox
            // 
            this.buttonLevelTextBox.Location = new System.Drawing.Point(648, 413);
            this.buttonLevelTextBox.Name = "buttonLevelTextBox";
            this.buttonLevelTextBox.Size = new System.Drawing.Size(100, 23);
            this.buttonLevelTextBox.TabIndex = 3;
            // 
            // A1AmmountTextBox
            // 
            this.A1AmmountTextBox.Location = new System.Drawing.Point(435, 341);
            this.A1AmmountTextBox.Name = "A1AmmountTextBox";
            this.A1AmmountTextBox.ReadOnly = true;
            this.A1AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1AmmountTextBox.TabIndex = 4;
            this.A1AmmountTextBox.Text = "0";
            // 
            // A1UpgradeAmmount
            // 
            this.A1UpgradeAmmount.Location = new System.Drawing.Point(340, 302);
            this.A1UpgradeAmmount.Name = "A1UpgradeAmmount";
            this.A1UpgradeAmmount.Size = new System.Drawing.Size(84, 64);
            this.A1UpgradeAmmount.TabIndex = 5;
            this.A1UpgradeAmmount.Text = "Ulepsz Ilośc";
            this.A1UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A1UpgradeAmmount.Click += new System.EventHandler(this.A1UpgradeAmmount_Click);
            // 
            // A1UpgradeInterval
            // 
            this.A1UpgradeInterval.Location = new System.Drawing.Point(340, 372);
            this.A1UpgradeInterval.Name = "A1UpgradeInterval";
            this.A1UpgradeInterval.Size = new System.Drawing.Size(89, 64);
            this.A1UpgradeInterval.TabIndex = 6;
            this.A1UpgradeInterval.Text = "Ulepsz częstotliwośc";
            this.A1UpgradeInterval.UseVisualStyleBackColor = true;
            this.A1UpgradeInterval.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // A1Label
            // 
            this.A1Label.AutoSize = true;
            this.A1Label.Location = new System.Drawing.Point(340, 284);
            this.A1Label.Name = "A1Label";
            this.A1Label.Size = new System.Drawing.Size(129, 15);
            this.A1Label.TabIndex = 7;
            this.A1Label.Text = "Automatyczne kopanie";
            // 
            // A1IntervalTextBox
            // 
            this.A1IntervalTextBox.Location = new System.Drawing.Point(435, 413);
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            this.A1IntervalTextBox.ReadOnly = true;
            this.A1IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1IntervalTextBox.TabIndex = 8;
            this.A1IntervalTextBox.Text = "0";
            // 
            // A1Timer
            // 
            this.A1Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "/min";
            // 
            // A2IntervalTextBox
            // 
            this.A2IntervalTextBox.Location = new System.Drawing.Point(102, 219);
            this.A2IntervalTextBox.Name = "A2IntervalTextBox";
            this.A2IntervalTextBox.ReadOnly = true;
            this.A2IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A2IntervalTextBox.TabIndex = 10;
            this.A2IntervalTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "/min";
            // 
            // A2UpgradeInterval
            // 
            this.A2UpgradeInterval.Location = new System.Drawing.Point(7, 171);
            this.A2UpgradeInterval.Name = "A2UpgradeInterval";
            this.A2UpgradeInterval.Size = new System.Drawing.Size(89, 61);
            this.A2UpgradeInterval.TabIndex = 12;
            this.A2UpgradeInterval.Text = "Ulepsz koparkę #2";
            this.A2UpgradeInterval.UseVisualStyleBackColor = true;
            this.A2UpgradeInterval.Click += new System.EventHandler(this.A2UpgradeInterval_Click);
            // 
            // A2Timer
            // 
            this.A2Timer.Tick += new System.EventHandler(this.A2Timer_Tick);
            // 
            // A3IntervalTextBox
            // 
            this.A3IntervalTextBox.Location = new System.Drawing.Point(97, 415);
            this.A3IntervalTextBox.Name = "A3IntervalTextBox";
            this.A3IntervalTextBox.ReadOnly = true;
            this.A3IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A3IntervalTextBox.TabIndex = 13;
            this.A3IntervalTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "/min";
            // 
            // A3UpgradeInterval
            // 
            this.A3UpgradeInterval.Location = new System.Drawing.Point(2, 386);
            this.A3UpgradeInterval.Name = "A3UpgradeInterval";
            this.A3UpgradeInterval.Size = new System.Drawing.Size(89, 52);
            this.A3UpgradeInterval.TabIndex = 15;
            this.A3UpgradeInterval.Text = "Ulepsz koparkę #1";
            this.A3UpgradeInterval.UseVisualStyleBackColor = true;
            this.A3UpgradeInterval.Click += new System.EventHandler(this.A3UpgradeInterval_Click);
            // 
            // A3Timer
            // 
            this.A3Timer.Tick += new System.EventHandler(this.A3Timer_Tick);
            // 
            // A2AmmountTextBox
            // 
            this.A2AmmountTextBox.Location = new System.Drawing.Point(97, 128);
            this.A2AmmountTextBox.Name = "A2AmmountTextBox";
            this.A2AmmountTextBox.ReadOnly = true;
            this.A2AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A2AmmountTextBox.TabIndex = 16;
            this.A2AmmountTextBox.Text = "0";
            // 
            // A2label
            // 
            this.A2label.AutoSize = true;
            this.A2label.Location = new System.Drawing.Point(7, 77);
            this.A2label.Name = "A2label";
            this.A2label.Size = new System.Drawing.Size(129, 15);
            this.A2label.TabIndex = 17;
            this.A2label.Text = "Automatyczne kopanie";
            // 
            // A2UpgradeAmmount
            // 
            this.A2UpgradeAmmount.Location = new System.Drawing.Point(7, 95);
            this.A2UpgradeAmmount.Name = "A2UpgradeAmmount";
            this.A2UpgradeAmmount.Size = new System.Drawing.Size(84, 56);
            this.A2UpgradeAmmount.TabIndex = 18;
            this.A2UpgradeAmmount.Text = "Powiększ sprzęt";
            this.A2UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A2UpgradeAmmount.Click += new System.EventHandler(this.A2UpgradeAmmount_Click);
            // 
            // A3label
            // 
            this.A3label.AutoSize = true;
            this.A3label.Location = new System.Drawing.Point(2, 302);
            this.A3label.Name = "A3label";
            this.A3label.Size = new System.Drawing.Size(129, 15);
            this.A3label.TabIndex = 19;
            this.A3label.Text = "Automatyczne kopanie";
            // 
            // A3AmmountTextBox
            // 
            this.A3AmmountTextBox.Location = new System.Drawing.Point(92, 356);
            this.A3AmmountTextBox.Name = "A3AmmountTextBox";
            this.A3AmmountTextBox.ReadOnly = true;
            this.A3AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A3AmmountTextBox.TabIndex = 20;
            this.A3AmmountTextBox.Text = "0";
            // 
            // A3UpgradeAmmount
            // 
            this.A3UpgradeAmmount.Location = new System.Drawing.Point(2, 324);
            this.A3UpgradeAmmount.Name = "A3UpgradeAmmount";
            this.A3UpgradeAmmount.Size = new System.Drawing.Size(84, 55);
            this.A3UpgradeAmmount.TabIndex = 21;
            this.A3UpgradeAmmount.Text = "Powiększ sprzęt";
            this.A3UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A3UpgradeAmmount.Click += new System.EventHandler(this.A3UpgradeAmmount_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(744, 467);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "10$/100$/1000$/10000$/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 494);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.A3UpgradeAmmount);
            this.Controls.Add(this.A3AmmountTextBox);
            this.Controls.Add(this.A3label);
            this.Controls.Add(this.A2UpgradeAmmount);
            this.Controls.Add(this.A2label);
            this.Controls.Add(this.A2AmmountTextBox);
            this.Controls.Add(this.A3UpgradeInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.A3IntervalTextBox);
            this.Controls.Add(this.A2UpgradeInterval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A2IntervalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A1IntervalTextBox);
            this.Controls.Add(this.A1Label);
            this.Controls.Add(this.A1UpgradeInterval);
            this.Controls.Add(this.A1UpgradeAmmount);
            this.Controls.Add(this.A1AmmountTextBox);
            this.Controls.Add(this.buttonLevelTextBox);
            this.Controls.Add(this.upgradebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button upgradebutton;
        private TextBox buttonLevelTextBox;
        private TextBox A1AmmountTextBox;
        private Button A1UpgradeAmmount;
        private Button A1UpgradeInterval;
        private Label A1Label;
        private TextBox A1IntervalTextBox;
        private System.Windows.Forms.Timer A1Timer;
        private Label label2;
        private TextBox A2IntervalTextBox;
        private Label label3;
        private Button A2UpgradeInterval;
        private System.Windows.Forms.Timer A2Timer;
        private TextBox A3IntervalTextBox;
        private Label label4;
        private Button A3UpgradeInterval;
        private System.Windows.Forms.Timer A3Timer;
        private TextBox A2AmmountTextBox;
        private Label A2label;
        private Button A2UpgradeAmmount;
        private Label A3label;
        private TextBox A3AmmountTextBox;
        private Button A3UpgradeAmmount;
        private TextBox textBox1;
    }
}