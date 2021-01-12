using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Michel : MonoBehaviour
{
    public IAnimal animal;
    public GameObject animalObj;

    public void SetAnimal(IAnimal animal, GameObject Pos)
    {
        if(this.animal != null)
        {
            Destroy(animalObj);
        }
        this.animal = animal;
        animalObj = this.animal.CreateAnimal(Pos);
    }
}
