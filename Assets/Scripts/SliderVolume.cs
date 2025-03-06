using UnityEngine;
using UnityEngine.UI;


public class SliderVolume : RegulatorVolume
{
    [SerializeField] private Slider _slider;
    [SerializeField] private string _name;

    private float _startValue = 0.5f;

    private void Start()
    {
        Init();
    }

    public void SetVolume(float value)
    {
        SetVolume(_name, value);
    }

    private void Init()
    {
        _slider.value = _startValue;
    }
}