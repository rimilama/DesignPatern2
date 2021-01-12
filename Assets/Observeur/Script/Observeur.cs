using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observeur : IObserveur
{
    GameObject Box;
    float ForceBox;

    public Observeur(GameObject box, float eventbox)
    {
        this.Box = box;
        this.ForceBox = eventbox;
    }

    public void Update()
    {
        Box.GetComponent<Rigidbody>().AddForce(Vector3.up * ForceBox);
    }
}
