using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    Vector2 rawInput;
    void OnMove(InputValue value){
        rawInput = value.Get<Vector2>();
    }

    
    void Update()
    {
        Vector2 delta = rawInput * moveSpeed * Time.deltaTime;
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
