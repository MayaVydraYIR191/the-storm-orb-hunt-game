using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour
{
    private int count;
    public string score;

    public GameObject restart;
    public static bool lose = false;

    void Awake ()
    {
        lose = false;
        count = 0;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            lose = true;
            restart.SetActive(true);
        }
        else if (other.gameObject.tag == "Coin")
        {
            count++;
            Destroy(other.gameObject);
        }
    }
    void Update ()
    {
        if (PlayerPrefs.GetInt("HighScore") < count)
        {
            PlayerPrefs.SetInt("HighScore", count);
        }

        else if(PlayerPrefs.GetInt("HighScore") >= count){
            PlayerPrefs.SetInt("Score", count);
        }
    }


}
