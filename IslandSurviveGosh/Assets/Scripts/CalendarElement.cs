using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CalendarElement : MonoBehaviour
{

    public enum calendarElementState {currentDay,pastDay,futureDay }
    public calendarElementState currentState;
    [SerializeField] List<GameObject> currentDayVisuals;
    [SerializeField] List<GameObject> pastDayVisuals;
    [SerializeField] List<GameObject> futureDayVisuals;
    public int elementDayNumber;
    [SerializeField] Canvas canvas;
    [SerializeField] TextMeshProUGUI currentDayText;
    [SerializeField] TextMeshProUGUI pastDayText;
    [SerializeField] TextMeshProUGUI futureDayText;

    void Awake()
    {
        //InitializeCurrentState();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        //SetTransformIndex();
    }

    public void InitializeCurrentState()
    {
        elementDayNumber =  transform.GetSiblingIndex()+1;

        if (elementDayNumber == GameManager.Instance.GameDay)
        {
            currentState = calendarElementState.currentDay;
        }
        else if (elementDayNumber > GameManager.Instance.GameDay)
        {
            currentState = calendarElementState.futureDay;
        }
        else if (elementDayNumber < GameManager.Instance.GameDay)
        {
            currentState = calendarElementState.pastDay;
        }

        string dayString = elementDayNumber.ToString();
        currentDayText.text = dayString;
        pastDayText.text = dayString;
        futureDayText.text = dayString;
    }

    public void UpdateCurrentStateVisuals()
    {
        // Set all current day visuals active, others inactive
        if (currentState == calendarElementState.currentDay)
        {
            SetActiveVisuals(currentDayVisuals, true);
            SetActiveVisuals(pastDayVisuals, false);
            SetActiveVisuals(futureDayVisuals, false);
        }
        // Set all past day visuals active, others inactive
        else if (currentState == calendarElementState.pastDay)
        {
            SetActiveVisuals(currentDayVisuals, false);
            SetActiveVisuals(pastDayVisuals, true);
            SetActiveVisuals(futureDayVisuals, false);
        }
        // Set all future day visuals active, others inactive
        else if (currentState == calendarElementState.futureDay)
        {
            SetActiveVisuals(currentDayVisuals, false);
            SetActiveVisuals(pastDayVisuals, false);
            SetActiveVisuals(futureDayVisuals, true);
        }
        SetCanvasSortingOrder();
    }

    void SetCanvasSortingOrder()
    {
                // Set all current day visuals active, others inactive
        if (currentState == calendarElementState.currentDay)
        {
            canvas.sortingOrder = 5;
        }
        else
        {
            canvas.sortingOrder = 1;
        }
    }

    private void SetActiveVisuals(List<GameObject> visuals, bool isActive)
    {
        foreach (GameObject visual in visuals)
        {
            visual.SetActive(isActive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
