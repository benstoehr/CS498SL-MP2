using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour {

    GameObject childCamera;  

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, 0, 0);

        childCamera = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            transform.position = (transform.position - (childCamera.transform.position));
        }


    }
}
