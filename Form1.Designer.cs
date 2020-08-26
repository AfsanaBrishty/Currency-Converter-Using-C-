namespace Currency_Converter
{
    partial class MyForm
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
            this.Form_groupBox = new System.Windows.Forms.GroupBox();
            this.enter_amount_label = new System.Windows.Forms.Label();
            this.convert_to_label = new System.Windows.Forms.Label();
            this.enter_amount_textbox = new System.Windows.Forms.TextBox();
            this.convert_to_combobox = new System.Windows.Forms.ComboBox();
            this.Converted_Value_label = new System.Windows.Forms.Label();
            this.result_box = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.convert_btn = new System.Windows.Forms.Button();
            this.Form_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_groupBox
            // 
            this.Form_groupBox.Controls.Add(this.convert_btn);
            this.Form_groupBox.Controls.Add(this.reset_btn);
            this.Form_groupBox.Controls.Add(this.result_box);
            this.Form_groupBox.Controls.Add(this.Converted_Value_label);
            this.Form_groupBox.Controls.Add(this.convert_to_combobox);
            this.Form_groupBox.Controls.Add(this.enter_amount_textbox);
            this.Form_groupBox.Controls.Add(this.convert_to_label);
            this.Form_groupBox.Controls.Add(this.enter_amount_label);
            this.Form_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_groupBox.Location = new System.Drawing.Point(61, 30);
            this.Form_groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Form_groupBox.Name = "Form_groupBox";
            this.Form_groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Form_groupBox.Size = new System.Drawing.Size(713, 393);
            this.Form_groupBox.TabIndex = 0;
            this.Form_groupBox.TabStop = false;
            this.Form_groupBox.Text = "Currency Converter";
            this.Form_groupBox.Enter += new System.EventHandler(this.Form_groupBox_Enter);
            // 
            // enter_amount_label
            // 
            this.enter_amount_label.AutoSize = true;
            this.enter_amount_label.Location = new System.Drawing.Point(35, 58);
            this.enter_amount_label.Name = "enter_amount_label";
            this.enter_amount_label.Size = new System.Drawing.Size(201, 24);
            this.enter_amount_label.TabIndex = 0;
            this.enter_amount_label.Text = "Enter amount (In Taka)";
            // 
            // convert_to_label
            // 
            this.convert_to_label.AutoSize = true;
            this.convert_to_label.Location = new System.Drawing.Point(39, 111);
            this.convert_to_label.Name = "convert_to_label";
            this.convert_to_label.Size = new System.Drawing.Size(103, 24);
            this.convert_to_label.TabIndex = 1;
            this.convert_to_label.Text = "Convert To";
            // 
            // enter_amount_textbox
            // 
            this.enter_amount_textbox.Location = new System.Drawing.Point(284, 61);
            this.enter_amount_textbox.Name = "enter_amount_textbox";
            this.enter_amount_textbox.Size = new System.Drawing.Size(395, 29);
            this.enter_amount_textbox.TabIndex = 2;
            this.enter_amount_textbox.TextChanged += new System.EventHandler(this.enter_amount_textbox_TextChanged);
            // 
            // convert_to_combobox
            // 
            this.convert_to_combobox.FormattingEnabled = true;
            this.convert_to_combobox.Items.AddRange(new object[] {
            "Rupee",
            "USD",
            "Euro",
            "Canadian Dollar",
            "Australian Dollar"});
            this.convert_to_combobox.Location = new System.Drawing.Point(284, 113);
            this.convert_to_combobox.Name = "convert_to_combobox";
            this.convert_to_combobox.Size = new System.Drawing.Size(395, 32);
            this.convert_to_combobox.TabIndex = 3;
            // 
            // Converted_Value_label
            // 
            this.Converted_Value_label.AutoSize = true;
            this.Converted_Value_label.Location = new System.Drawing.Point(280, 209);
            this.Converted_Value_label.Name = "Converted_Value_label";
            this.Converted_Value_label.Size = new System.Drawing.Size(151, 24);
            this.Converted_Value_label.TabIndex = 4;
            this.Converted_Value_label.Text = "Converted Value";
            this.Converted_Value_label.Click += new System.EventHandler(this.Converted_Value_label_Click);
            // 
            // result_box
            // 
            this.result_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.result_box.Location = new System.Drawing.Point(43, 252);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(636, 29);
            this.result_box.TabIndex = 5;
            this.result_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result_box.TextChanged += new System.EventHandler(this.result_box_TextChanged);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(43, 342);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 6;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // convert_btn
            // 
            this.convert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_btn.Location = new System.Drawing.Point(603, 341);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(75, 23);
            this.convert_btn.TabIndex = 7;
            this.convert_btn.Text = "Convert";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Form_groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MyForm";
            this.Text = "Currency converter";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.Form_groupBox.ResumeLayout(false);
            this.Form_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Form_groupBox;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.Label Converted_Value_label;
        private System.Windows.Forms.ComboBox convert_to_combobox;
        private System.Windows.Forms.TextBox enter_amount_textbox;
        private System.Windows.Forms.Label convert_to_label;
        private System.Windows.Forms.Label enter_amount_label;
    }
}

