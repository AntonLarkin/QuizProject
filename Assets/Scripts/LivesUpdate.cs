using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesUpdate : MonoBehaviour
{

    #region Variables

    public Text livesLabel;
    public int livesTotal = 3;
    public int livesLeft;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        livesLeft = livesTotal;
    }

    private void Update()
    {
        livesLabel.text = livesLeft.ToString();
    }

    #endregion


    #region Public methods

    public void LivesUpdater()
    {

        if (livesLeft == 1)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            livesLeft--;
        }

    }

    #endregion
}
