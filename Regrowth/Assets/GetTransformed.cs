using UnityEngine;

public class GetTransformed : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D collision)
  {
      if(collision.transform.CompareTag("Player"))
      {
          
      }
  }
}
