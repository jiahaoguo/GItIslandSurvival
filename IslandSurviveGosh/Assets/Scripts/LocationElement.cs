using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationElement : MonoBehaviour
{
    public LocationData data;

    [SerializeField] GameObject foodIcon;
    [SerializeField] GameObject waterIcon;
    [SerializeField] GameObject dangerIcon;
    [SerializeField] GameObject foodMeter;
    [SerializeField] GameObject waterMeter;
    [SerializeField] GameObject dangerMeter;

    void Start()
    {
        InitializeVisuals();
    }

    void InitializeVisuals()
    {
        for (int i = 0; i < data.displayData.Food; i++)
        {
            Instantiate(foodIcon,foodMeter.transform);
        }

        for (int i = 0; i < data.displayData.Water; i++)
        {
            Instantiate(waterIcon,waterMeter.transform);
        }

        for (int i = 0; i < data.displayData.Danger; i++)
        {
            Instantiate(dangerIcon,dangerMeter.transform);
        }
    }

}

[System.Serializable]
public class LocationData
{
    //============References============
    public string LocationName;
    public LocationElement locationElement;
    public DisplayData displayData = new();


    //==================================


}

[System.Serializable]
public class DisplayData
{
    //=============Basics===============

    public string LocationDisplayedName;
    public string LocationDescription;
    public Color LocationColor;
    public Sprite LocationSprite;
    //=================================
    //===========GameplayData==========
    public int Danger;
    public int Food;
    public int Water;
    public int Vine;
    public int Gravel;
    public int Wood;
    //=================================
} 


