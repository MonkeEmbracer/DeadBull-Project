using UnityEngine;
using UnityEngine.SceneManagement;
public class next_scene : MonoBehaviour
{
    public int nrnr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void ceva()
    {
        SceneManager.LoadScene(4);
    }
}
