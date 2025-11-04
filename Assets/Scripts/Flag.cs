using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject winUI;
    public AudioClip flagClip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            Player player = collision.gameObject.GetComponent<Player>();
            player.PlaySFX(flagClip);
            winUI.SetActive(true);
        }
    }
}
