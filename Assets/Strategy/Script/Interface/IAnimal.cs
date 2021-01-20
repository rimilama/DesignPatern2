using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimal 
{
    GameObject CreateAnimal(GameObject Animal);
    void Nourriture(GameObject MiamMiam);
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
    
    public void Nourriture(GameObject MiamMiam)
    {
        MiamMiam.GetComponent<SpriteRenderer>().sprite = Resources.Load("_anger_cat", typeof(Sprite)) as Sprite;
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

    public void Nourriture(GameObject MiamMiam)
    {
        MiamMiam.GetComponent<SpriteRenderer>().sprite = Resources.Load("_anger_ping", typeof(Sprite)) as Sprite;
    }
}