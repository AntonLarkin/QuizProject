using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayQuestions : MonoBehaviour
{

    #region Variables

    public QuestionsData[] questions;
    public ButtonKeeper buttonKeeper;
    public Text questionText;
    public Image questionBG;
    public Text answer1;
    public Text answer2;
    public Text answer3;
    public Text answer4;
    public int count;
    public int correctAnswerIndex;

    #endregion

    
    #region Unity lifecycle

    void Start()
    {
        MixQuestions();
        UpdateCurrentQuestion();
    }

    #endregion


    #region Public methods

    public void UpdateCurrentQuestion()
    {
        questionText.text = questions[count].QuestionText;
        questionBG = questions[count].QuestionBackground;
        answer1.text = questions[count].Answer1;
        answer2.text = questions[count].Answer2;
        answer3.text = questions[count].Answer3;
        answer4.text = questions[count].Answer4;

        for (int i = 1; i <= 4; i++)
        {

            if (i == questions[count].CorrectAnswerIndex)
            {
                correctAnswerIndex = i;
            }

        }

        count++;
    }

    private void MixQuestions()
    {

        for (int i = questions.Length - 1; i >= 0; i--)
        {
            int j = Random.Range(0, questions.Length);
            QuestionsData temp = questions[j];
            questions[j] = questions[i];
            questions[i] = temp;
        }

    }

    #endregion

}
