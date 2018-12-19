using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeViz : MonoBehaviour {

    public Color newColor;


    public float targetTime = 5.0f;



    // Use this for initialization
    void Start () {

     
    }

  

    // Update is called once per frame
    void Update () {


        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

      
    }

    void timerEnded()
    {

        newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        gameObject.GetComponent<Renderer>().materials[0].color = newColor;
        targetTime = 10;
    }

}
