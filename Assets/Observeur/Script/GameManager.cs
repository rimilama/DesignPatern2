using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject box1;
    public GameObject box2;

    Subject subject = new Subject();
    
    void Start()
    {
        Observeur observ1 = new Observeur(box1, 100f);
        Observeur observ2 = new Observeur(box2, 200f);
        subject.Attach(observ1);
        subject.Attach(observ2);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            subject.Notify();
        }
    }
}
