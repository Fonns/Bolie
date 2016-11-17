#pragma strict

function OnCollisionEnter (col : Collision)
    {
        if(col.gameObject.name == "jogador")
        {
            Destroy(col.gameObject);
            Application.LoadLevel("gameover");
        }
    }