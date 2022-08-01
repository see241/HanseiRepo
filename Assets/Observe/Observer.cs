using UnityEngine;
using System.Collections;


public interface IObserverSubject
{
    void Notify();
    void AddObserver(Observer ob);
    void RemoveObserver(Observer ob);
}

public abstract class Observer
{
    public abstract void OnNotify();
}