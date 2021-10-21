using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutScene : MonoBehaviour
{
    private void FixedUpdate()
    {
        Vector3 pos = transform.position;
        Vector3 normpos = Camera.main.WorldToViewportPoint(pos);

        if (normpos.x < 0 || normpos.y > 1 || normpos.x > 1 || normpos.y < 0)
            gameObject.SetActive(false);
    }
}
