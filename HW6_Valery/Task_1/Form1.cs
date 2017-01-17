using System;
using System.Windows.Forms;

class Form1: Form
{
    Button btnPlus, btnMulti;
    Label lblNumber, lblCount;
    Doubler doubler = new Doubler();

    public Form1()
    {
        create_btnPlus();
        create_btnMulti();
        create_lblNumber();
        create_lblCount();
    }

    private void create_btnPlus()
    {
        btnPlus = new Button();
        btnPlus.Text = "+1";
        btnPlus.Left = 10;
        btnPlus.Top = 10;
        btnPlus.Parent = this;
        btnPlus.Click += BtnPlus_Click;
    }

    private void BtnPlus_Click(object sender, EventArgs e)
    {
        doubler.Plus();
        lblNumber.Text = doubler.Number;
        lblCount.Text = doubler.Count;
    }

    private void create_btnMulti()
    {
        btnMulti = new Button();
        btnMulti.Text = "x2";
        btnMulti.Left = 10;
        btnMulti.Top = 40;
        btnMulti.Parent = this;
        btnMulti.Click += BtnMulti_Click;
    }

    private void BtnMulti_Click(object sender, EventArgs e)
    {
        doubler.Multi();
        lblNumber.Text = doubler.Number;
        lblCount.Text = doubler.Count;
    }

    private void create_lblNumber()
    {
        lblNumber = new Label();
        lblNumber.Left = 150;
        lblNumber.Top = 10;
        lblNumber.Text = "1";
        lblNumber.Parent = this;
    }

    private void create_lblCount()
    {
        lblCount = new Label();
        lblCount.Left = 150;
        lblCount.Top = 40;
        lblCount.Width = 110;
        lblCount.Text = "Number of turns: 0";
        lblCount.Parent = this;
    }
}