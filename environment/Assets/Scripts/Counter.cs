using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using ExciteOMeter;

public class Counter : MonoBehaviour
{
    // public TMP_Text rmssd;
    public TMP_Text hr;


    void Awake()
    {
        // Subscribe to events
        EoM_Events.OnDataReceived += ExciteOMeterDataReceived;
    }


    private void ExciteOMeterDataReceived(DataType type, float timestamp, float value)
    {
        ///// You can uncomment the line below to receive data only when 
        ///// the Excite-O-Meter is recording data.
        // if (!isCurrentlyRecording) return;

        switch (type)
        {
            case DataType.NONE:
                break;
            case DataType.HeartRate:
                Debug.Log($"Received HR with timestamp {timestamp}, value {value}");
                hr.text = value.ToString();
                break;
            // case DataType.RRInterval:
            //     Debug.Log($"Received RR-interval with timestamp {timestamp}, value {value}");
            //     break;
            // case DataType.RawECG:
            //     // Currently not available
            //     break;
            // case DataType.RawACC:
            //     // Currently not available
            //     break;
            // case DataType.RMSSD:
            //     rmssd.text = value.ToString();
            //     Debug.Log($"Received calculated feature RMSSD with timestamp {timestamp}, value {value}");
            //     break;
            // case DataType.SDNN:
            //     Debug.Log($"Received calculated feature SDNN with timestamp {timestamp}, value {value}");
            //     break;
            // case DataType.EOM:
            //     break;
            // case DataType.AutomaticMarkers:
            //     // These events are captured by `EoM_Events.OnStringReceived`
            //     break;
            // case DataType.ManualMarkers:
            //     // These events are captured by `EoM_Events.OnStringReceived`
            //     break;
            // case DataType.Screenshots:
            //     Debug.Log("A new screenshot was generated in the recorded session");
            //     break;
            default:
                break;
        }
    }
}