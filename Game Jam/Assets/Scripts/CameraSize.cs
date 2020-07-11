using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    public float offsetAdd;
    public float offsetMultiply;
    public Camera m_OrthographicCamera;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        m_OrthographicCamera.orthographicSize = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        m_OrthographicCamera.orthographicSize = rb.velocity.x + 5f;
    }
}
