using UnityEngine;
using UnityEngine.UI;


public class SliderVolume : RegulatorVolume
{
    [SerializeField] private Slider _slider;

    private float _startValue = 0.5f;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _slider.value = _startValue;
    }
}