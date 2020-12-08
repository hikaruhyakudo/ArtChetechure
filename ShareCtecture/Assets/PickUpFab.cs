using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFab : MonoBehaviour {
    public Transform theDest = GameObject.Find("PickUpItem").transform;

    private void Start() {
        theDest = GameObject.Find("PickUpItem").transform;
        }

    void OnMouseDown() {
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("PickUpItem").transform;

        }

    void OnMouseUp() {
        GetComponent<CapsuleCollider>().enabled = true;
        GetComponent<Rigidbody>().useGravity = true;
        this.transform.parent = null;
        }
    }
