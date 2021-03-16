using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject p1Win;
    public GameObject p2Win;
    public bool GameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        p1Win.SetActive(false);
        p2Win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Map");
        }
        if (player1 == null && GameOver == false)
        {
            p2Win.SetActive(true);

            GameOver = true;
        }
        if (player2 == null && GameOver == false)
        {
            p1Win.SetActive(true);
            GameOver = true;
        }
    }
}
