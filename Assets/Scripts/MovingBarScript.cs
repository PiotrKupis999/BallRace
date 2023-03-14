using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBarScript : MonoBehaviour
{
    private float turn = 1;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position += new Vector3(turn * Time.deltaTime, 0, 0);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        turn *= -1;
        Debug.Log("E");
    }


}
