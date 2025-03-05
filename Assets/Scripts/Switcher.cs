public class Switcher : RegulatorVolume
{
    private const string MasterVolume = nameof(MasterVolume);

    private float _minValue = 0.0001f;
    private float _maxValue = 1f;
    private bool _isOn = true;

    private void Start()
    {
        SetMaxVolume();
    }

    public void Switch()
    {
        if (_isOn == true)
        {
            SetMinVolume();
            _isOn = false;
        }
        else
        {
            SetMaxVolume();
            _isOn = true;
        }
    }

    private void SetMinVolume()
    {
        SetVolume(MasterVolume, _minValue);
    }

    private void SetMaxVolume()
    {
        SetVolume(MasterVolume, _maxValue);
    }
}