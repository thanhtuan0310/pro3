using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] spawnmono;
    private Vector3 positionspawn = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeat = 2;
    private PlayerController PlayerScript;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", startDelay, repeat);
        PlayerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
    if (PlayerScript.GameOver == false)
    {
            index = Random.Range(0, 5);
        Instantiate(spawnmono[index], positionspawn, spawnmono[index].transform.rotation);
    }
    }
}

