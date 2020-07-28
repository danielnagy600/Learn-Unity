using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private AudioSource Audio;
    public AudioClip GameHorrorMusic;

    public  void Awake()
    {
        Audio = GetComponent<AudioSource>();
    }

    public void Start()
    {
        if (SceneManager.GetSceneByName("Game").IsValid())
        {
            Audio.GetComponent<MusicManager>().ChangeAudio(GameHorrorMusic);
        } 
    }



    public void ChangeAudio(AudioClip NewAudio)
    {
        Audio.Stop();
        Audio.clip = NewAudio;
        Audio.Play();
    }

}
