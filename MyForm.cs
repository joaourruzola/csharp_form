/*
video que está sendo seguido nese projeto
https://www.youtube.com/watch?v=wCvICwWJS5k&list=PLKkX54_jcM44qN1qkdE1wfkuitOLrnOl2&index=2 
*/

using System;
using System.Windows.Forms;

public class MyForm : Form
{
    public MyForm()
    {
        this.Text = "Cadastro de clientes";
        this.Width = 800;
        this.Height = 600;
        this.ShowIcon = false;

        var Label = new Label()
        {
            Text = "Cliente",
            AutoSize = true,
            Top = 50,
            Left = 50,

        };

        this.Controls.Add(Label);
    }
}