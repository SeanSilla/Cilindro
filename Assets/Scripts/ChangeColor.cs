using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer _renderer;
    
     public float timer = 0.0f;

 
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.0f)//change the float value here to change how long it takes to switch.
        {
            // pick a random color
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            // apply it on current object's material
            _renderer.material.color = newColor;
            timer = 0;
        }


    }

    //TEST

    // Test 2
}

 

