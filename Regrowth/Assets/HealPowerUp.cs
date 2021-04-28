using UnityEngine;

public class HealPowerUp : MonoBehaviour
{
  public int healthPoints ;
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if(collision.CompareTag("Player")){
      if(PlayerHealth.instance.currentHealth != PlayerHealth.instance.maxHealth){ // a supp si on veut que les coeurs disparaissent à chaque fois
        PlayerHealth.instance.HealPlayer(healthPoints);
        Destroy(gameObject);
      }
    }
  }
}
