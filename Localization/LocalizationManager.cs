using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class LocalizationManager : MonoBehaviour
{
    public static LocalizationManager instance;
    public Dictionary<string, string> localizedText;


    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public  void LoadLocalizedText(string fileName)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);
        localizedText = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(filePath));
    }

}
