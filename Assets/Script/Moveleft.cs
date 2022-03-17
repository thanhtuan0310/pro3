using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveleft : MonoBehaviour
{
    public float speed = 20;
    private PlayerController PlayerScript;
    private float bound = -10;
    // Start is called before the first frame update
    void Start()
    {
        PlayerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScript.GameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < bound && gameObject.CompareTag("CNV"))
        {
            Destroy(this.gameObject);
        }
    }
}
