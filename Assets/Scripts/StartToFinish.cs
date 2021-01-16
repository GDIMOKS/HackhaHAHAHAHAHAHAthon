﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartToFinish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("Start").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Finish").GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
