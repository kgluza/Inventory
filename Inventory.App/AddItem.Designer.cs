
namespace Inventory.App
{
    partial class AddItem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxiD = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLocations = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxDocuments = new System.Windows.Forms.ComboBox();
            this.buttonAddDocument = new System.Windows.Forms.Button();
            this.pictureBoxDocument = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // textBoxiD
            // 
            this.textBoxiD.Location = new System.Drawing.Point(12, 23);
            this.textBoxiD.Name = "textBoxiD";
            this.textBoxiD.ReadOnly = true;
            this.textBoxiD.Size = new System.Drawing.Size(261, 20);
            this.textBoxiD.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(107, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DisplayMember = "Name";
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(12, 104);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(261, 21);
            this.comboBoxCategories.TabIndex = 6;
            this.comboBoxCategories.ValueMember = "Id";
            this.comboBoxCategories.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCategories_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lokalizacja";
            // 
            // comboBoxLocations
            // 
            this.comboBoxLocations.DisplayMember = "Name";
            this.comboBoxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocations.FormattingEnabled = true;
            this.comboBoxLocations.Location = new System.Drawing.Point(13, 145);
            this.comboBoxLocations.Name = "comboBoxLocations";
            this.comboBoxLocations.Size = new System.Drawing.Size(261, 21);
            this.comboBoxLocations.TabIndex = 8;
            this.comboBoxLocations.ValueMember = "Id";
            this.comboBoxLocations.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLocations_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numer Seryjny";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(13, 185);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(261, 20);
            this.textBoxSerialNumber.TabIndex = 10;
            this.textBoxSerialNumber.TextChanged += new System.EventHandler(this.textBoxSerialNumber_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "faktura.pdf";
            this.openFileDialog1.Filter = "Dokumenty|*.pdf;*.jpg;*.png";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxDocument);
            this.groupBox1.Controls.Add(this.buttonAddDocument);
            this.groupBox1.Controls.Add(this.comboBoxDocuments);
            this.groupBox1.Location = new System.Drawing.Point(305, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1172, 871);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dokumenty";
            // 
            // comboBoxDocuments
            // 
            this.comboBoxDocuments.DisplayMember = "FileName";
            this.comboBoxDocuments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDocuments.FormattingEnabled = true;
            this.comboBoxDocuments.Location = new System.Drawing.Point(207, 19);
            this.comboBoxDocuments.Name = "comboBoxDocuments";
            this.comboBoxDocuments.Size = new System.Drawing.Size(261, 21);
            this.comboBoxDocuments.TabIndex = 7;
            this.comboBoxDocuments.ValueMember = "Content";
            this.comboBoxDocuments.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDocuments_SelectionChangeCommitted);
            this.comboBoxDocuments.DataSourceChanged += new System.EventHandler(this.comboBoxDocuments_SelectionChangeCommitted);
            // 
            // buttonAddDocument
            // 
            this.buttonAddDocument.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddDocument.ForeColor = System.Drawing.Color.White;
            this.buttonAddDocument.Location = new System.Drawing.Point(510, 13);
            this.buttonAddDocument.Name = "buttonAddDocument";
            this.buttonAddDocument.Size = new System.Drawing.Size(39, 32);
            this.buttonAddDocument.TabIndex = 11;
            this.buttonAddDocument.Text = "+";
            this.buttonAddDocument.UseVisualStyleBackColor = false;
            this.buttonAddDocument.Click += new System.EventHandler(this.buttonAddDocument_Click);
            // 
            // pictureBoxDocument
            // 
            this.pictureBoxDocument.Location = new System.Drawing.Point(6, 44);
            this.pictureBoxDocument.Name = "pictureBoxDocument";
            this.pictureBoxDocument.Size = new System.Drawing.Size(1157, 821);
            this.pictureBoxDocument.TabIndex = 12;
            this.pictureBoxDocument.TabStop = false;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 890);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLocations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxiD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddItem";
            this.Text = "Dodaj przedmiot";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxiD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxLocations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDocuments;
        private System.Windows.Forms.PictureBox pictureBoxDocument;
        private System.Windows.Forms.Button buttonAddDocument;
    }
}