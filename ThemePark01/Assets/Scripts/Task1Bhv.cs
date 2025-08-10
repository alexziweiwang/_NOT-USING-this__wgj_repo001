using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Task1Bhv : MonoBehaviour
{

    string[] arr = { "A", "B", "C" };
    int index1 = 0;
    int index2 = 0;
    int index3 = 0;

    public Button op1;
    public Button op2;
    public Button op3;
    public TMP_Text opLabel1;
    public TMP_Text opLabel2;
    public TMP_Text opLabel3;

    public GameObject finishButton;

    bool taskFinishedOnce = false;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        finishButton.SetActive(false);
        op1.onClick.AddListener(() => opt1Pressed());
        op2.onClick.AddListener(() => opt2Pressed());
        op3.onClick.AddListener(() => opt3Pressed());
    }

    // Update is called once per frame
    void Update()
    {
        if (opLabel1.text == "C"
        && opLabel2.text == "A"
        && opLabel3.text == "B")
        {
            finishButton.SetActive(true);
            taskFinishedOnce = true;

        }
    }

    void opt1Pressed()
    {
        if (taskFinishedOnce == true)
        {
            return;
        }

        index1 = index1 + 1;
        index1 = index1 % 3;
        opLabel1.text = arr[index1];
    }
    void opt2Pressed()
    {
        if (taskFinishedOnce == true)
        {
            return;
        }

        index2 = index2 + 1;
        index2 = index2 % 3;
        opLabel2.text = arr[index2];
    }
    
    void opt3Pressed()
    {
        if (taskFinishedOnce == true)
        {
            return;
        }

        index3 = index3 + 1;
        index3 = index3 % 3;
        opLabel3.text = arr[index3];
    }
}
