using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class broadcasterManager : MonoBehaviour
{
    public VoidEventChannelSO LocationChannel;
    [SerializeField] private Transform Location;
    void Update()
    {
        if(LocationChannel != null && Location != null)
        {
            LocationChannel.RaisedEvent();
        }
    }
}
