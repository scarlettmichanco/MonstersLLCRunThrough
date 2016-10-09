using UnityEngine;
using System.Collections;

public class HearingListener : MonoBehaviour
{

  void Start() {
    // code goes here
  }

  void OnCollisionEnter(Collision collision) {
    if (Collision.relativeVelocity.magnitude > 5) {
        // call steathDown method
    }
  }


}
