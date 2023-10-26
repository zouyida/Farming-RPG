using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ObscuringItemFader : MonoBehaviour
{
    private SpriteRenderer spritRenderer;

    private void Awake()
    {
        spritRenderer = GetComponent<SpriteRenderer>();
    }

    public void FadeIn()
    {
        StartCoroutine(FadeInRoutine());
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutRoutine());
    }

    private IEnumerator FadeOutRoutine()
    {
        float currentAlpha = spritRenderer.color.a;
        float delta = currentAlpha - Settings.targetAlpha;
        while (currentAlpha - Settings.targetAlpha > 0.01f)
        {
            currentAlpha -= delta / Settings.fadeOutTime * Time.deltaTime;
            spritRenderer.color = new Color(1f, 1f, 1f, currentAlpha);
            yield return null;
        }

        spritRenderer.color = new Color(1f, 1f, 1f, Settings.targetAlpha);
    }

    private IEnumerator FadeInRoutine()
    {
        float currentAlpha = spritRenderer.color.a;
        float delta = 1f - currentAlpha;
        while (1f - currentAlpha > 0.01f)
        {
            currentAlpha += delta / Settings.fadeInTime * Time.deltaTime;
            spritRenderer.color = new Color(1f, 1f, 1f, currentAlpha);
            yield return null;
        }

        spritRenderer.color = new Color(1f, 1f, 1f, 1f);
    }
}
