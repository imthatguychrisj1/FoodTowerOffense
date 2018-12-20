using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public Vector2 startPoint;
    public Texture2D[] images;
    public float hitPoints = 0f;
    public float maxHitPoints = 0f;
    public bool isPlayer = false;

    public float HitPoints { get { return hitPoints; } set { hitPoints = Mathf.Clamp(value, 0, maxHitPoints); } }

    public void ModifyHitPoints(int amount)
    {
        HitPoints += amount;
    }

    private Texture2D GetHealthBarImage(float normalizedHealth)
    {
        for (int i = 0; i < images.Length; ++i)
        {
            if (normalizedHealth >= 1f - (1f / (images.Length) * i))
            {
                return images[i];
            }
        }
        return null;
    }

    private void OnGUI()
    {
        if (!isPlayer)
        {
            return;
        }

        float normalizedHealth = hitPoints / maxHitPoints;

        GUILayout.BeginArea(new Rect(
            startPoint.x,
            startPoint.y,
            Screen.width - startPoint.x,
            Screen.height - startPoint.y));
        GUILayout.Label(GetHealthBarImage(normalizedHealth));
        GUILayout.EndArea();
    }
}
