using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public GameObject starting_wheel;

    [Header("Leaderboard")]
    public GameObject leaderboard;
    /*
    public TextMeshProUGUI player1_position;
    public TextMeshProUGUI player2_position;
    public TextMeshProUGUI player3_position;
    public TextMeshProUGUI player4_position;

    [Header("Players")]
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    */
    public int max;
    private bool is_playing = false;



    public TextMeshProUGUI text;


    private void Awake()
    {
        //Instantiate(starting_wheel);
        /*
        Instantiate(player1);
        Instantiate(player2);
        Instantiate(player3);
        Instantiate(player4);
        */
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
            is_playing = true;
        }

        if(is_playing) { Leaderboard(2); }
        Debug.Log("VHUJ"); 
    }

    private void Leaderboard(int num_of_players)
    {

        leaderboard.transform.position = Vector3.MoveTowards(leaderboard.transform.position, new Vector3(-600f, 0f, 0f), 200 * Time.deltaTime);

        /*
        Instantiate(leaderboard);


        Instantiate(player1_position);
        */

    }

    
}
