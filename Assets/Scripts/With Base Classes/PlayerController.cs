using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WithBaseClass
{
    public class PlayerController : Subject
    {
        private void OnEnable()
        {
            Observer[] sceneObservers = FindObjectsOfType<Observer>();
            for (int i = 0; i < sceneObservers.Length; i++)
            {
                RegisterObserver(sceneObservers[i]);
            }
        }

        private void OnDisable()
        {
            Observer[] sceneObservers = FindObjectsOfType<Observer>();
            for (int i = 0; i < sceneObservers.Length; i++)
            {
                DeRegisterObserver(sceneObservers[i]);
            }
        }

        private void OnMouseDown()
        {
            Debug.Log("Clicked Down!");
            Notify(ActionType.ClickDown);
        }

        private void OnMouseUp()
        {
            //Debug.Log("Clicked Up!");
            //Notify(ActionType.ClickUp);
        }
    }
}
