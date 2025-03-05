using UnityEngine;

public class PlaybackButton : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void Play()
    {
        _audioSource.Play();
    }
}