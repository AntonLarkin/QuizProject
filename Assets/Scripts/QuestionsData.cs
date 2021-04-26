using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Question", fileName = "Question", order = 51)]

public class QuestionsData : ScriptableObject
{

    #region Variables

    [SerializeField] private string questionText;
    public string QuestionText
    {

        get { return questionText; }
        protected set { }

    }

    [SerializeField] private Image questionBackground;
    public Image QuestionBackground
    {

        get { return questionBackground; }
        protected set { }

    }

    [SerializeField] private string answer1;
    public string Answer1
    {

        get { return answer1; }
        protected set { }

    }

    [SerializeField] private string answer2;
    public string Answer2
    {

        get { return answer2; }
        protected set { }

    }

    [SerializeField] private string answer3;
    public string Answer3
    {

        get { return answer3; }
        protected set { }

    }

    [SerializeField] private string answer4;
    public string Answer4
    {

        get { return answer4; }
        protected set { }

    }

    [SerializeField] private int correctAnswerIndex;
    public int CorrectAnswerIndex
    {

        get { return correctAnswerIndex; }
        protected set { }

    }

    #endregion

}
