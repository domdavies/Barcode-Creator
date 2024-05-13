
namespace Pallet_label_gen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sku_cmb = new System.Windows.Forms.ComboBox();
            this.batch_txt = new System.Windows.Forms.TextBox();
            this.serial_txt = new System.Windows.Forms.TextBox();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.generate_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prorduct SKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(153, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Batch";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(168, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "QTY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(37, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial number";
            // 
            // sku_cmb
            // 
            this.sku_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sku_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sku_cmb.FormattingEnabled = true;
            this.sku_cmb.Items.AddRange(new object[] {
            "12344234",
            "123342",
            "34253425",
            "365456"});
            this.sku_cmb.Location = new System.Drawing.Point(302, 42);
            this.sku_cmb.Name = "sku_cmb";
            this.sku_cmb.Size = new System.Drawing.Size(200, 21);
            this.sku_cmb.TabIndex = 4;
            // 
            // batch_txt
            // 
            this.batch_txt.Location = new System.Drawing.Point(302, 124);
            this.batch_txt.Name = "batch_txt";
            this.batch_txt.Size = new System.Drawing.Size(200, 20);
            this.batch_txt.TabIndex = 5;
            // 
            // serial_txt
            // 
            this.serial_txt.Location = new System.Drawing.Point(302, 215);
            this.serial_txt.Name = "serial_txt";
            this.serial_txt.Size = new System.Drawing.Size(200, 20);
            this.serial_txt.TabIndex = 6;
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(302, 302);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(99, 20);
            this.qty_txt.TabIndex = 7;
            // 
            // generate_btn
            // 
            this.generate_btn.Location = new System.Drawing.Point(410, 351);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(92, 46);
            this.generate_btn.TabIndex = 8;
            this.generate_btn.Text = "GENERATE";
            this.generate_btn.UseVisualStyleBackColor = true;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.generate_btn);
            this.Controls.Add(this.qty_txt);
            this.Controls.Add(this.serial_txt);
            this.Controls.Add(this.batch_txt);
            this.Controls.Add(this.sku_cmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generate_btn;
        public System.Windows.Forms.ComboBox sku_cmb;
        public System.Windows.Forms.TextBox batch_txt;
        public System.Windows.Forms.TextBox serial_txt;
        public System.Windows.Forms.TextBox qty_txt;
    }
}

