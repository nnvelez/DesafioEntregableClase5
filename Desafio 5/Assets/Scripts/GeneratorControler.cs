using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorControler : MonoBehaviour
{
    public GameObject bulletPreab;
    public float delaySpawn = 2f;
    public float intervalSpawn = 1f;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("BulletSpawn", delaySpawn, intervalSpawn);
    }

    private void BulletSpawn()
    {
        Instantiate(bulletPreab, transform);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
