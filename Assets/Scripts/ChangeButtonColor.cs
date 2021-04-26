using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor : MonoBehaviour
{

    #region Variables

    private Button button;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    #endregion


    #region Public Methods

    public void ChangeColorToRed(Button button)
    {
        button.image.color = new Color(255, 0, 0);
    }

    public void ChangeColorToGreen(Button button)
    {
        button.image.color = new Color(0, 255, 0);
    }

    public void ChangeColorToNormal(Button button)
    {
        button.image.color = new Color(255, 255, 255);
    }

    public IEnumerator WaitForSeconds(float value)
    {
        yield return new WaitForSeconds(value);
    }

    #endregion

}
