using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    GameObject Animal;
    GameObject MiamMiam;
    public Michel Michel;

    // Start is called before the first frame update
    void Start()
    {
        Animal = GameObject.FindGameObjectWithTag("Animal");
        MiamMiam = GameObject.FindGameObjectWithTag("MiamMiam");
    }

    public void ChooseAnimal(int Choosing)
    {
        if(Choosing == 1)
        {
            Michel.SetAnimal(new Cat(), Animal);
        }else if(Choosing == 2)
        {
            Michel.SetAnimal(new Penguin(), Animal);
        }
    }

    public void Manger()
    {
        Michel.animal.Nourriture(MiamMiam);
    }
}
