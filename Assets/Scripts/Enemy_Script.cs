using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(Random.Range(-12.0f, 12.0f), Random.Range(6.0f, -4.0f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Vector3.left * 0.1f);
        
        if(this.gameObject.transform.position.x < -15.0f) {
            this.gameObject.transform.Translate(Vector3.right * 30.0f);
        }
    }
}
