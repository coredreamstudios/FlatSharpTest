namespace FlatSharpTest;

public partial class Form1 : Form
{
    Basics b = new Basics();    

    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        b.Run();
    }
}
