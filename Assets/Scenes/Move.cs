using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float height = 100;
    public float speed = 8;
    private float x;
    private float y;
    private Vector3 rotateValue;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit raycastHit;
        Vector3 Pos = transform.position;
        Pos += (Vector3.forward * speed * Time.deltaTime);

        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");
        Debug.Log(x + ":" + y);
        rotateValue = new Vector3(x, y * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;


    }
}
