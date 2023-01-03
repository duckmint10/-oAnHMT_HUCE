using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quayquay : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 point = new Vector3(-39,21,28);
    public float speed = 100.0f;
    private Vector3 v;

    void Start()
    {
         v = transform.position - point;
    }

    // Update is called once per frame
    void Update()
    {
        v = Quaternion.AngleAxis(Time.deltaTime * speed, Vector3.left) * v;
        transform.position = point + v;
    }
}
