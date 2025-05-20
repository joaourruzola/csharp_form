using System;
using System.Windows.Forms;

public class MyForm : Form
{
    public MyForm()
    {
        this.Text = "Cadastro de clientes";
        this.Width = 600;
        this.Height = 800;

        var Label = new Label()
        {
            Text = "Hello",
            AutoSize = true,
            Top = 50,
            Left = 50,

        };

        this.Controls.Add(Label);
    }
}