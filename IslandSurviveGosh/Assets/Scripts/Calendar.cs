using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calendar : MonoBehaviour
{
    [SerializeField] GameObject Content;
    [SerializeField] ScrollRect scrollRect;

    void Start()
    {
        UpdateVisuals();
        //InitializeElements();
    }

    public void UpdateVisuals()
    {

        // Iterate over each child of Content
        foreach (Transform child in Content.transform)
        {
            CalendarElement calendarElement = child.GetComponent<CalendarElement>();
            if (calendarElement != null)
            {
                
                calendarElement.InitializeCurrentState();
                calendarElement.UpdateCurrentStateVisuals();
            }  
        }
    }

    void InitializeElements()
    {
        foreach(GameObject C in Content.transform)
        {
            CalendarElement calendarElement = C.GetComponent<CalendarElement>();
            calendarElement.InitializeCurrentState();
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
