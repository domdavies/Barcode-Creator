using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Pallet_label_gen
{
    public partial class Form2 : Form
    {
        Form1 cpy;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            cpy = parent;

            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128, Options = new ZXing.Common.EncodingOptions
            {
                Width = 400,
                Height = 70
            }
            };

            sku.Image = writer.Write(cpy.sku_cmb.Text);

            Batch.Image = writer.Write(cpy.batch_txt.Text);

            serial.Image = writer.Write(cpy.serial_txt.Text);

            qty.Text = cpy.qty_txt.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void sku_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void serial_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sku_Click_1(object sender, EventArgs e)
        {

        }
    }
}
