using System;
using System.Windows.Forms;
using System.Threading;

class Doubler
{
    int number, count = 0, back, answer;

    public Doubler()
    {
        number = 1;
        back = number;
    }

    public void Plus()
    {
        back = number;
        number++;
        count++;
    }

    public void Multi()
    {
        back = number;
        number *= 2;
        count++;
    }

    public void Back()
    {
        number = back;
        count++;
    }

    public string Number
    {
        get { return number.ToString(); }
    }

    public string Count
    {
        get { return $"Number of turns: {count}"; }
    }

    public int Answer
    {
        get { return answer; }
        set { answer = value; }
    }

    public void checkAns()
    {
        if (number == answer)
        {
            MessageBoxButtons mes = MessageBoxButtons.OK;
            DialogResult res = MessageBox.Show($"Вы получили нужное число за {count} ходов", "Результат игры", mes);
            if (res == DialogResult.OK)
                Application.Exit();
        }
            
    }
}