using Inventory.Data;
using Inventory.Data.Dto;
using Inventory.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory.App
{
    public partial class Main : Form
    {
        private const string ConnectionString = @"data source=DESKTOP-3TDOV04\SQLDEV1;database=Inventory;Integrated Security=SSPI;persist security info=True;";
        private readonly ICategoryRepository categoryRepository;
        private readonly ILocationRepository locationRepository;
        private readonly IItemRepository itemRepository;

        private List<Category> categories;
        private List<Location> locations;

        public Main()
        {
            InitializeComponent();
            this.categoryRepository = new CategoryRepository(ConnectionString);
            this.locationRepository = new LocationRepository(ConnectionString);
            this.itemRepository = new ItemRepository(ConnectionString);
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var form = new AddCategory(this.categoryRepository);
            form.ShowDialog();
            this.LoadCategories();
        }


        private void dataGridViewCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = this.dataGridViewCategories.Rows[e.RowIndex];

            var category = new Category
            {
                Id = row.Cells[0].Value as int?,
                Name = row.Cells[1].Value.ToString()
            };

            var form = new AddCategory(this.categoryRepository, category);
            form.ShowDialog();

            this.LoadCategories();
        }

        private void dataGridViewLocations_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = this.dataGridViewLocations.Rows[e.RowIndex];

            var location = new Location
            {
                Id = row.Cells[0].Value as int?,
                Name = row.Cells[1].Value.ToString()
            };

            var form = new AddLocation(this.locationRepository, location);
            form.ShowDialog();

            this.LoadLocations();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.LoadCategories();
            this.LoadLocations();
            this.LoadItems();
        }

        private void LoadCategories()
        {
            this.categories = this.categoryRepository.GetCategories();
            this.dataGridViewCategories.DataSource = this.categories;
        }

        private void LoadLocations()
        {
            this.locations = this.locationRepository.GetLocations();

            this.dataGridViewLocations.DataSource = this.locations;
        }

        private void LoadItems()
        {
            var items = this.itemRepository.GetItems();
            this.dataGridView.DataSource = items;
        }

        private void buttonAddLocation_Click(object sender, EventArgs e)
        {
            var form = new AddLocation(this.locationRepository);
            form.ShowDialog();
            this.LoadLocations();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new AddItem(this.itemRepository, this.categories, this.locations);
            form.ShowDialog();
            this.LoadItems();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = this.dataGridView.Rows[e.RowIndex];

            var id = (int)row.Cells[0].Value;
            var item = this.itemRepository.GetItemById(id);

            var form = new AddItem(this.itemRepository, item, categories, locations);
            form.ShowDialog();

            this.LoadItems();
        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            this.textBoxCategoriesCategoryName.Text = string.Empty;
            this.textBoxName.Text = string.Empty;
            this.textBoxCategory.Text = string.Empty;
            this.textBoxLocation.Text = string.Empty;
            this.textBoxSerialNumber.Text = string.Empty;

            this.textBoxCategoryCategoryId.Text = string.Empty;
            this.textBoxCategoriesCategoryName.Text = string.Empty;

            this.textBoxLocationsLocationId.Text = string.Empty;
            this.textBoxLocationsLocationName.Text = string.Empty;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            var items = this.itemRepository.GetItems(
                this.textBoxId.Text,
                this.textBoxName.Text,
                this.textBoxCategory.Text,
                this.textBoxLocation.Text,
                this.textBoxSerialNumber.Text);

            this.dataGridView.DataSource = items;
        }

        private void textBoxCategoryCategoryId_TextChanged(object sender, EventArgs e)
        {
            var categories = this.categoryRepository.GetCategories(this.textBoxCategoryCategoryId.Text, this.textBoxCategoriesCategoryName.Text);
            this.dataGridViewCategories.DataSource = categories;
        }

        private void textBoxLocationsLocationId_TextChanged(object sender, EventArgs e)
        {
            var locations = this.locationRepository.GetLocations(this.textBoxLocationsLocationId.Text, this.textBoxLocationsLocationName.Text);
            this.dataGridViewLocations.DataSource = locations;
        }
    }
}
