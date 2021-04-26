using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideWrongAnswers : MonoBehaviour
{

    #region Variables

    public ButtonKeeper buttonKeeper;
    public DisplayQuestions displayQuestions;
    public Button button;
    public int countButtons;

    #endregion


    #region Public methods

    public void HideWrongButtons()
    {

        for (int i = 0; i < buttonKeeper.answers.Count; i++)
        {

            if (countButtons < 2)
            {

                if (buttonKeeper.answers[i] == buttonKeeper.answers[displayQuestions.correctAnswerIndex - 1])
                {
                    continue;
                }
                buttonKeeper.answers[i].gameObject.SetActive(false);
                countButtons++;

            }

        }

    }

    public void ShowAllButtons()
    {

        for (int i = 0; i < buttonKeeper.answers.Count; i++)
        {
            buttonKeeper.answers[i].gameObject.SetActive(true);
            countButtons = 0;
        }

    }

    #endregion
}
