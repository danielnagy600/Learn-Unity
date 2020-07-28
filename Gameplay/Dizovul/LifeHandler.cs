using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeHandler : MonoBehaviour
{
    private SettingsController _settingsController;
    public GameObject DiePrefab;

    void Start()
    {
        _settingsController = FindObjectOfType<SettingsController>();
        
        if (_settingsController.CurrentSettingsData.Difficulty == 0) Life = 8;  
        else if (_settingsController.CurrentSettingsData.Difficulty == 1) Life = 5;
        else Life = 2;
    }

    private int _life;
    public int Life
    {
        set
        {
            if ((_life + value) > 8) _life = 8;
            else if (_life+value <= 0) {
                _life = 0;
                Die();
            } 
            else _life = value + _life;
            FindObjectOfType<Slider>().value = _life;
            Debug.Log(_life);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetType() == typeof(SphereCollider) && other.tag =="Muccer")
        {
            Life = -2;
        }
    }


    public void Die()
    {
        GetComponent<Animator>().SetBool("isDying",true);
        StartCoroutine(ShowDiePicture());
    }

    public   IEnumerator ShowDiePicture()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(DiePrefab);

    }

}
