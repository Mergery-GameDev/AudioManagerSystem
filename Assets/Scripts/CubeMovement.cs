using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private AudioManager audioM;

    

    [Header("Key Bindings")]
    [SerializeField]
    private KeyCode jumpKey;

    [Header("Sound")]
    [SerializeField]
    private string jumpSound;



    // Start is called before the first frame update
    void Start()
    {
        audioM = AudioManager.instance;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(jumpKey))
        {
            transform.Translate(Vector3.up*0.5f);
            audioM.Play(jumpSound);
        }
        
    }
}
