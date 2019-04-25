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
        computerGeuss = (max + min) / 2;
        //Display the geuss onto the screen
        geussText.text = computerGeuss.ToString();
        //Add 1 to max so computer can geuss the max number
        max++;

        
    }

    public void OnPressHigher() {
        //Minimum number is the previous geuss
            min = computerGeuss;
            computerGeuss = (max + min) / 2;
            geussText.text = computerGeuss.ToString();
    }

    public void OnPressLower() {
        //Maximum number is the previous geuss
            max = computerGeuss;
            computerGeuss = (max + min) / 2;
            geussText.text = computerGeuss.ToString();
    }
}
