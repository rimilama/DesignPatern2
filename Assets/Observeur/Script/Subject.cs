using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : ISubject
{
    private List<IObserveur> _observeur = new List<IObserveur>();

    public void Attach(IObserveur observeur)
    {
        this._observeur.Add(observeur);
    }

    public void Remove(IObserveur observeur)
    {
        this._observeur.Remove(observeur);
    }

    public void Notify()
    {
        foreach(var observeur in _observeur)
        {
            observeur.Update();
        }
    }
}
