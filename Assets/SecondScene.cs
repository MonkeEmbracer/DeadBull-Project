using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SecondScene : MonoBehaviour
{
    public int nrnr;
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.CompareTag("Player"))
        {
             SceneManager.LoadScene(nrnr);
        }
   }
}
