﻿namespace ProductivityManager
{
    partial class Productivio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productivio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dates = new System.Windows.Forms.Button();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.buttonTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1CPU = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.label2RAM = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.todolist1 = new ProductivityManager.Todolist();
            this.moneyFlow1 = new ProductivityManager.MoneyFlow();
            this.eventsPage1 = new ProductivityManager.EventsPage();
            this.moneyFlow2 = new ProductivityManager.MoneyFlow();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.dates);
            this.panel1.Controls.Add(this.buttonMoney);
            this.panel1.Controls.Add(this.buttonTodo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(10, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 385);
            this.panel1.TabIndex = 0;
            // 
            // dates
            // 
            this.dates.BackColor = System.Drawing.Color.MintCream;
            this.dates.Location = new System.Drawing.Point(6, 209);
            this.dates.Margin = new System.Windows.Forms.Padding(2);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(90, 31);
            this.dates.TabIndex = 5;
            this.dates.Text = "Important Dates";
            this.dates.UseVisualStyleBackColor = false;
            this.dates.Click += new System.EventHandler(this.dates_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.BackColor = System.Drawing.Color.MintCream;
            this.buttonMoney.Location = new System.Drawing.Point(6, 147);
            this.buttonMoney.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(90, 31);
            this.buttonMoney.TabIndex = 4;
            this.buttonMoney.Text = "Money Flow";
            this.buttonMoney.UseVisualStyleBackColor = false;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // buttonTodo
            // 
            this.buttonTodo.BackColor = System.Drawing.Color.MintCream;
            this.buttonTodo.Location = new System.Drawing.Point(6, 90);
            this.buttonTodo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTodo.Name = "buttonTodo";
            this.buttonTodo.Size = new System.Drawing.Size(90, 31);
            this.buttonTodo.TabIndex = 3;
            this.buttonTodo.Text = "Todo List";
            this.buttonTodo.UseVisualStyleBackColor = false;
            this.buttonTodo.Click += new System.EventHandler(this.buttonTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productivio";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(100, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 78);
            this.panel2.TabIndex = 1;
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1CPU
            // 
            this.label1CPU.AutoSize = true;
            this.label1CPU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CPU.Location = new System.Drawing.Point(128, 31);
            this.label1CPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1CPU.Name = "label1CPU";
            this.label1CPU.Size = new System.Drawing.Size(43, 21);
            this.label1CPU.TabIndex = 1;
            this.label1CPU.Text = "CPU";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.BackColor = System.Drawing.Color.MintCream;
            this.progressBarCPU.ForeColor = System.Drawing.Color.LightGreen;
            this.progressBarCPU.Location = new System.Drawing.Point(191, 31);
            this.progressBarCPU.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(400, 21);
            this.progressBarCPU.TabIndex = 2;
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.BackColor = System.Drawing.Color.MintCream;
            this.progressBarRAM.ForeColor = System.Drawing.Color.LightGreen;
            this.progressBarRAM.Location = new System.Drawing.Point(191, 61);
            this.progressBarRAM.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(400, 21);
            this.progressBarRAM.TabIndex = 4;
            // 
            // label2RAM
            // 
            this.label2RAM.AutoSize = true;
            this.label2RAM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2RAM.Location = new System.Drawing.Point(128, 61);
            this.label2RAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2RAM.Name = "label2RAM";
            this.label2RAM.Size = new System.Drawing.Size(48, 21);
            this.label2RAM.TabIndex = 3;
            this.label2RAM.Text = "RAM";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(628, 31);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(31, 21);
            this.lblCPU.TabIndex = 5;
            this.lblCPU.Text = "0%";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(628, 62);
            this.lblRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(31, 21);
            this.lblRAM.TabIndex = 6;
            this.lblRAM.Text = "0%";
            // 
            // todolist1
            // 
            this.todolist1.BackColor = System.Drawing.Color.PaleGreen;
            this.todolist1.Location = new System.Drawing.Point(123, 103);
            this.todolist1.Margin = new System.Windows.Forms.Padding(1);
            this.todolist1.Name = "todolist1";
            this.todolist1.Size = new System.Drawing.Size(560, 320);
            this.todolist1.TabIndex = 7;
            // 
            // moneyFlow1
            // 
            this.moneyFlow1.BackColor = System.Drawing.Color.PaleGreen;
            this.moneyFlow1.Location = new System.Drawing.Point(123, 103);
            this.moneyFlow1.Margin = new System.Windows.Forms.Padding(1);
            this.moneyFlow1.Name = "moneyFlow1";
            this.moneyFlow1.Size = new System.Drawing.Size(560, 312);
            this.moneyFlow1.TabIndex = 8;
            // 
            // eventsPage1
            // 
            this.eventsPage1.BackColor = System.Drawing.Color.PaleGreen;
            this.eventsPage1.Location = new System.Drawing.Point(123, 103);
            this.eventsPage1.Margin = new System.Windows.Forms.Padding(1);
            this.eventsPage1.Name = "eventsPage1";
            this.eventsPage1.Size = new System.Drawing.Size(560, 312);
            this.eventsPage1.TabIndex = 9;
            // 
            // moneyFlow2
            // 
            this.moneyFlow2.BackColor = System.Drawing.Color.PaleGreen;
            this.moneyFlow2.Location = new System.Drawing.Point(123, 103);
            this.moneyFlow2.Margin = new System.Windows.Forms.Padding(2);
            this.moneyFlow2.Name = "moneyFlow2";
            this.moneyFlow2.Size = new System.Drawing.Size(560, 312);
            this.moneyFlow2.TabIndex = 10;
            // 
            // Productivio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 455);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.label2RAM);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.label1CPU);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.todolist1);
            this.Controls.Add(this.eventsPage1);
            this.Controls.Add(this.moneyFlow2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Productivio";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Load += new System.EventHandler(this.Productivio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1CPU;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.Label label2RAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonTodo;
        private System.Windows.Forms.Button dates;
        private Todolist todolist1;
        private MoneyFlow moneyFlow1;
        private EventsPage eventsPage1;
        private MoneyFlow moneyFlow2;
    }
}

