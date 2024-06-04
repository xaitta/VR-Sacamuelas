using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caries : MonoBehaviour
{

    [HideInInspector] public bool destroyed = false;
    // Start is called before the first frame update

    public AudioSource ponk;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Hammer"))
        {
            destroyed = true;
            Debug.Log("Machaaaaaka!!!!");
            gameObject.SetActive(false);
            ponk.Play();
        }
    }
}
