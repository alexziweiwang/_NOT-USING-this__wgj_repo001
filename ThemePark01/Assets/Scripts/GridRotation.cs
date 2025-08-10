using UnityEngine;
using UnityEngine.UI;

public class GridRotation : MonoBehaviour
{

    public Button btn;

    public GameObject item;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        btn.onClick.AddListener(() => RotateOnce());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RotateOnce()
    {
        item.transform.Rotate(new Vector3(0, 0, 90));

    }
    

}
