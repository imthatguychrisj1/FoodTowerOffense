using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxDetection : MonoBehaviour
{
    public int minDamage = 1;
    public int maxDamage = 5;

    private void OnTriggerEnter(Collider other)
    {
        HealthBars script = other.GetComponent<HealthBars>();

        if (script)
        {
            script.ModifyHitPoints(-Random.Range(minDamage, maxDamage));
            Debug.Log("Hit! Health is now: " + script.HitPoints);
        }
    }
}
