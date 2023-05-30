using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();


    }

    void Update()
    {
        float randomNumber = Random.value;

        if (Random.value < 0.3f)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {


                _renderer.material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            }
        }




    }
}
