using UnityEngine;

public class movimentacao : MonoBehaviour
{
     public float velocidade = 5f;
    public float forcaPulo = 10f;

    private Rigidbody2D rb;
    private bool estaNoChao;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimento horizontal
        float movimento = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(movimento * velocidade, rb.linearVelocity.y);

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            estaNoChao = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            estaNoChao = false;
        }
    }
}
