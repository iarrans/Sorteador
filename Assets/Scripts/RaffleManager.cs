using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaffleManager : MonoBehaviour
{
    public static RaffleManager instance;

    public List<string> availableOptions;
    public string winnerOption;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    public void Raffle()
    {
        int numOfOptions = availableOptions.Count;
        int chosenOption = Random.Range(0, numOfOptions);
        winnerOption = availableOptions[chosenOption];
        UIManager.instance.DisplayResult(winnerOption);
    }

}
