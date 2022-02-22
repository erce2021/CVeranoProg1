namespace app1
{
    partial class DateTimePickerForm
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
            this.salidaLabel = new System.Windows.Forms.Label();
            this.llegadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de llegada";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // salidaLabel
            // 
            this.salidaLabel.AutoSize = true;
            this.salidaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaLabel.Location = new System.Drawing.Point(46, 99);
            this.salidaLabel.Name = "salidaLabel";
            this.salidaLabel.Size = new System.Drawing.Size(204, 20);
            this.salidaLabel.TabIndex = 2;
            this.salidaLabel.Text = "Fecha estimada de entrega";
            this.salidaLabel.Click += new System.EventHandler(this.SalidaLabel_Click);
            // 
            // llegadaDateTimePicker
            // 
            this.llegadaDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llegadaDateTimePicker.Location = new System.Drawing.Point(45, 43);
            this.llegadaDateTimePicker.Name = "llegadaDateTimePicker";
            this.llegadaDateTimePicker.Size = new System.Drawing.Size(213, 20);
            this.llegadaDateTimePicker.TabIndex = 5;
            this.llegadaDateTimePicker.ValueChanged += new System.EventHandler(this.LlegadaDateTimePicker_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // DateTimePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 212);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.llegadaDateTimePicker);
            this.Controls.Add(this.salidaLabel);
            this.Controls.Add(this.label1);
            this.Name = "DateTimePickerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DateTimePickerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label salidaLabel;
        private System.Windows.Forms.DateTimePicker llegadaDateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
    }
}

