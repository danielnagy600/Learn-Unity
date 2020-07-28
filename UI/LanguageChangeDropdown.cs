using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageChangeDropdown : MonoBehaviour
{
    public SettingsData CurrentSettingsData;
    private TMP_Dropdown _languageChangeDropdown;
    public GameObject SettingsContorller;

    private void Start()
    {
        CurrentSettingsData = SettingsContorller.GetComponent<SettingsController>().CurrentSettingsData;
        _languageChangeDropdown = GetComponent<TMP_Dropdown>();
        _languageChangeDropdown.value = CurrentSettingsData.Language;
        _languageChangeDropdown.onValueChanged.AddListener(DropdownChanged);
    }

    private void DropdownChanged(int LanguageIndex)
    {
        CurrentSettingsData.Language = LanguageIndex;
    }

    private void OnDestroy()
    {
        _languageChangeDropdown.onValueChanged.RemoveListener(DropdownChanged);
    }
}
