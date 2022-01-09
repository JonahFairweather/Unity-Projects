using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Wave Config", fileName = "New Wave Config")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField] Transform pathPreFab;

    [SerializeField] float moveSpeed = 5f;

    public Transform GetStartingWaypoint(){
        return pathPreFab.GetChild(0);
    }

    public float GetMoveSpeed(){
        return moveSpeed;
    }

    public List<Transform> GetWaypoints(){
        List<Transform> waypoints = new List<Transform>();
        foreach(Transform child in pathPreFab){
            waypoints.Add(child);
        }
        return waypoints;
    }
    
}
