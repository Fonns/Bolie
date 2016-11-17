using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{

    public Button tdn;
    public Button vam;

    // Use this for initialization
    void Start()
    {

        tdn = tdn.GetComponent<Button>();
        vam = vam.GetComponent<Button>();
    }

    public void recomecar()
    {
        SceneManager.LoadScene("main");
    }

    public void iraomenu()
    {
        SceneManager.LoadScene("menu");
    }
}