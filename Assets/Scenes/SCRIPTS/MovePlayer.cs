using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.position += (new Vector3(-1, 0, 0) * speed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.position += (new Vector3(1, 0, 0) * speed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position += (new Vector3(0, 0, -1) * speed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += (new Vector3(0, 0, 1) * speed) * Time.deltaTime;
        }
    }
}
