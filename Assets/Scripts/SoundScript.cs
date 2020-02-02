using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{

    public AudioSource background;
    public AudioSource backgroundark;
    public AudioSource boutonPress;
    public AudioSource effacer1;
    public AudioSource mouvementBlock;
    public AudioSource restart;
    public AudioSource victory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayBackground(){
        background.Play();
        background.loop = true;
    }
        public void PlayBackgroundDark(){
        backgroundark.Play();
    }
        public void PlayBoutonPress(){
        boutonPress.Play();
    }
        public void PlayEffacer(){
        effacer1.Play();
    }
        public void PlayMouvementBlock(){
        mouvementBlock.Play();
    }
        public void PlayRestart(){
        restart.Play();
    }
        public void PlayVictory(){
        victory .Play();
    }
}
