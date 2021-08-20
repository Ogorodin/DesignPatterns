public interface IDevice
{
    public void TurnOn();
    public void TurnOf();
    public int GetVolume();
    public void IncreaseVolume();
    public void DecreaseVolume();
    public int GetChanel();
    public void OneUpChannel();
    public void OneDownChanel();
    public void SetChanel(int chanelNumber);
}


