using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ads : MonoBehaviour 
{
    public Button Switch;
    public Button mainMenu;
    void Start () 
    {
        
        Advertisement.Initialize ("1598108", true);
        Switch.onClick.AddListener(Do);
        mainMenu.onClick.AddListener(do2);
       
    }

    void Do()
    {
        StartCoroutine (ShowAdWhenReady());
        SceneManager.LoadScene(2);
    }

    void do2()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator ShowAdWhenReady()
    {
        while (!Advertisement.IsReady())
            yield return null;

        Advertisement.Show ();
    }
}