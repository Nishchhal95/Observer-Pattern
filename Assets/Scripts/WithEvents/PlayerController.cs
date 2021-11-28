using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WithEvents
{
    public class PlayerController : MonoBehaviour
    {
        //public static event Action onMouseClickOverPlayer;
        public static Action onMouseClick;
        public int a = 1;

        public Dictionary<int, Action> myDictionary = new Dictionary<int, Action>();
        
        private void OnMouseDown()
        {
            Debug.Log("Clicked Down!");
            //onMouseClickOverPlayer?.Invoke();
            onMouseClick?.Invoke();
            Func<int> abc = () =>
            {
                Debug.Log("Hello");
                return 0;
            };

            Action myAction = () =>
            {
                Debug.Log("Hello");
            };
            
            myAction?.Invoke();

            myAction = () =>
            {
                Debug.Log("Hello World");
            };

            //More Code
        }

        private void OnMouseUp()
        {
            //Debug.Log("Clicked Up!");
            //Notify(ActionType.ClickUp);
        }
    }
}

public class PlayerStats
{
    public int health;
    public string playerName;
    public float damageDealt;
    public float damageTaken;

    public PlayerStats(int health, string playerName, float damageDealt, float damageTaken)
    {
        this.health = health;
        this.playerName = playerName;
        this.damageDealt = damageDealt;
        this.damageTaken = damageTaken;
    }
}

