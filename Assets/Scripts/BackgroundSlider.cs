public class BackgroundSlider : SliderVolume
{
    private const string BackgroundVolume = nameof(BackgroundVolume);

    public void SetBackgroundVolume(float value)
    {
        SetVolume(BackgroundVolume, value);
    }
}