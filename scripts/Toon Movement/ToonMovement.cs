using UnityEngine;
using System.Collections;

public class ToonMovement :  MonoBehaviour {

    void Start () {

    }

    //update is called once per frame
    void Update () {

        if(Input.GetKey("w")){
            transform.Translate(Vector3.forward);
            Debug.Log("Pressing W key");
        }
        if(Input.GetKey("s")){
            transform.Translate(Vector3.back);
            Debug.Log("Pressing S key");
        }
        if(Input.GetKey("a")){
            Debug.Log("Pressing A key");
        }

    }

}
