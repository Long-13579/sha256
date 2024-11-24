namespace WinfromApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        panel1 = new Panel();
        button1 = new Button();
        textBox1 = new TextBox();
        label1 = new Label();
        tableLayoutPanel3 = new TableLayoutPanel();
        panel2 = new Panel();
        label2 = new Label();
        panel3 = new Panel();
        label3 = new Label();
        button2 = new Button();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
        tableLayoutPanel1.Location = new Point(12, 12);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(776, 426);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(panel1, 0, 1);
        tableLayoutPanel2.Location = new Point(158, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new Size(459, 207);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ControlLight;
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(label1);
        panel1.Location = new Point(3, 106);
        panel1.Name = "panel1";
        panel1.Size = new Size(453, 98);
        panel1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(91, 56);
        button1.Name = "button1";
        button1.Size = new Size(121, 42);
        button1.TabIndex = 2;
        button1.Text = "Hash";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(105, 17);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(345, 27);
        textBox1.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(3, 20);
        label1.Name = "label1";
        label1.Size = new Size(96, 20);
        label1.TabIndex = 0;
        label1.Text = "Original Text";
        label1.Click += label1_Click;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(panel2, 0, 1);
        tableLayoutPanel3.Controls.Add(panel3, 0, 2);
        tableLayoutPanel3.Location = new Point(158, 216);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 4;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel3.Size = new Size(459, 207);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.ActiveCaption;
        panel2.Controls.Add(label2);
        panel2.Location = new Point(3, 23);
        panel2.Name = "panel2";
        panel2.Size = new Size(453, 25);
        panel2.TabIndex = 0;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(3, 0);
        label2.Name = "label2";
        label2.Size = new Size(134, 25);
        label2.TabIndex = 0;
        label2.Text = "SHA-256 Hash";
        // 
        // panel3
        // 
        panel3.BackColor = SystemColors.ControlLight;
        panel3.Controls.Add(label3);
        panel3.Location = new Point(3, 54);
        panel3.Name = "panel3";
        panel3.Size = new Size(453, 107);
        panel3.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(3, 0);
        label3.Name = "label3";
        label3.Size = new Size(55, 23);
        label3.TabIndex = 0;
        label3.Text = "label3";
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button2.Location = new Point(259, 56);
        button2.Name = "button2";
        button2.Size = new Size(121, 42);
        button2.TabIndex = 3;
        button2.Text = "Clear";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tableLayoutPanel1);
        Name = "Form1";
        Text = "Form1";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        tableLayoutPanel3.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private TextBox textBox1;
    private Label label1;
    private Panel panel1;
    private Button button1;
    private TableLayoutPanel tableLayoutPanel3;
    private Panel panel2;
    private Label label2;
    private Panel panel3;
    private Label label3;
    private Button button2;
}
