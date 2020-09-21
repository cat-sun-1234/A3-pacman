using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        source.Stop();
        source.clip = clip;
        source.Play();
        SceneManager.LoadScene("SampleScene");

    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
