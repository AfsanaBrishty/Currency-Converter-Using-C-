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


            string selected_item_text = convert_to_combobox.GetItemText(convert_to_combobox.SelectedItem);
            if (selected_item_text == "Rupee")
            {
                double convert = (i * 0.88);
                result_box.Text = "Converted amount in Rupee: " + convert;

            }
            if (selected_item_text == "USD")
            {
                double convert = (i * 0.012);
                result_box.Text = "Converted amount in USD: " + convert;

            }
            if (selected_item_text == "Euro")
            {
                double convert = (i * 0.0100);
                result_box.Text = "Converted amount in Euro: " + convert;

            }
            if (selected_item_text == "Canadian Dollar")
            {
                double convert = (i * 0.016);
                result_box.Text = "Converted amount in Canadian Dollar: " + convert;

            }
            if (selected_item_text == "Australian Dollar")
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
