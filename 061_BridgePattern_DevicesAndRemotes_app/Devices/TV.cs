using System;

public class TV : Device, IDevice
{
    private int _chanel;
    private int _lastChanel;
    private int _volume;

    public int Chanel
    {
        get { return _chanel; }
    }

    public int LastChanel
    {
        get { return _lastChanel; }
    }

    public int Volume
    {
        get { return _volume; }
    }

    public TV()
    {
        _volume = 25;
        _lastChanel = 1;
        _chanel = 1;
        DisplayStates();
    }

    public void TurnOf()
    {
        if (IsOn)
        {
            IsOn = false;
            Console.WriteLine("TV turned OFF.");
        }
    }

    public void TurnOn()
    {
        if (!IsOn)
        {
            IsOn = true;
            Console.WriteLine("TV turned ON");
        }
    }
    public void SetChanel(int chanelNumber)
    {
        if (IsOn)
        {
            _lastChanel = _chanel;
            _chanel = chanelNumber;
        }
        else
        {
            Console.WriteLine("The TV is off.");
        }
    }

    public void OneUpChannel()
    {
        if (IsOn)
        {
            if (_chanel < 100)
            {
                _lastChanel = _chanel;
                _chanel++;
            }
        }
        else
        {
            Console.WriteLine("The TV is off.");
        }
    }
    public void OneDownChanel()
    {
        if (IsOn)
        {
            if (_chanel > 0)
            {
                _lastChanel = _chanel;
                _chanel--;
            }
        }
        else
        {
            Console.WriteLine("The TV is off.");
        }
    }

    public int GetChanel()
    {
        if (IsOn)
        {
            return _chanel;
        }
        else
        {
            Console.WriteLine("The TV is off.");
            return 0;
        }
    }

    public void IncreaseVolume()
    {
        if (IsOn)
        {
            if (_volume < 100) _volume++;
        }
        else
        {
            Console.WriteLine("The TV is off.");
        }
    }

    public void DecreaseVolume()
    {
        if (IsOn)
        {
            if (_volume > 0) _volume--;
        }
        else
        {
            Console.WriteLine("The TV is off.");
        }
    }

    public int GetVolume()
    {
        if (IsOn)
        {
            return _volume;
        }
        else
        {
            Console.WriteLine("The TV is off.");
            return 0;
        }
    }

    public void DisplayStates()
    {
        Console.WriteLine($"Volume: {_volume}");
        Console.WriteLine($"LastChanel: {_lastChanel}");
        Console.WriteLine($"Chanel: {_chanel}");
    }








}


