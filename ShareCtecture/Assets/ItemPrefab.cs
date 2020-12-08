using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPrefab : MonoBehaviour {
    //    public float dropspd = -.5f;

    public GameObject Item1Prefab;
    float span = 1f;
    float delta = 0;

    void Update() {
        //      transform.Translate(0, this.dropspd, 0);

        this.delta += Time.deltaTime;
        if (this.delta > this.span) {
            this.delta = 0;
            GameObject item = Instantiate(Item1Prefab) as GameObject;
            item.transform.position = new Vector3(10, 15, -7);
            //item .GetComponent<ItemPrefab>().
            }

        

        }
    }
