using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SetTextureQualityDropdown : MonoBehaviour
{
    public SettingsData CurrentSettingsData;
    private TMP_Dropdown _textureQualityDropdown;
    public GameObject Contorller;

    private void Start()
    {
        CurrentSettingsData = Contorller.GetComponent<SettingsController>().CurrentSettingsData;
        _textureQualityDropdown = GetComponent<TMP_Dropdown>(); 

        _textureQualityDropdown.value = CurrentSettingsData.GraphicalQualityLevel; 
        _textureQualityDropdown.onValueChanged.AddListener(OnDropdownChanged);
       
    }

    private void OnDropdownChanged(int QualityLevel)
    {
        CurrentSettingsData.GraphicalQualityLevel = QualityLevel;
        QualitySettings.SetQualityLevel(QualityLevel, true);
    }

    private void OnDestroy()
    {
        _textureQualityDropdown.onValueChanged.RemoveListener(OnDropdownChanged);
    }
}
