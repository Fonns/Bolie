using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    public Button jogar;
    public Button sair;
    public Button opcoes;

	void Start () {

        jogar = jogar.GetComponent<Button> ();
        sair = sair.GetComponent<Button>();
        opcoes = opcoes.GetComponent<Button>();
    }
	
    public void comecarjogo ()
    {
        SceneManager.LoadScene("main");
    }

    public void sairjogo()
    {
        SceneManager.LoadScene("sairDoJogo");
    }

    public void opcoesjanela() {
        SceneManager.LoadScene("opcoes");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("sairDoJogo");
        }
    }
}