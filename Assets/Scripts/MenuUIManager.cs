using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    // THIS IS MY PROJECT NOT THE EXAMPLE ONE
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void StartClicked()
{
    MainManager.Instance.SavePlayerName();
}

   
}
