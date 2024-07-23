using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    public List<LocationData> LocationDataList = new List<LocationData>();


    //Interaction Variables
    public LocationData currentViewingLocation;
    public LocationData firstSelectedLocation;
    public LocationData secondSelectedLocation;

    void Awake()
    {
        foreach(LocationData locationData in LocationDataList)
        {
            {
                locationData.locationElement.data = locationData;
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
