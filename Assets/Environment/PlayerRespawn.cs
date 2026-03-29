using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 startPosition;
    private Animator animator;
    private Rigidbody2D rb;

    public GameObject deathText;

    void Start()
    {
        startPosition = transform.position;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        if (deathText != null)
            deathText.SetActive(false);
    }

    public void Respawn()
    {
        StartCoroutine(RespawnCoroutine());
    }

    IEnumerator RespawnCoroutine()
    {
        // Animación de muerte
        animator.SetBool("noBlood", false);
        animator.SetTrigger("Death");

        // Mostrar texto
        if (deathText != null)
            deathText.SetActive(true);

        yield return new WaitForSeconds(1.5f);

        
        rb.linearVelocity = Vector2.zero;

        
        animator.Rebind();
        animator.Update(0f);

        // Volver al inicio
        transform.position = startPosition;

        // Ocultar texto
        if (deathText != null)
            deathText.SetActive(false);
    }
}