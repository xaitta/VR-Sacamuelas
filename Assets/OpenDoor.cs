using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OpenDoor : MonoBehaviour
{
    public int TeethPlaced = 0;
    [SerializeField]
    UnityEvent OnGameFinish = new UnityEvent();
    public AudioSource portaobra;
    public AudioSource portatanca;

    public Animator Anim;
    void Start()
    {
        TeethPlaced = 0;
    }

    public void AddTooth()
    {
        TeethPlaced++;
        if(TeethPlaced == 8)
        {
            OnGameFinish.Invoke();
            Anim.SetBool("Open", true);
            portaobra.Play();
        }
    }
}
