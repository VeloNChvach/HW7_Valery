using System;

class Doubler
{
    int number, count = 0;

    public Doubler()
    {
        number = 1;
    }

    public void Plus()
    {
        number++;
        count++;
    }

    public void Multi()
    {
        number *= 2;
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
}