using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject : MonoBehaviour
{
    public int sum=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (input.GetMouseButtonDown(0) && gameObject.tag('puzzle')){
        //     sum += gameObject
        // }
        void OnTriggerEnter2D(Collider2D col) {
            if(col.gameObject.tag == "Door") {
                // doorColor = DoorColor.Red;
                onDoor = true;
                var door = col.gameObject;
                var doorNumber = door.GetComponent(doorNumber);
                while(onDoor){
                Debug.Log(string.Format("Door Number {0}", doorNumber.ToString()));
                }
            }
        }
    }
}
