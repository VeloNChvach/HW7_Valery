using System;
using System.Windows.Forms;

class Form1: Form
{
    Button btnPlus, btnMulti, btnBack;
    Label lblNumber, lblCount, lblAnswer;
    Doubler doubler = new Doubler();

    public Form1()
    {
        create_Menu();
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
        btnBack.Enabled = true;
        doubler.checkAns();
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
        btnBack.Enabled = true;
        doubler.checkAns();
    }

    private void create_lblNumber()
    {
        lblNumber = new Label();
        lblNumber.Left = 150;
        lblNumber.Top = 10;
        lblNumber.Text = "1";
        lblNumber.Parent = this;
    }

    private void create_lblAns()
    {
        lblAnswer = new Label();
        lblAnswer.Left = 150;
        lblAnswer.Top = 40;
        lblAnswer.Text = doubler.Answer.ToString();
        lblAnswer.Parent = this;
    }

    private void create_lblCount()
    {
        lblCount = new Label();
        lblCount.Left = 150;
        lblCount.Top = 70;
        lblCount.Width = 150;
        lblCount.Text = "Number of turns: 0";
        lblCount.Parent = this;
    }

    private void create_btnBack()
    {
        btnBack = new Button();
        btnBack.Left = 10;
        btnBack.Top = 100;
        btnBack.Text = "Back";
        btnBack.Parent = this;
        btnBack.Click += BtnBack_Click;
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        doubler.Back();
        lblNumber.Text = doubler.Number;
        lblCount.Text = doubler.Count;
        btnBack.Enabled = false;
    }

    private void create_Menu()
    {
        MainMenu mnuFileMenu = new MainMenu();
        Menu = mnuFileMenu;

        MenuItem myMenuItemFile = new MenuItem("Menu");
        MenuItem myMenuItemNew = new MenuItem("New game");

        mnuFileMenu.MenuItems.Add(myMenuItemFile);
        myMenuItemFile.MenuItems.Add(myMenuItemNew);

        myMenuItemNew.Click += MyMenuItemNew_Click;
    }

    private void MyMenuItemNew_Click(object sender, EventArgs e)
    {
        Random rnd = new Random();
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        int res = rnd.Next(2, 101);
        doubler.Answer = res;
        DialogResult result = MessageBox.Show($"Вы должны получить число {res}", "MessageBox", buttons);

        if (result == DialogResult.Yes)
            this.Close();

        create_btnPlus();
        create_btnMulti();
        create_lblNumber();
        create_lblCount();
        create_btnBack();
        create_lblAns();
    }
}