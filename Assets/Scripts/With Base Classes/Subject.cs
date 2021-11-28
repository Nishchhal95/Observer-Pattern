using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private List<Observer> observers = new List<Observer>();
    public void RegisterObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void DeRegisterObserver(Observer observer)
    {
        observers.Remove(observer);
    }

    public void Notify(ActionType actionType)
    {
        for (int i = 0; i < observers.Count; i++)
        {
            observers[i].OnNotify(actionType);
        }
    }
}

public enum ActionType
{
    ClickDown,
    ClickUp
}
