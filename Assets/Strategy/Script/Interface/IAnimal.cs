using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimal 
{
    GameObject CreateAnimal(GameObject Animal);
}

public class Cat : MonoBehaviour, IAnimal
{
    public GameObject CreateAnimal(GameObject Animal)
    {
        Animal = Instantiate(Resources.Load("Cat", typeof(GameObject))) as GameObject;
        Animal.transform.position = new Vector3(-2, -1, 0);
        Animal.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        Animal.transform.Rotate(0, 180, 0);
        return Animal;
    }
}

public class Penguin : MonoBehaviour, IAnimal
{
    public GameObject CreateAnimal(GameObject Animal)
    {
        Animal = Instantiate(Resources.Load("penguin", typeof(GameObject))) as GameObject;
        Animal.transform.position = new Vector3(-2, -1, 0);
        Animal.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        Animal.transform.Rotate(0, 90, 0);
        return Animal;
    }
}