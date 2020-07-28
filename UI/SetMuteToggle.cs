using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMuteToggle : MonoBehaviour
{
    public GameObject Contorller;
    public SettingsData CurrentSettingsData;
    private Toggle _muteToggle;
    AudioSource audioSource;


    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        CurrentSettingsData = Contorller.GetComponent<SettingsController>().CurrentSettingsData;
        _muteToggle = GetComponent<Toggle>();

        _muteToggle.isOn = CurrentSettingsData.Mute; 
        _muteToggle.onValueChanged.AddListener((value) =>OnMuteChanged(value));
    }

    private void OnMuteChanged(bool value)
    {
        CurrentSettingsData.Mute = value;
        audioSource.mute = value;
    }

    private void OnDestroy()
    {
        _muteToggle.onValueChanged.RemoveListener(OnMuteChanged);
    }
}
