using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Task : MonoBehaviour
{

    int task1_count = 0;
    int task2_count = 0;
    int task3_count = 0;

    public TMP_Text label1;
    public TMP_Text label2;

    public Button Task1FinishOnce;
    public Button Task2FinishOnce;
    public Button Task3FinishOnce;

    public Button Task1Entry;
    public Button Task2Entry;
    public Button Task3Entry;


    bool remindNeeded = false;

    string prevTask = "task3";

    public GameObject scaryBgPic;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Task1FinishOnce.onClick.AddListener(() => task1Once());
        Task2FinishOnce.onClick.AddListener(() => task2Once());
        Task3FinishOnce.onClick.AddListener(() => task3Once());

        Task1Entry.onClick.AddListener(() => CheckFinisheInSequence(label1.text, "task1"));
        Task2Entry.onClick.AddListener(() => CheckFinisheInSequence(label1.text, "task2"));
        Task3Entry.onClick.AddListener(() => CheckFinisheInSequence(label1.text, "task3"));

    }

    // Update is called once per frame
    void Update()
    {
        if (remindNeeded == false)
        {
            HandleTaskList(task1_count, task2_count, task3_count);
            label2.text = "";

        }

    }

    void CheckFinisheInSequence(string pendingTask, string actualAction)
    {

                                        Debug.Log("pending task = [" + pendingTask + "], " + actualAction);
        if (
            (pendingTask == "Do task1!" && (actualAction == "task2" || actualAction == "task3"))
        || (pendingTask == "Do task2!" && (actualAction == "task1" || actualAction == "task3"))
        || (pendingTask == "Do task3!" && (actualAction == "task1" || actualAction == "task2"))

        )
        {
            Debug.Log("!!!");

            label1.text = pendingTask;
            label2.text = "Why don't you finish tasks in order?";
            scaryBgPic.SetActive(true);

            remindNeeded = true;

        }
        else
        {
            remindNeeded = false;


        }

    }

    void HandleTaskList(int count1, int count2, int count3) //important for task-list!
    {

        if (prevTask == "task1")
        {
            label1.text = "Do task2!";
        }
        else if (prevTask == "task2")
        {
            label1.text = "Do task3!";
        }
        else if (prevTask == "task3")
        {
            label1.text = "Do task1!";
        }

        label2.text = "";
        scaryBgPic.SetActive(false);

    }





    void task1Once()
    {
        prevTask = "task1";      
    }

    void task2Once()
    {
        prevTask = "task2";      

    }

    void task3Once()
    {
        prevTask = "task3";      
    }        
}
