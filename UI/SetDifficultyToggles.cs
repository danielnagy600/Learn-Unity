using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetDifficultyToggles : MonoBehaviour
{
    public GameObject SettingsContorller;
    public SettingsData CurrentSettingsData;

    public GameObject Easy;
    public GameObject Medium;
    public GameObject Hard;

    private List<Toggle> _difficultyLevels = new List<Toggle>();

    private void Start()
    {
        _difficultyLevels.Add(Easy.GetComponent<Toggle>());
        _difficultyLevels.Add(Medium.GetComponent<Toggle>());
        _difficultyLevels.Add(Hard.GetComponent<Toggle>());

        CurrentSettingsData = SettingsContorller.GetComponent<SettingsController>().CurrentSettingsData;

        for (int i = 0; i < 3; i++)
        {
            if (i == CurrentSettingsData.Difficulty) _difficultyLevels[i].isOn = true;
        }

        _difficultyLevels[0].onValueChanged.AddListener((value) => OnEasyChanged(value));
        _difficultyLevels[1].onValueChanged.AddListener((value) => OnMediumChanged(value));
        _difficultyLevels[2].onValueChanged.AddListener((value) => OnHardChanged(value));

    }

    private void OnEasyChanged(bool value)
    {
        if (value)
        {
            CurrentSettingsData.Difficulty = 0;
        }

    }

    private void OnMediumChanged(bool value)
    {
        if (value)
        {
            CurrentSettingsData.Difficulty = 1;
        }

    }
    private void OnHardChanged(bool value)
    {
        if (value)
        {
            CurrentSettingsData.Difficulty = 2;
        }

    }

    private void OnDestroy()
    {
       _difficultyLevels[0].onValueChanged.RemoveListener((value) => OnEasyChanged(value));
       _difficultyLevels[1].onValueChanged.RemoveListener((value) => OnMediumChanged(value));
       _difficultyLevels[2].onValueChanged.AddListener((value) => OnHardChanged(value));
    }
}
