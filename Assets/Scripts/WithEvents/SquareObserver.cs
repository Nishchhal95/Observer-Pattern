using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WithEvents
{
    public class SquareObserver : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private Color originalColor;
        [SerializeField] private Color targetColor = Color.white;

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            originalColor = spriteRenderer.color;
        }

        private void OnEnable()
        {
            //PlayerController.onMouseClickOverPlayer += OnMouseClickedOverPlayer;
            //PlayerController.onMouseClick += OnMouseClickedOverPlayer;
            PlayerController.onMouseClick += OnMouseCLick;
        }

        private void OnDisable()
        {
            //PlayerController.onMouseClickOverPlayer -= OnMouseClickedOverPlayer;
            //PlayerController.onMouseClick -= OnMouseClickedOverPlayer;
            PlayerController.onMouseClick -= OnMouseCLick;
        }

        private void OnMouseClickedOverPlayer()
        {
            Debug.Log("Changing Color");
            StartCoroutine(OnNotifyRoutine());
        }

        private IEnumerator OnNotifyRoutine()
        {
            spriteRenderer.color = targetColor;

            yield return new WaitForSecondsRealtime(1f);

            spriteRenderer.color = originalColor;
        }

        public void OnMouseCLick()
        {
            Debug.Log("Hello");
        }
    }
}
