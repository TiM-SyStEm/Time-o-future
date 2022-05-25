using UnityEngine;

public class HoveringBox : MonoBehaviour
{
    [SerializeField]
    public float t;
    [SerializeField]
    public float Amp;
    [SerializeField]
    public float Freq;
    [SerializeField]
    public float Offset;
    public Vector3 StartPos;
    void Start()
    {
        StartPos = transform.position;
    }

    void Update()
    {
        t += Time.deltaTime;
        Offset = Amp * Mathf.Sin(t * Freq);
        transform.position = StartPos + new Vector3(0, Offset, 0);
    }
}
