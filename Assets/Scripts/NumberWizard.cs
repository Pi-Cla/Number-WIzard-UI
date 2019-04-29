using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NumberWizard : MonoBehaviour
{
    //Variables set here so it can be more accessible
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI geussText;
    int computerGeuss;

    // Start is called before the first frame update
    void Start()
    {
        //This is the equation to determine the computer's next geuss
        //The do while loop ensures if the geuss is higher then max or lower then min it will redo
        do {
            computerGeuss = Random.Range(min, max - 1);
        } while (computerGeuss > max | computerGeuss < min);
        
        //Display the geuss onto the screen
        geussText.text = computerGeuss.ToString();
    }

    public void OnPressHigher() {
        //Minimum number is the previous geuss
            min = computerGeuss + 1;
            Start();
    }

    public void OnPressLower() {
        //Maximum number is the previous geuss
            max = computerGeuss - 1;
            Start();
    }
}
