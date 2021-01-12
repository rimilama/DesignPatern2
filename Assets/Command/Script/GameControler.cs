using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public Transform BoxTransform;
    private Command ButZ, ButQ, ButS, ButD, ButA, ButE;
    
    // Start is called before the first frame update
    void Start()
    {
        ButZ = new Avancer();
        ButQ = new Gauche();
        ButS = new Reculer();
        ButD = new Droite();
        ButA = new Monter();
        ButE = new Descndre();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ButZ.Execute(BoxTransform);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            ButQ.Execute(BoxTransform);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ButS.Execute(BoxTransform);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ButD.Execute(BoxTransform);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            ButA.Execute(BoxTransform);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ButE.Execute(BoxTransform);
        }
    }
}
