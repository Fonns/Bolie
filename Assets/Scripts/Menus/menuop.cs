using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuop : MonoBehaviour
{

    public Button reseths;
    public Button creditos;
    public Button voltar;

    void Start()
    {

        reseths = reseths.GetComponent<Button>();
        creditos = creditos.GetComponent<Button>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }

    public void resethighscore()
    {
        PlayerPrefs.DeleteKey("highscore");
    }

    public void abrircreditos()
    {
        SceneManager.LoadScene("creditos");
    }

    public void voltaratras()
    {
        SceneManager.LoadScene("menu");
    }
}