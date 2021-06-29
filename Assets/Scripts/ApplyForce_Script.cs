using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce_Script : MonoBehaviour {

    Rigidbody rigidbody;
    float force = 70f;
    
    // Start is called before the first frame update
    void Start() {
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            rigidbody.AddForce(Vector3.up*force);
        }
    }

    public void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag.Equals("Limit")) {
            Debug.Log("Perdeu!!!");
        }
        if (other.gameObject.tag.Equals("Enemy")) {
            Debug.Log("Morreu!!!");
        }
    }
}
