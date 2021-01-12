using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    GameObject Animal;
    public Michel Michel;

    // Start is called before the first frame update
    void Start()
    {
        Animal = GameObject.FindGameObjectWithTag("Animal");
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
}
