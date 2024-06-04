using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMouth : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator top;
    public Animator bot;
    public bool isGameStarted;
    public AudioSource lever;
    public AudioSource mouth;
    public AudioSource growl;

    void Start()
    {
        isGameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
   

    }
    public void Open()
    {
        top.SetBool("tremol", true);
        bot.SetBool("open", true);
        isGameStarted = true;
        lever.Play();
        mouth.Play();
        growl.Play();
    }
}
