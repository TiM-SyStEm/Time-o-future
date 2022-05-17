using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    private bool _isTriger = false;
    private bool _isKey = false;

    [SerializeField] private GameObject keyNone;
    [SerializeField] private GameObject EButton;
    
    [SerializeField] private GameObject door;
    
    [SerializeField] private GameObject key;
    void Start()
    {
        EButton.SetActive(false);
        keyNone.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            EButton.SetActive(false);
            if (_isTriger)
            {
                if (!_isKey)
                {
                    keyNone.SetActive(true);
                }
                else
                {
                    door.SetActive(false);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            EButton.SetActive(true);
            _isTriger = true;
        }

        if (other.CompareTag("Key"))
        {
            key.SetActive(false);
            _isKey = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            EButton.SetActive(false);
            _isTriger = false;
            keyNone.SetActive(false);
        }
    }
}
