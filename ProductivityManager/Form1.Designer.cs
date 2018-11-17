namespace ProductivityManager
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
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 795);
            this.panel1.TabIndex = 0;
            // 
            // dates
            // 
            this.dates.BackColor = System.Drawing.Color.MintCream;
            this.dates.Location = new System.Drawing.Point(11, 401);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(180, 60);
            this.dates.TabIndex = 5;
            this.dates.Text = "Important Dates";
            this.dates.UseVisualStyleBackColor = false;
            this.dates.Click += new System.EventHandler(this.dates_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.BackColor = System.Drawing.Color.MintCream;
            this.buttonMoney.Location = new System.Drawing.Point(11, 282);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(180, 60);
            this.buttonMoney.TabIndex = 4;
            this.buttonMoney.Text = "Money Flow";
            this.buttonMoney.UseVisualStyleBackColor = false;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // buttonTodo
            // 
            this.buttonTodo.BackColor = System.Drawing.Color.MintCream;
            this.buttonTodo.Location = new System.Drawing.Point(11, 174);
            this.buttonTodo.Name = "buttonTodo";
            this.buttonTodo.Size = new System.Drawing.Size(180, 60);
            this.buttonTodo.TabIndex = 3;
            this.buttonTodo.Text = "Todo List";
            this.buttonTodo.UseVisualStyleBackColor = false;
            this.buttonTodo.Click += new System.EventHandler(this.buttonTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productivio";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 150);
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
            this.label1CPU.Location = new System.Drawing.Point(256, 60);
            this.label1CPU.Name = "label1CPU";
            this.label1CPU.Size = new System.Drawing.Size(83, 39);
            this.label1CPU.TabIndex = 1;
            this.label1CPU.Text = "CPU";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.BackColor = System.Drawing.Color.MintCream;
            this.progressBarCPU.ForeColor = System.Drawing.Color.LightGreen;
            this.progressBarCPU.Location = new System.Drawing.Point(382, 59);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(800, 40);
            this.progressBarCPU.TabIndex = 2;
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.BackColor = System.Drawing.Color.MintCream;
            this.progressBarRAM.ForeColor = System.Drawing.Color.LightGreen;
            this.progressBarRAM.Location = new System.Drawing.Point(382, 118);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(800, 40);
            this.progressBarRAM.TabIndex = 4;
            // 
            // label2RAM
            // 
            this.label2RAM.AutoSize = true;
            this.label2RAM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2RAM.Location = new System.Drawing.Point(256, 118);
            this.label2RAM.Name = "label2RAM";
            this.label2RAM.Size = new System.Drawing.Size(88, 39);
            this.label2RAM.TabIndex = 3;
            this.label2RAM.Text = "RAM";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(1257, 60);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(60, 39);
            this.lblCPU.TabIndex = 5;
            this.lblCPU.Text = "0%";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(1257, 119);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(60, 39);
            this.lblRAM.TabIndex = 6;
            this.lblRAM.Text = "0%";
            // 
            // todolist1
            // 
            this.todolist1.BackColor = System.Drawing.Color.PaleGreen;
            this.todolist1.Location = new System.Drawing.Point(246, 198);
            this.todolist1.Name = "todolist1";
            this.todolist1.Size = new System.Drawing.Size(1119, 615);
            this.todolist1.TabIndex = 7;
            // 
            // moneyFlow1
            // 
            this.moneyFlow1.BackColor = System.Drawing.Color.PaleGreen;
            this.moneyFlow1.Location = new System.Drawing.Point(246, 198);
            this.moneyFlow1.Name = "moneyFlow1";
            this.moneyFlow1.Size = new System.Drawing.Size(1119, 600);
            this.moneyFlow1.TabIndex = 8;
            // 
            // Productivio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 875);
            this.Controls.Add(this.todolist1);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.label2RAM);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.label1CPU);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moneyFlow1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productivio";
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
    }
}

