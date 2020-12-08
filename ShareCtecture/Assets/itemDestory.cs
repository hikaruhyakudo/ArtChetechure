using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDestory : MonoBehaviour {
    void Update() {
        if (transform.position.y < -9f) {
            Destroy(gameObject);
            }
        }
    }
