using UnityEngine;
using System.Collections;

public class AddSomeForce : MonoBehaviour {
    private bool done;


    private void Awake() {
        
    }

    private void FixedUpdate() {
        if (done)
            return;
        done = true;
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * 10.0f;

    }


}
