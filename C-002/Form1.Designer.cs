namespace C_002
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxType = new ComboBox();
            txtID = new TextBox();
            txtName = new TextBox();
            txtRate = new TextBox();
            dgvDisplay = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnCalculate = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            SuspendLayout();
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(134, 23);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 0;
            comboBoxType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(134, 70);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(134, 157);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 3;
            // 
            // dgvDisplay
            // 
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDisplay.Location = new Point(12, 199);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.Size = new Size(593, 183);
            dgvDisplay.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "รหัสพนักงาน";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ชื่อ";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "ประเภท";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "ค่าจ้าง";
            Column4.Name = "Column4";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(273, 165);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(68, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "ยอดรวมพิเศษ";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(134, 398);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "บันทึก";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(25, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "รหัส";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(25, 23);
            textBox2.TabIndex = 7;
            textBox2.Text = "ชื่อ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = "สำหรับเงินเดือน/ค่าจ้าง";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 23);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(89, 23);
            textBox4.TabIndex = 9;
            textBox4.Text = "ประเภทการจ้างงาน";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(dgvDisplay);
            Controls.Add(txtRate);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(comboBoxType);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxType;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtRate;
        private DataGridView dgvDisplay;
        private Label lblTotal;
        private Button btnCalculate;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox textBox4;
    }
}
