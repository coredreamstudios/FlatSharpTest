using FlatSharp;

using System.Windows.Forms;

namespace FlatSharpTest
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();

            SerializeData();
        }

        private void SerializeData() 
        { 
            Person person = new Person();
            int maxBytesNeeded = Person.Serializer.GetMaxSize(person);
            byte[] buffer = new byte[maxBytesNeeded];
            int bytesWritten = Person.Serializer.Write(buffer, person);
        }
    }
}
