using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverView : MonoBehaviour
{

    #region Variables

    public Text correctAnswersLabel;
    public Text wrongAnswersLabel;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        DispalyNextQuestion dispalyNextQuestion = FindObjectOfType<DispalyNextQuestion>();
        correctAnswersLabel.text = dispalyNextQuestion.correctAnswers.ToString();
        wrongAnswersLabel.text = dispalyNextQuestion.wrongAnswers.ToString();
    }

    #endregion

}
