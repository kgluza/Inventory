using Inventory.Data;
using Inventory.Data.Dto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Inventory.App
{
    public partial class AddItem : Form
    {
        private readonly IItemRepository repository;
        private readonly List<Category> categories;
        private readonly List<Location> locations;
        private Item item;

        public AddItem(IItemRepository repository, List<Category> categories, List<Location> locations)
        {
            this.item = new Item();
            this.repository = repository;
            this.categories = categories;
            this.locations = locations;
            InitializeComponent();

            this.button2.Visible = false;
            this.buttonAddDocument.Enabled = false;
        }

        public AddItem(IItemRepository repository, Item item, List<Category> categories, List<Location> locations)
        {
            this.repository = repository;
            this.item = item;
            this.categories = categories;
            this.locations = locations;
            InitializeComponent();

            this.textBoxiD.Text = this.item.Id.ToString();
            this.textBox1.Text = this.item.Name;
            this.textBoxSerialNumber.Text = this.item.SerialNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.item.Id.ToString()))
            {
                Item item = new Item
                {
                    Name = this.textBox1.Text,
                    SerialNumber = this.textBoxSerialNumber.Text,
                    CategoryId = ((Category)this.comboBoxCategories.SelectedItem).Id.Value,
                    CategoryName = ((Category)this.comboBoxCategories.SelectedItem).Name,
                    LocationId = ((Location)this.comboBoxLocations.SelectedItem).Id.Value,
                    LocationName = ((Location)this.comboBoxLocations.SelectedItem).Name,
                };

                this.repository.AddItem(item);
            }
            else
            {
                this.repository.UpdateItem(this.item);
            }

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.item.Name = this.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewien?", "Potwierdź usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.repository.DeleteItem(this.item.Id.Value);
                this.Close();
            }
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            this.comboBoxCategories.DataSource = this.categories;
            this.comboBoxLocations.DataSource = this.locations;

            if (this.item.CategoryName != null)
            {
                this.comboBoxCategories.SelectedIndex = this.comboBoxCategories.FindStringExact(this.item.CategoryName);
            }

            if (this.item.LocationName != null)
            {
                this.comboBoxLocations.SelectedIndex = this.comboBoxLocations.FindStringExact(this.item.LocationName);
            }

            if (this.item.Id.HasValue)
            {
                this.LoadDocuments();
            }
        }

        private void textBoxSerialNumber_TextChanged(object sender, EventArgs e)
        {
            this.item.SerialNumber = this.textBoxSerialNumber.Text;
        }

        private void comboBoxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.item.CategoryId = (int)this.comboBoxCategories.SelectedValue;
            this.item.CategoryName = this.comboBoxCategories.SelectedText;
        }

        private void comboBoxLocations_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.item.LocationId = (int)this.comboBoxLocations.SelectedValue;
            this.item.LocationName = this.comboBoxLocations.SelectedText;
        }

        private void buttonAddDocument_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();

            if (File.Exists(this.openFileDialog1.FileName))
            {
                this.repository.UploadDocument(this.item.Id.Value, this.openFileDialog1.FileName);
                this.LoadDocuments();
            }
        }

        private void LoadDocuments()
        {
            var documents = this.repository.GetDocuments(this.item.Id.Value);
            this.comboBoxDocuments.DataSource = documents;

            if (documents.Count > 0)
            {
                using (var ms = new MemoryStream(documents[0].Content))
                {
                    var image = Image.FromStream(ms);

                    this.pictureBoxDocument.Image = image;
                }
            }
        }

        private void comboBoxDocuments_SelectionChangeCommitted(object sender, EventArgs e)
        {
            byte[] imageData = this.comboBoxDocuments.SelectedValue as byte[];

            if (imageData == null)
            {
                return;
            }

            using (var ms = new MemoryStream(imageData))
            {
                var image = Image.FromStream(ms);

                this.pictureBoxDocument.Image = image;
            }
        }
    }
}
