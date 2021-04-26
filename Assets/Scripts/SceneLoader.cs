using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    #region Public methods

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Destroy()
    {
        Destroy(GetComponent<DispalyNextQuestion>().gameObject);
    }

    #endregion
}
