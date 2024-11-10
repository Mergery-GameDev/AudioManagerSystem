using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private AudioManager audioM;
    private Scene scene;
    public bool isGameOver;

    [Header("Sounds")]
    [SerializeField]
    private string levelBGSound;

    [Header("Levels To Load")]
    [SerializeField]
    private string levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        audioM = AudioManager.instance;

        audioM.PlayBackgroundMusic(levelBGSound);

        scene = SceneManager.GetActiveScene();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(scene.name == "MainGame" && isGameOver)
        {
            LoadScene();
        }

    
    }

    public void LoadScene()
    {
        isGameOver= false;
        SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
        
    }

}
