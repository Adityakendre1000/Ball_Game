using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{

    bool gameHasEnded = false;
    public void GameOver(){

        int restartTime = 2;

        if (gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game over nigga!!");

            //restart game
            Invoke("restart",restartTime);
        }
        
    }

    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
