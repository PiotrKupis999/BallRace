using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public GameObject starting_wheel;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public TextMeshProUGUI text;


    private void Awake()
    {
        Instantiate(starting_wheel);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestroyImmediate(starting_wheel,true);
        }
    }

    
}
