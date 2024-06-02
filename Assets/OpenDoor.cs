using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OpenDoor : MonoBehaviour
{
    public int TeethPlaced = 0;
    [SerializeField]
    UnityEvent OnGameFinish = new UnityEvent();
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
            OnGameFinish.Invoke();
        }
    }
}
