using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;
    public GameObject coin;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn ()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(10.5f, Random.Range(4.3f, -3.1f)), Quaternion.identity);
            Instantiate(coin, new Vector2(10.5f, Random.Range(4.3f, -3.1f)), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
}
