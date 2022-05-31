using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed = 10f;

    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float minY = -3.4f;
            float maxY = 4.6f;

            mousePos.y = mousePos.y < minY ? minY : mousePos.y;
            mousePos.y = mousePos.y > maxY ? maxY : mousePos.y;

            player.position = Vector2.MoveTowards(player.position, new Vector2(player.position.x, mousePos.y), speed * Time.deltaTime);
        }

    }
}
