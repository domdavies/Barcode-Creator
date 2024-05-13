
namespace Pallet_label_gen
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.Label();
            this.sku = new System.Windows.Forms.PictureBox();
            this.Batch = new System.Windows.Forms.PictureBox();
            this.serial = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Batch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serial)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(47, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(47, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "QTY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(47, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Batch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = " SKU";
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(183, 360);
            this.qty.MinimumSize = new System.Drawing.Size(200, 60);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(200, 73);
            this.qty.TabIndex = 11;
            // 
            // sku
            // 
            this.sku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sku.Location = new System.Drawing.Point(166, 27);
            this.sku.MinimumSize = new System.Drawing.Size(300, 0);
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(400, 70);
            this.sku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sku.TabIndex = 12;
            this.sku.TabStop = false;
            this.sku.Click += new System.EventHandler(this.sku_Click_1);
            // 
            // Batch
            // 
            this.Batch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Batch.Location = new System.Drawing.Point(166, 151);
            this.Batch.Name = "Batch";
            this.Batch.Size = new System.Drawing.Size(400, 70);
            this.Batch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Batch.TabIndex = 13;
            this.Batch.TabStop = false;
            // 
            // serial
            // 
            this.serial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.serial.Location = new System.Drawing.Point(166, 272);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(400, 70);
            this.serial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.serial.TabIndex = 14;
            this.serial.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.Batch);
            this.Controls.Add(this.sku);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.sku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Batch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.PictureBox sku;
        private System.Windows.Forms.PictureBox Batch;
        private System.Windows.Forms.PictureBox serial;
    }
}