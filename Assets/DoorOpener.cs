using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{

    public int PlacedTooth = 0;
    bool isopen;
    void Start()
    {
        PlacedTooth = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlacedTooth == 8)
        {
            transform.Rotate(Vector3.up, 90f);
            PlacedTooth = 9;
        }

    }

    public void AddTooth()
    {
        PlacedTooth++;
    }
}
