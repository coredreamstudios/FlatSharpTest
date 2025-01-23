using FlatSharp;
using FlatSharpTest.Basic;
using FlatSharpTest.Views;
using System;
using System.IO;
using System.Windows.Forms;

namespace FlatSharpTest
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            PersonFavColorComboBox.DataSource = Enum.GetValues(typeof(Color));
            PersonFavColorComboBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Basic validation check
        /// </summary>
        private bool ValidateData()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(PersonNameTextBox.Text))
                {
                    MessageBox.Show("Please enter a name");
                    return false;
                }
                if (!float.TryParse(PersonLatUpDown.Text, out float latitude))
                {
                    MessageBox.Show("Please enter a latitude as a float");
                    return false;
                }
                if (!float.TryParse(PersonLongUpDown.Text, out float longitude))
                {
                    MessageBox.Show("Please enter a longitude as a float");
                    return false;
                }


                return true; // Validation passed
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void SerializeData()
        {
            // Check for basic validation before serializing.

            if (ValidateData())
            {
                // Cast the selected item to the Color enum
                Color selectedColor = (Color)PersonFavColorComboBox.SelectedItem;

                Person person = new Person
                {
                    FavoriteColor = selectedColor,
                    Name = PersonNameTextBox.Text,
                    Position = new Location
                    {
                        Latitude = float.Parse(PersonLatUpDown.Text),
                        Longitude = float.Parse(PersonLongUpDown.Text)
                    },
                    Active = ActiveCheckBox.Checked
                };

                int maxBytesNeeded = Person.Serializer.GetMaxSize(person);
                byte[] buffer = new byte[maxBytesNeeded];
                int bytesWritten = Person.Serializer.Write(buffer, person);

                File.WriteAllBytes("Person.jsfb", buffer);
            }


        }

        private void SerializeDataButton_Click(object sender, System.EventArgs e)
        {
            SerializeData();
        }

        private void BrowseFilePath_Click(object sender, EventArgs e)
        {
            BrowseForFile();
        }

        private void BrowseForFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "Flatbuffer (*.jsfb)|*.jsfb";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void DeserializeData()
        {
            //Person person = Person.Serializer.Parse(DataFilePath.Text.ToArray());
        }

        private void DeserializeDataButton_Click(object sender, EventArgs e)
        {
            DeserializeData();
        }

        private void RenderEditorViewButton_Click(object sender, EventArgs e)
        {
            using (RenderEditorView frm = new RenderEditorView())
            {
                frm.ShowDialog();
            }

        }

        private void CharacterMapperViewButton_Click(object sender, EventArgs e)
        {
            using (CharacterMappingEditorView frm = new CharacterMappingEditorView())
            {
                frm.ShowDialog();
            }
        }
    }
}
