using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator close;
    public AudioSource closeSFX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        close.SetBool("Close", true);
        closeSFX.Play();
        gameObject.SetActive(false);
    }
}
