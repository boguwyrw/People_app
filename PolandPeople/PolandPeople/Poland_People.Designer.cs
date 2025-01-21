namespace PolandPeople
{
    partial class Poland_People
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelFindByLastName = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonFindByLastName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonProvince = new System.Windows.Forms.RadioButton();
            this.radioButtonLastName = new System.Windows.Forms.RadioButton();
            this.radioButtonPesel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(466, 607);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Połącz";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(456, 496);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(85, 15);
            this.labelServer.TabIndex = 2;
            this.labelServer.Text = "Nazwa serwera";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(456, 514);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(158, 23);
            this.textBoxServer.TabIndex = 3;
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(456, 550);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(111, 15);
            this.labelDatabase.TabIndex = 4;
            this.labelDatabase.Text = "Nazwa bazy danych";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(456, 568);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(158, 23);
            this.textBoxDatabase.TabIndex = 5;
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(21, 89);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPerson.TabIndex = 6;
            this.buttonAddPerson.Text = "Dodaj";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(912, 89);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelFindByLastName
            // 
            this.labelFindByLastName.AutoSize = true;
            this.labelFindByLastName.Location = new System.Drawing.Point(625, 19);
            this.labelFindByLastName.Name = "labelFindByLastName";
            this.labelFindByLastName.Size = new System.Drawing.Size(78, 15);
            this.labelFindByLastName.TabIndex = 8;
            this.labelFindByLastName.Text = "Szukana fraza";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(583, 50);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(175, 23);
            this.textBoxSearch.TabIndex = 9;
            // 
            // buttonFindByLastName
            // 
            this.buttonFindByLastName.Location = new System.Drawing.Point(444, 89);
            this.buttonFindByLastName.Name = "buttonFindByLastName";
            this.buttonFindByLastName.Size = new System.Drawing.Size(137, 23);
            this.buttonFindByLastName.TabIndex = 10;
            this.buttonFindByLastName.Text = "Szukaj";
            this.buttonFindByLastName.UseVisualStyleBackColor = true;
            this.buttonFindByLastName.Click += new System.EventHandler(this.buttonFindByLastName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonProvince);
            this.groupBox1.Controls.Add(this.radioButtonLastName);
            this.groupBox1.Controls.Add(this.radioButtonPesel);
            this.groupBox1.Location = new System.Drawing.Point(274, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 45);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szukany typ";
            // 
            // radioButtonProvince
            // 
            this.radioButtonProvince.AutoSize = true;
            this.radioButtonProvince.Location = new System.Drawing.Point(182, 16);
            this.radioButtonProvince.Name = "radioButtonProvince";
            this.radioButtonProvince.Size = new System.Drawing.Size(100, 19);
            this.radioButtonProvince.TabIndex = 2;
            this.radioButtonProvince.TabStop = true;
            this.radioButtonProvince.Text = "Województwo";
            this.radioButtonProvince.UseVisualStyleBackColor = true;
            this.radioButtonProvince.CheckedChanged += new System.EventHandler(this.radioButtonProvince_CheckedChanged);
            // 
            // radioButtonLastName
            // 
            this.radioButtonLastName.AutoSize = true;
            this.radioButtonLastName.Location = new System.Drawing.Point(95, 16);
            this.radioButtonLastName.Name = "radioButtonLastName";
            this.radioButtonLastName.Size = new System.Drawing.Size(75, 19);
            this.radioButtonLastName.TabIndex = 1;
            this.radioButtonLastName.TabStop = true;
            this.radioButtonLastName.Text = "Nazwisko";
            this.radioButtonLastName.UseVisualStyleBackColor = true;
            this.radioButtonLastName.CheckedChanged += new System.EventHandler(this.radioButtonLastName_CheckedChanged);
            // 
            // radioButtonPesel
            // 
            this.radioButtonPesel.AutoSize = true;
            this.radioButtonPesel.Location = new System.Drawing.Point(22, 16);
            this.radioButtonPesel.Name = "radioButtonPesel";
            this.radioButtonPesel.Size = new System.Drawing.Size(52, 19);
            this.radioButtonPesel.TabIndex = 0;
            this.radioButtonPesel.TabStop = true;
            this.radioButtonPesel.Text = "Pesel";
            this.radioButtonPesel.UseVisualStyleBackColor = true;
            this.radioButtonPesel.CheckedChanged += new System.EventHandler(this.radioButtonPesel_CheckedChanged);
            // 
            // Poland_People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 642);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFindByLastName);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelFindByLastName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Poland_People";
            this.Text = "Poland People";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button buttonConnect;
        private Label labelServer;
        private TextBox textBoxServer;
        private Label labelDatabase;
        private TextBox textBoxDatabase;
        private Button buttonAddPerson;
        private Button buttonDelete;
        private Label labelFindByLastName;
        private TextBox textBoxSearch;
        private Button buttonFindByLastName;
        private GroupBox groupBox1;
        private RadioButton radioButtonPesel;
        private RadioButton radioButtonLastName;
        private RadioButton radioButtonProvince;
    }
}