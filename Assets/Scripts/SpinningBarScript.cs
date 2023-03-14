using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningBarScript : MonoBehaviour
{

    public bool right_rotation;
    private float rotation = 1;

    Rigidbody2D rb;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (right_rotation) { rotation = -1; }
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(10f, 200f);
        rb.rotation += rotation * speed * Time.deltaTime;
    }
}
