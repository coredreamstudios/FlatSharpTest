using FlatSharp;
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
                if (!float.TryParse(PersonLatTextBox.Text, out float latitude))
                {
                    MessageBox.Show("Please enter a latitude as a float");
                    return false;
                }
                 if (!float.TryParse(PersonLongTextBox.Text, out float longitude))
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

            if (ValidateData()) {
                Person person = new Person
                {
                    FavoriteColor = Color.Red,
                    Name = PersonNameTextBox.Text,
                    Position = new Location
                    {
                        Latitude = float.Parse(PersonLatTextBox.Text),
                        Longitude = float.Parse(PersonLongTextBox.Text)
                    }
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
    }
}
