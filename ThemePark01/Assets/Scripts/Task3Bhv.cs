using UnityEngine;
using UnityEngine.UI;


public class Task3Bhv : MonoBehaviour
{

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;


    int count1 = 0;
    int count2 = 0;
    int count3 = 0;
    int count4 = 0;
    int count5 = 0;
    int count6 = 0;

    public GameObject finishButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        btn1.onClick.AddListener(() => btn1Pressed());
        btn2.onClick.AddListener(() => btn2Pressed());
        btn3.onClick.AddListener(() => btn3Pressed());
        btn4.onClick.AddListener(() => btn4Pressed());
        btn5.onClick.AddListener(() => btn5Pressed());
        btn6.onClick.AddListener(() => btn6Pressed());

    }

    // Update is called once per frame
    void Update()
    {

        if (count1 == 2
            && count2 == 0
            && (count3 == 1 || count3 == 3)
            && count4 == 2
            && count5 == 2)
        {
            finishButton.SetActive(true);
        }

    }

    void btn1Pressed()
    {
        count1++;
        count1 = count1 % 4;

    }
    void btn2Pressed()
    {
        count2++;
        count2 = count2 % 4;

    }
    void btn3Pressed()
    {
        count3++;
        count3 = count3 % 4;

    }
    void btn4Pressed()
    {
        count4++;
        count4 = count4 % 4;

    }    
    void btn5Pressed()
    {
        count5++;
        count5 = count5 % 4;

    }
    void btn6Pressed()
    {
        count6++;
        count6 = count6 % 4;

    }


}
