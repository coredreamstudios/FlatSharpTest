using FlatSharp;
using FlatSharpTest.WWE2K24;
using System;
using System.IO;
using System.Windows.Forms;

namespace FlatSharpTest.Views;

public partial class CharacterMappingEditorView : Form
{
    public CharacterMappingEditorView()
    {
        InitializeComponent();
    }

    private bool ValidateData()
    {
        try
        {
            if (string.IsNullOrWhiteSpace(BaseModelMDLFilePathTextBox.Text))
            {
                MessageBox.Show("Please enter a path to the baseModel MDL you wish to use");
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


    private void SerializeDataButton_Click(object sender, EventArgs e)
    {
        SerializeData();
    }

    private void SerializeData()
    {
        // Check for basic validation before serializing.

        if (ValidateData())
        {
            CharacterMapping mapping = new CharacterMapping
            {
                Characterid = (uint)CharacterIdUpDown.Value,
                Characterfolderpath = CharacterFolderPathTextBox.Text,
                Attirefolderpath = AttireFolderPathTextBox.Text,
                Basemodelmdlpath = BaseModelMDLFilePathTextBox.Text,
                Basemodelmtlspath = BaseModelMTLsFilePathTextBox.Text,
                Attiremdlpath = AttireModelMDLFilePathTextBox.Text,
                Attiremtlspath = AttireModelMTLsFilePathTextBox.Text,
                Locked = LockedCheckBox.Checked
            };

            int maxBytesNeeded = CharacterMapping.Serializer.GetMaxSize(mapping);
            byte[] buffer = new byte[maxBytesNeeded];
            int bytesWritten = CharacterMapping.Serializer.Write(buffer, mapping);

            File.WriteAllBytes("CharacterMapping.jsfb", buffer);
        }
    }
}
