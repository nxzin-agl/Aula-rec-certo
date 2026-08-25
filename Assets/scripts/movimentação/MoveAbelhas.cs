using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveAbelhas : MonoBehaviour
{
    public float velocidade = 3f;
    public GameObject Teladerrota;

    void Update()
    {
        // Faz a parede andar para a direita
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            
            Teladerrota.SetActive(true);

            velocidade = 0;
        }
    }
}
