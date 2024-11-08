using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class comicScript : MonoBehaviour
{
    public Image[] pages; // Imaginile pentru comic
     
    private int i;  
    public Image fundal; // Fundalul pe care se schimbă imaginile
    public int nrnr; // Numarul scenei care trebuie afisata dupa terminarea comicului
    private int lungime; // Lungimea comicului

    void Start()
    {
        i =0 ;// valoarea initiala a lui i in functie de limba aleasa
        lungime = pages.Length ; // sfarsitul comicului in functie de limba aleasa
        ShowPage(i); // Se afiseaza prima imagine
    }

    void Update()
    {
        // Verifică dacă este apăsat tasta Enter (Return)
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            NextPage(); // Mergi la pagina următoare
        }
    }

    private void NextPage()
    {
        i++; 
        if (i < lungime)  
        {
            ShowPage(i); // Afișează imaginea corespunzătoare paginii
        }
        //else  
        //{
         //   SceneManager.LoadScene(nrnr); // Încarcă scena următoare după ce comic-ul s-a terminat
       // }
    }

    private void ShowPage(int j)
    {
        if (j >= 0 && j < pages.Length) // Asigură-te că indexul nu depășește lungimea array-ului
        {
            fundal.sprite = pages[j].sprite; // Schimbă fundalul cu imaginea corespunzătoare
        }
        else
        {
            Debug.LogError("Indexul paginii este invalid.");
        }
    }
}