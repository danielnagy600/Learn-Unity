using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class SettingsController : MonoBehaviour
{
    private const string _settingsDataKey = "LocationOfStoredData";
    public SettingsData CurrentSettingsData;
   
    private IEnumerator Start()
    {
        
        CurrentSettingsData = JsonConvert.DeserializeObject<SettingsData>(PlayerPrefs.GetString(_settingsDataKey));
        if (CurrentSettingsData== null)
        {
            CurrentSettingsData = new SettingsData();   
            CurrentSettingsData.GraphicalQualityLevel =0;
            CurrentSettingsData.Difficulty = 0;
            CurrentSettingsData.Language = 0;
            CurrentSettingsData.Volume = 0;
            CurrentSettingsData.Mute = true;
        }
        yield return new WaitForSeconds(0.1f);
        SetCurrentLanguage();
    }

    public void SetCurrentLanguage()
    {
        switch (CurrentSettingsData.Language)
        {
            case 0:
                LocalizationManager.instance.LoadLocalizedText("localizedText_en.json");
                break;
            case 1:
                LocalizationManager.instance.LoadLocalizedText("localizedText_de.json");
                break;
            case 2:
                LocalizationManager.instance.LoadLocalizedText("localizedText_hun.json");
                break;
        }
    }


    public void SaveSettings()
    {
        PlayerPrefs.SetString(_settingsDataKey, JsonConvert.SerializeObject(CurrentSettingsData));
        PlayerPrefs.Save();
    }
  
}
