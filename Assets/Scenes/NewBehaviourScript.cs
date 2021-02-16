using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// test
public class NewBehaviourScript : MonoBehaviour
{
  
    private void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            GetComponent<Renderer>().material.color = GetRandomColor();

        }
    }
    private Color GetRandomColor()
    {
        return new Color(UnityEngine.Random.Range(0,1f),
        UnityEngine.Random.Range(0,1f),
         UnityEngine.Random.Range(0,1f));
    }

}
