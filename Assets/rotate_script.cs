using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_script : MonoBehaviour {
    private bool rotate_BOOL;
	// Use this for initialization
	void Start () {
        rotate_BOOL = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (rotate_BOOL)
        {
            transform.Rotate(0f, 0f, 2.5f);
        }
	}

    public void set_rotate_bool(bool rotate_bool) //true rotate false stop
    {
        rotate_BOOL = rotate_bool;
    }
}
