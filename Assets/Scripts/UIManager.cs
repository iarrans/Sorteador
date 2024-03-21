using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI resulTagText;
    public TextMeshProUGUI resultText;

    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void DisplayResult(string result)
    {
        resulTagText.gameObject.SetActive(true);
        resultText.gameObject.SetActive(true);
        resultText.text = result;
    }

    public void SetRaffleTitle(string title)
    {
        titleText.text = title;
    }

    public void SetRaffleSubTitle(string subtitle)
    {
        resulTagText.text = subtitle;
    }

    public void Close()
    {
        Application.Quit();
    }
}
