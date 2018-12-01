namespace ProductivityManager
{
    partial class EventsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGetEvent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSchoolEvent = new System.Windows.Forms.Button();
            this.buttonLifeEvent = new System.Windows.Forms.Button();
            this.buttonWorkEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(585, 47);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date of Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of Event";
            // 
            // textBoxGetEvent
            // 
            this.textBoxGetEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGetEvent.Location = new System.Drawing.Point(41, 229);
            this.textBoxGetEvent.Name = "textBoxGetEvent";
            this.textBoxGetEvent.Size = new System.Drawing.Size(585, 47);
            this.textBoxGetEvent.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type of Event";
            // 
            // buttonSchoolEvent
            // 
            this.buttonSchoolEvent.BackColor = System.Drawing.Color.Ivory;
            this.buttonSchoolEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchoolEvent.Location = new System.Drawing.Point(41, 376);
            this.buttonSchoolEvent.Name = "buttonSchoolEvent";
            this.buttonSchoolEvent.Size = new System.Drawing.Size(167, 51);
            this.buttonSchoolEvent.TabIndex = 5;
            this.buttonSchoolEvent.Text = "School";
            this.buttonSchoolEvent.UseVisualStyleBackColor = false;
            this.buttonSchoolEvent.Click += new System.EventHandler(this.buttonSchoolEvent_Click);
            // 
            // buttonLifeEvent
            // 
            this.buttonLifeEvent.BackColor = System.Drawing.Color.Ivory;
            this.buttonLifeEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLifeEvent.Location = new System.Drawing.Point(41, 515);
            this.buttonLifeEvent.Name = "buttonLifeEvent";
            this.buttonLifeEvent.Size = new System.Drawing.Size(167, 51);
            this.buttonLifeEvent.TabIndex = 6;
            this.buttonLifeEvent.Text = "Life";
            this.buttonLifeEvent.UseVisualStyleBackColor = false;
            this.buttonLifeEvent.Click += new System.EventHandler(this.buttonLifeEvent_Click);
            // 
            // buttonWorkEvent
            // 
            this.buttonWorkEvent.BackColor = System.Drawing.Color.Ivory;
            this.buttonWorkEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWorkEvent.Location = new System.Drawing.Point(41, 448);
            this.buttonWorkEvent.Name = "buttonWorkEvent";
            this.buttonWorkEvent.Size = new System.Drawing.Size(167, 51);
            this.buttonWorkEvent.TabIndex = 7;
            this.buttonWorkEvent.Text = "Work";
            this.buttonWorkEvent.UseVisualStyleBackColor = false;
            this.buttonWorkEvent.Click += new System.EventHandler(this.buttonWorkEvent_Click);
            // 
            // EventsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.buttonWorkEvent);
            this.Controls.Add(this.buttonLifeEvent);
            this.Controls.Add(this.buttonSchoolEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGetEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "EventsPage";
            this.Size = new System.Drawing.Size(1119, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGetEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSchoolEvent;
        private System.Windows.Forms.Button buttonLifeEvent;
        private System.Windows.Forms.Button buttonWorkEvent;
    }
}
