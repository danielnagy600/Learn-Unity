using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LocalizedTMP : MonoBehaviour
{
    public string key;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(0.2f);
        ShowLocalizedText();

    }

    public void ShowLocalizedText()
    {
        TMP_Text text = GetComponent<TMP_Text>();
        text.text = LocalizationManager.instance.localizedText[key];
    }

}
