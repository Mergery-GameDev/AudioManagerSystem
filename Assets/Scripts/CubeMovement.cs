using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public GameObject[] cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            Debug.Log("E");
        }
        else if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F");
        }
        else if(Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("J");
        }
        
    }
}
