using UnityEngine;

public class GroundLoop : MonoBehaviour
{
   public Transform player;
    public float groundWidth = 20f;

    void Update()
    {
        if (transform.position.x < player.position.x - groundWidth)
        {
            transform.position += Vector3.right * groundWidth * 3f;
        }
    }
}
