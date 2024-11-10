using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    private AudioManager audioM;

    [Header("Sounds")]
    [SerializeField]
    private string mainMenuSound;

    // Start is called before the first frame update
    void Start()
    {
        audioM = AudioManager.instance;

        audioM.PlayBackgroundMusic(mainMenuSound);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
