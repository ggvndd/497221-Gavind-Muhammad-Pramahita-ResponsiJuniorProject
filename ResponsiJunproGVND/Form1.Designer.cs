namespace ResponsiJunproGVND
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelName = new Label();
            labelDept = new Label();
            tbNama = new TextBox();
            cbDepartemen = new ComboBox();
            pictureBox1 = new PictureBox();
            dgvData = new DataGridView();
            listBox1 = new ListBox();
            label1 = new Label();
            btnDelete = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(21, 122);
            labelName.Name = "labelName";
            labelName.Size = new Size(96, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nama Karyawan:";
            // 
            // labelDept
            // 
            labelDept.AutoSize = true;
            labelDept.Location = new Point(21, 160);
            labelDept.Name = "labelDept";
            labelDept.Size = new Size(89, 15);
            labelDept.TabIndex = 1;
            labelDept.Text = "Dept Karyawan:";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(123, 119);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(129, 23);
            tbNama.TabIndex = 2;
            // 
            // cbDepartemen
            // 
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDepartemen.Location = new Point(123, 157);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(129, 23);
            cbDepartemen.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(21, 288);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(412, 150);
            dgvData.TabIndex = 5;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "HR: HR", "ENG: Engineer", "DEV: Developer", "PM: Product M", "FIN: Finance" });
            listBox1.Location = new Point(319, 119);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 92);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 7;
            label1.Text = "ID Departemen:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(102, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(21, 259);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(183, 259);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(358, 259);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(dgvData);
            Controls.Add(pictureBox1);
            Controls.Add(cbDepartemen);
            Controls.Add(tbNama);
            Controls.Add(labelDept);
            Controls.Add(labelName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelDept;
        private TextBox tbNama;
        private ComboBox cbDepartemen;
        private PictureBox pictureBox1;
        private DataGridView dgvData;
        private ListBox listBox1;
        private Label label1;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnLoad;
    }
}