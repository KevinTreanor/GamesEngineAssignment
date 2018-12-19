using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Adapted from class code to work with prefabs instead of generated Game Objects
public class TreeAudioViz : MonoBehaviour {

    public float scale = 2;
    
    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //Causes prefabs to move with the bands from audio input
        for (int i = 0; i < 5; i++)
        {
            Vector3 ls = gameObject.transform.localScale;
            ls.y = Mathf.Lerp(ls.y, 1+ (AudioViz.bands[i] * scale), Time.deltaTime * 3.0f);
            ls.x = Mathf.Lerp(ls.y, 1 + (AudioViz.bands[i] * scale), Time.deltaTime * 3.0f);
            ls.z = Mathf.Lerp(ls.y, 1+  (AudioViz.bands[i] * scale), Time.deltaTime * 3.0f);
            gameObject.transform.localScale = ls;
        }
    }


}

