using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportPlayer : MonoBehaviour
{
    [SerializeField] private string tag;
    [SerializeField] private int scene;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tag))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
