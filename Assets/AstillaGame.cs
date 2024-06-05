using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class AstillaGame : MonoBehaviour
{
    public GameObject diente;
    public List<GameObject> astilles;

    [HideInInspector] public bool breack = false;
    // Start is called before the first frame update
    void Start()
    {
        diente.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        breack = true;
        foreach (var item in astilles)
        {
            if (!item.GetComponent<Astilla>().isExtract)
            {
                breack = false;
            }
        }

        if (breack) Break();
    }

    public void Break()
    {
        diente.SetActive(true);
        gameObject.SetActive(false);
    }
}
