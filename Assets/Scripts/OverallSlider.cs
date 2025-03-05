public class OverallSlider : SliderVolume
{
    private const string OverallVolume = nameof(OverallVolume);

    public void SetOverallVolume(float value)
    {
        SetVolume(OverallVolume, value);
    }
}