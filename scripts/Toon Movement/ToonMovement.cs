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
		if(Input.GetKeyDown("1")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("2")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("3")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("4")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("5")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("6")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("7")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("8")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("9")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("0")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("-")){
            Debug.Log("Pressing A key");
        }
		if(Input.GetKeyDown("=")){
            Debug.Log("Pressing A key");
        }

    }

}
