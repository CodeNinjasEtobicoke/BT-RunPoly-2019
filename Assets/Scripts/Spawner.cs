using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("COGO")]
    public GameObject challengeObject;
    [Header("COGO2")]
    public GameObject challengeObject2;
    [Header("Dsdt")]
    public float spawnDelay = 1f;
    [Header("Dst")]
    public float spawnTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(15, 0.2f, 0);
    }
    void InstantiateObjects()
    {
        int dice = Random.Range(1, 100);
        if (dice > 50)
        {
            Instantiate(challengeObject, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(challengeObject2, transform.position, transform.rotation);
        }
    }
}
