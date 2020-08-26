using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void Form_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void result_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Converted_Value_label_Click(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            enter_amount_textbox.Clear();
            convert_to_combobox.SelectedIndex = -1;
            result_box.Clear();
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(enter_amount_textbox.Text);

            if(convert_to_combobox.SelectedItem== "Rupee")
            {
                double convert = (i * 0.88);
                result_box.Text = "Converted amount in Rupee: " + convert;

            }
            if (convert_to_combobox.SelectedItem == "USD")
            {
                double convert = (i * 0.012);
                result_box.Text = "Converted amount in USD: " + convert;

            }
            if (convert_to_combobox.SelectedItem == "Euro")
            {
                double convert = (i * 0.0100);
                result_box.Text = "Converted amount in Euro: " + convert;

            }
            if (convert_to_combobox.SelectedItem == "Canadian Dollar")
            {
                double convert = (i * 0.016);
                result_box.Text = "Converted amount in Canadian Dollar: " + convert;

            }
            if (convert_to_combobox.SelectedItem == "Australian Dollar")
            {
                double convert = (i * 0.016);
                result_box.Text = "Converted amount in Australian Dollar: " + convert;

            }
        }

        private void enter_amount_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
