using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveAbelhas : MonoBehaviour
{
    public float velocidade = 3f;
    public GameObject Teladerrota;
    public float aumentoVelocidade = 0.4f;
    public float tempoParaAumentar = 20f;

    private float tempoAtual = 0f;

    void Update()
    {
        // Faz a parede andar para a direita
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);

         
        tempoAtual += Time.deltaTime;

        if (tempoAtual >= tempoParaAumentar)
        {
            velocidade += aumentoVelocidade;
            tempoAtual = 0f;
        }
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
