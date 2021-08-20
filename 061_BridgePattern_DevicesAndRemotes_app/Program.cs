namespace _061_BridgePattern_DevicesAndRemotes_app
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            tv.TurnOn();

            tv.IncreaseVolume();
            tv.IncreaseVolume();
            tv.IncreaseVolume();
            tv.IncreaseVolume();
            tv.IncreaseVolume();
            tv.IncreaseVolume();

            tv.SetChanel(44);

            tv.OneUpChannel();
            tv.OneUpChannel();
            tv.OneUpChannel();
            tv.OneUpChannel();
            tv.OneUpChannel();

            tv.DisplayStates();
        }
    }
}

// CLIENT
public class Remote
{
    public IDevice _device;

    public Remote(IDevice device)
    {
        this._device = device;
    }
}


