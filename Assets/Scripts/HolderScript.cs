using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolderScript : MonoBehaviour
{
    [SerializeField]
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, -10);

    }

    // Update is called once per frame
    void Update()
    {
        if(ball.transform.position.y < 0)
        {
            transform.position = new Vector3(0, ball.transform.position.y, -10);

        }
    }
}
