using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour {

    GameObject mc;
    int mir = 0;
    Vector3 headStart;

    // Use this for initialization
    void Start () {
        mc = GameObject.Find("Main Camera");
        headStart = transform.position;
	}
	

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.M))
        {
            if(mir == 1){  mir = 2; }
            else if (mir == 2) { mir = 1; }
            else { mir = 1; }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }

        if (mir == 1)
        {
            transform.rotation = mc.transform.rotation;
            transform.Rotate(Vector3.up, (float)270);

            transform.position = (mc.transform.position + headStart);
        }

        if(mir == 2)
        {
            Quaternion mir = mc.transform.rotation;

            float w = mir.w;
            float x = mir.x;
            float y = mir.y;
            float z = mir.z;

            transform.rotation = new Quaternion(-x, -y, z, w);
            
            transform.Rotate(Vector3.up, (float)90);

            transform.position = new Vector3(
                mc.transform.position.x + headStart.x,
                mc.transform.position.y + headStart.y,
                headStart.z - mc.transform.position.z);

        }
        
        
        Debug.Log("mir = " + mir);
    }
}
