using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    void Attach(IObserveur observeur);
    void Remove(IObserveur observeur);
    void Notify();
}
