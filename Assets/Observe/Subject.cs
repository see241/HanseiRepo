using UnityEngine;
using System.Collections;
using System.Collections.Generic;




public class Subject : MonoBehaviour, IObserverSubject
{
    List<Observer> _observerList = new List<Observer>();
    Transform _tr;
    CubeActor _cube;

    void Start()
    {
        _tr = gameObject.transform;

        _cube = new CubeActor();
        AddObserver(_cube);

        StartCoroutine(UpdateGoingUp());
    }

    IEnumerator UpdateGoingUp()
    {
        while (true)
        {
            _tr.position = new Vector3(_tr.position.x, _tr.position.y + 0.05f, _tr.position.z);

            if (_tr.position.y > 3f)
            {
                Notify(); //noti to observers
                yield break;
            }
            yield return null;
        }
    }

    public void Notify()
    {
        for (int i = 0; i < _observerList.Count; i++)
        {
            _observerList[i].OnNotify();
        }
    }

    public void AddObserver(Observer ob)
    {
        _observerList.Add(ob);
    }

    public void RemoveObserver(Observer ob)
    {
        _observerList.Remove(ob);
    }
}