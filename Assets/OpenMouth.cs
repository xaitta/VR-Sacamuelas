using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMouth : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator top;
    public Animator bot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   

    }
    public void Open()
    {
        top.SetBool("tremol", true);
        bot.SetBool("open", true);
    }
}
