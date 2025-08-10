using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Task2Bhv : MonoBehaviour
{

    int sum = 0;

    public Button btn40;
    public Button btn20;
    public Button btn50;
    public Button btn10;
    public Button btn30;

    int count40 = 0;
    int count20 = 0;
    int count50 = 0;
    int count10 = 0;
    int count30 = 0;

    public GameObject finishBtn;

    public TMP_Text label1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        btn40.onClick.AddListener(() => press40());
        btn20.onClick.AddListener(() => press20());
        btn50.onClick.AddListener(() => press50());
        btn10.onClick.AddListener(() => press10());
        btn30.onClick.AddListener(() => press30());

    }

    // Update is called once per frame
    void Update()
    {
        if (sum == 120)
        {
            finishBtn.SetActive(true);
            sum = 0;
        }

        label1.text = sum + "";

    }

    public void press40()
    {
        count40++;
        if (count40 % 2 == 1)
        {
            sum += 40;
            //TODO change look?
        }
        else
        {
            sum -= 40;
        }


    }

    public void press20()
    {
        count20++;
        if (count20 % 2 == 1)
        {
            sum += 20;
                        //TODO change look?

        }
        else
        {
            sum -= 20;
        }
    }
    public void press50()
    {
        count50++;
        if (count50 % 2 == 1)
        {
            sum += 50;
                        //TODO change look?

        }
        else
        {
            sum -= 50;
        }
    }

    public void press10()
    {
        count10++;
        if (count10 % 2 == 1)
        {
            sum += 10;
                        //TODO change look?

        }
        else
        {
            sum -= 10;
        }
    }

    public void press30()
    {
        count30++;
        if (count30 % 2 == 1)
        {
            sum += 30;
                        //TODO change look?

        }
        else
        {
            sum -= 30;
        }
    }

}
