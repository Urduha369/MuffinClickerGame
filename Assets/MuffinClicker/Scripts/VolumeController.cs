using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeController : MonoBehaviour
{
    [SerializeField]
    Slider _volumeSlider;

    public void OnVolumeChanged()

    {
        AudioListener.volume = _volumeSlider.value;

        Debug.Log(_volumeSlider.value);

            //("Volume changed Be Happy");
    }
} 
