using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;

    void Update()
    {
        if(transform.position.x < -9f)//узнать программно 
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(fallSpeed * Time.deltaTime, 0, 0);
    }
}
