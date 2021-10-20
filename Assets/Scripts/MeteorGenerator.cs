using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    public GameObject[] meteors = new GameObject[2];
    public Transform[] positions;
    void Start()
    {
        StartCoroutine(GenerateMeteor());
    }

    IEnumerator GenerateMeteor()
    {
        int r = Random.Range(0, 4);
        int rM = Random.Range(0, 2);
        Instantiate(meteors[rM], positions[r].position, Quaternion.identity);
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(GenerateMeteor());
    }
}