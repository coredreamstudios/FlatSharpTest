using FlatSharp;
using FlatSharpTest.WWE2K24;
using System;
using System.IO;
using System.Windows.Forms;

namespace FlatSharpTest.Views;

public partial class RenderEditorView : Form
{
    public RenderEditorView()
    {
        InitializeComponent();
    }
    private bool ValidateData()
    {
        try
        {
            if (string.IsNullOrWhiteSpace(DDSRenderFilePathTextBox.Text))
            {
                MessageBox.Show("Please enter a path to the render you wish to use");
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
            FaceTexture render = new FaceTexture
            {
                Id = (int)WrestlerIdUpDown.Value,
                Attire = (int)AttireNumberUpDown.Value,
                Path = DDSRenderFilePathTextBox.Text
            };

            int maxBytesNeeded = FaceTexture.Serializer.GetMaxSize(render);
            byte[] buffer = new byte[maxBytesNeeded];
            int bytesWritten = FaceTexture.Serializer.Write(buffer, render);

            File.WriteAllBytes("FaceTextures.jsfb", buffer);
        }
    }

    private void BrowseRenderPathButton_Click(object sender, System.EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "UI Render (*.dds)|*.dds";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DDSRenderFilePathTextBox.Text = openFileDialog.FileName;
            }
        }
    }

    private void SerializeDataButton_Click(object sender, EventArgs e)
    {
        SerializeData();
    }
}
