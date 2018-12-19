using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAudioViz : MonoBehaviour {

    public float scale = 2;
    List<GameObject> elements = new List<GameObject>();
    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
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

