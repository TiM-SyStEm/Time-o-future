using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    [SerializeField] private float jump = 5;
    [SerializeField] private Rigidbody rb;

    private bool _isGraund = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isGraund)
            {
                rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Graund"))
        {
            _isGraund = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Graund"))
        {
            _isGraund = false;
        }
    }
}
