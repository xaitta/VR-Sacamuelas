using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int TeethPlaced = 0;
    void Start()
    {
        TeethPlaced = 0;
    }

    public void AddTooth()
    {
        TeethPlaced++;
        if(TeethPlaced == 8)
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
    }
}
