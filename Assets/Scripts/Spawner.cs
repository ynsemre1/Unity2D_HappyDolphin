using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Dolphin Dolph;
    public GameObject Borular;
    public float height;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    void Update()
    {
        
    }

    public IEnumerator SpawnObject()
    {
        while (!Dolph.isDead)
        {
            Instantiate(Borular, new Vector3(15, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
        }
    }
}
