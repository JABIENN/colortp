using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clones : MonoBehaviour
{
    public GameObject spherePrefab;
    public Transform barrelEnd;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Rigidbody sphereInstance;
            sphereInstance = Instantiate(spherePrefab, barrelEnd.position, barrelEnd.rotation).GetComponent<Rigidbody>();
            sphereInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
}
