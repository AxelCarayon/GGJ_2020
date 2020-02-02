using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip backgroundSound, backgroundDarkSound, boutonPressSound, effacerSound, mouvementBlockSound, restartSound, victorySound;
    static AudioSource audioSrc; 

    // Start is called before the first frame update
    void Start()
    {
        backgroundSound = Resources.Load<AudioClip>("background");
        backgroundDarkSound = Resources.Load<AudioClip>("backgroundark");
        boutonPressSound = Resources.Load<AudioClip>("boutonPress");
        effacerSound = Resources.Load<AudioClip>("effacer1");
        mouvementBlockSound = Resources.Load<AudioClip>("mouvementBlock");
        restartSound = Resources.Load<AudioClip>("restart");
        victorySound = Resources.Load<AudioClip>("victory");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip){
        switch (clip)
        {
            case "background":
                audioSrc.PlayOneShot(backgroundSound);
                break;
            case "backgroundark":
                audioSrc.PlayOneShot(backgroundDarkSound);
                break;
            case "butonpress":
                audioSrc.PlayOneShot(boutonPressSound);
                break;
            case "effacer":
                audioSrc.PlayOneShot(effacerSound);
                break;
            case "mouvementBlock":
                audioSrc.PlayOneShot(mouvementBlockSound);
                break;
            case "restart":
                audioSrc.PlayOneShot(restartSound);
                break;
            case "victory":
                audioSrc.PlayOneShot(victorySound);
                break;
        }
    }
}
