using UnityEngine;
using UnityEngine.Audio;

public class RegulatorVolume : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;

    private int _multiplier = 20;

    protected void SetVolume(string name, float value)
    {
        _mixerGroup.audioMixer.SetFloat(name, Mathf.Log10(value) * _multiplier);
    }
}