using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<HealthSystem>().health -= GetComponent<HealthSystem>().health;
        GetComponent<HealthSystem>().health = 0;
    }
}