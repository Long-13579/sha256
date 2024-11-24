using SHA256Lib;

namespace WinfromApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        label3.Text = "";
        label3.MaximumSize = new Size(panel3.Width, 0);
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        string originalText = textBox1.Text;

        if (originalText.Length == 0)
        {
            label3.Text = "Error: The input is null";
            return;
        }

        string hashText = Sha256.ComputeSHA256(originalText);

        label3.Text = hashText;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        textBox1.Text = "";
    }
}
