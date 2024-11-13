using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToUse : MonoBehaviour
{
    /*
    1. Clone the project or download audio Manager and Sound Class
    2. Create an empty game object and name it AudioManager
    3. Add the Audio Manager Script to the AudioManager game object 
    4. Under the Sound List all the sound effects or Background Music you intend to use in your game
    5. Under each script that is supposed to play the sound from do the following :
        i. Reference the Audio Manager < private AudioManager audioM;>
        ii. Get an instance of the Audio Manager in the Start Method < audioM = AudioManager.instance;>
        iii. Under each Function where the sound is to be played use < audioM.Play("sfxName");>  to play 
            sound effects and < audioM.PlayBackgroundMusic("BGName")> to play background music
        iv. Under sfxName and BGName replace with the name you gane each sfx in the audio manager
    6. If new sounds are added in add them on the audio manager prefab
    7. Add the audio manager to the first level and ensure you have implemented scene transition properly 
        to ensure the singleton instance is mainatined throuhout the scenes 

    */
}
