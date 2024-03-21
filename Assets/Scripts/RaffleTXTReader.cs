using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RaffleTXTReader: MonoBehaviour
{
    public string filePath;
    public List<string> options;
    public string raffleTitle;

    public TMP_InputField inputPath;

    private void Start()
    {
        LoadRaffleFile();
    }
    public void LoadRaffleFile()
    {
        options.Clear();
        StreamReader reader = new StreamReader(filePath);
        string[] fileLines = reader.ReadToEnd().Split('\n');
        reader.Close();

        raffleTitle = fileLines[0];

        for (int i =1;i< fileLines.Length -1;i++)
        {
            options.Add(fileLines[i]);
        }

        UIManager.instance.titleText.text = raffleTitle;
        RaffleManager.instance.availableOptions = options;

    }

    public void LoadNewPath()
    {
        if(inputPath.text != string.Empty)
        {
            filePath = inputPath.text;
            LoadRaffleFile();
        }      
    }
}
