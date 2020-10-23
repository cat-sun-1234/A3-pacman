using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    private static GameStart _instance;

    public static GameStart Instance { get { return _instance; } }


    private void Awake() //singleton don't double up
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    public AudioSource source;
    public AudioClip clip;
    public int highScore;
    public int prevTime; //this will be in seconds
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
        SceneManager.LoadScene("GameScene");

    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void ExitLevel()
    {
        SceneManager.LoadScene("StartScene");
    }
}
