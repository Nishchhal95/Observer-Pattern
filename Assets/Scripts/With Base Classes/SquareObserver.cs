using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WithBaseClass
{
    public class SquareObserver : Observer
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private Color originalColor;
        [SerializeField] private Color targetColor = Color.white;

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            originalColor = spriteRenderer.color;
        }

        public override void OnNotify(ActionType actionType)
        {
            StartCoroutine(OnNotifyRoutine());
        }

        private IEnumerator OnNotifyRoutine()
        {
            spriteRenderer.color = targetColor;

            yield return new WaitForSecondsRealtime(1f);

            spriteRenderer.color = originalColor;
        }
    }
}
