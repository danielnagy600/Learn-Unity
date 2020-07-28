using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVolumeSlider : MonoBehaviour
{
    public GameObject Contorller;
    public SettingsData CurrentSettingsData;

    private Slider _volumeChange;
    AudioSource audioSource;


    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        CurrentSettingsData = Contorller.GetComponent<SettingsController>().CurrentSettingsData;
        _volumeChange = GetComponent<Slider>();
        if (CurrentSettingsData != null)
            _volumeChange.value = CurrentSettingsData.Volume;
        _volumeChange.onValueChanged.AddListener(value => OnVoumeChanged(value));
    }

    private void OnVoumeChanged(float value)
    {
        CurrentSettingsData.Volume = (int)value;
        audioSource.volume = value/10;
    }

    private void OnDestroy()
    {
        _volumeChange.onValueChanged.RemoveListener(OnVoumeChanged);
    }
}
