using Inventory.Data;
using Inventory.Data.Dto;
using System;
using System.Windows.Forms;

namespace Inventory.App
{
    public partial class AddLocation : Form
    {
        private readonly ILocationRepository repository;
        private Location location;

        public AddLocation(ILocationRepository repository)
        {
            this.location = new Location();
            this.repository = repository;
            InitializeComponent();

            this.button2.Visible = false;
        }

        public AddLocation(ILocationRepository repository, Location location)
        {
            this.repository = repository;
            this.location = location;

            InitializeComponent();

            this.textBoxiD.Text = this.location.Id.ToString();
            this.textBox1.Text = this.location.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.location.Id.ToString()))
            {
                Location location = new Location
                {
                    Name = this.textBox1.Text
                };

                this.repository.AddLocation(location);
            }
            else
            {
                this.repository.UpdateLocation(this.location);
            }

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.location.Name = this.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewien?", "Potwierdź usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.repository.DeleteLocation(this.location.Id.Value);
                this.Close();
            }
        }
    }
}
