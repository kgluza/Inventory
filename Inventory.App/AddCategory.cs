using Inventory.Data;
using Inventory.Data.Dto;
using System;
using System.Windows.Forms;

namespace Inventory.App
{
    public partial class AddCategory : Form
    {
        private readonly ICategoryRepository repository;
        private Category category;

        public AddCategory(ICategoryRepository repository)
        {
            this.category = new Category();
            this.repository = repository;
            InitializeComponent();

            this.button2.Visible = false;
        }

        public AddCategory(ICategoryRepository repository, Category category)
        {
            this.repository = repository;
            this.category = category;

            InitializeComponent();

            this.textBoxiD.Text = this.category.Id.ToString();
            this.textBox1.Text = this.category.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.category.Id.ToString()))
            {
                Category category = new Category
                {
                    Name = this.textBox1.Text
                };

                this.repository.AddCategory(category);
            }
            else
            {
                this.repository.UpdateCategory(this.category);
            }

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.category.Name = this.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewien?", "Potwierdź usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.repository.DeleteCategory(this.category.Id.Value);
                this.Close();
            }
        }
    }
}
