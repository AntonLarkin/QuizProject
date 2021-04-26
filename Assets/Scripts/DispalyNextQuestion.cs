using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispalyNextQuestion : MonoBehaviour
{

    #region Variables

    public DisplayQuestions displayQuestions;
    public ButtonKeeper buttonKeeper;
    public SceneLoader loader;
    public LivesUpdate livesUpdate;
    public ChangeButtonColor buttonColor;
    public HideWrongAnswers hideWrongAnswers;

    public delegate void ShowQuestion();
    public event ShowQuestion OnClickChangeQuestion;

    public int correctAnswers;
    public int wrongAnswers;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        loader = FindObjectOfType<SceneLoader>();
    }

    private void Start()
    {
        OnClickChangeQuestion += displayQuestions.UpdateCurrentQuestion;
        OnClickChangeQuestion += hideWrongAnswers.ShowAllButtons;
    }

    #endregion


    #region Public methods

    public void ChangeQuestion()
    {

        if (displayQuestions.count < displayQuestions.questions.Length)
        {
            OnClickChangeQuestion?.Invoke();
            print($"right:{correctAnswers}, wrong:{wrongAnswers}");
        }
        else
        {
            loader.LoadEndScene();
        }

    }

    public void ChangeQuestionFirstButton()
    {

        if (buttonKeeper.answers[displayQuestions.correctAnswerIndex - 1] == buttonKeeper.answers[0])
        {
            correctAnswers++;
            ChangeQuestion();
        }
        else
        {
            wrongAnswers++;
            livesUpdate.LivesUpdater();
            ChangeQuestion();
        }

    }

    public void ChangeQuestionSecondButton()
    {

        if (buttonKeeper.answers[displayQuestions.correctAnswerIndex - 1] == buttonKeeper.answers[1])
        {
            correctAnswers++;
            ChangeQuestion();
        }
        else
        {
            wrongAnswers++;
            livesUpdate.LivesUpdater();
            ChangeQuestion();
        }

    }

    public void ChangeQuestionThirdButton()
    {

        if (buttonKeeper.answers[displayQuestions.correctAnswerIndex - 1] == buttonKeeper.answers[2])
        {
            correctAnswers++;
            ChangeQuestion();
        }
        else
        {
            wrongAnswers++;
            livesUpdate.LivesUpdater();
            ChangeQuestion();
        }

    }

    public void ChangeQuestionFourthButton()
    {

        if (buttonKeeper.answers[displayQuestions.correctAnswerIndex - 1] == buttonKeeper.answers[3])
        {
            correctAnswers++;
            ChangeQuestion();
        }
        else
        {
            wrongAnswers++;
            livesUpdate.LivesUpdater();
            ChangeQuestion();
        }
    }

    #endregion
}
