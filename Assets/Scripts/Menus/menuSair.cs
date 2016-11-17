using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuSair : MonoBehaviour {

    public Button sairSim;
    public Button sairNao;

    void Start()
    {

        sairSim = sairSim.GetComponent<Button>();
        sairNao = sairNao.GetComponent<Button>();
    }

    public void ficarNoJogo()
    {
        SceneManager.LoadScene("menu");
    }

    public void sairDoJogo()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
