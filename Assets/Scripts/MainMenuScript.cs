using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private AudioManager audioM;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(levelToLoad);
    }


}
