public class ButtonSlider : SliderVolume
{
    private const string ButtonVolume = nameof(ButtonVolume);

    public void SetButtonVolume(float value)
    {
        SetVolume(ButtonVolume, value);
    }
}