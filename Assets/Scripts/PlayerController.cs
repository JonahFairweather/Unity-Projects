using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float paddingLeft;
    [SerializeField] float paddingRight;
    [SerializeField] float paddingTop;
    [SerializeField] float paddingBottom;
    Vector2 rawInput;

    Vector2 minBounds;
    Vector2 maxBounds;

    void Start(){
        InitBounds();
    }
    
        void OnMove(InputValue value){
        rawInput = value.Get<Vector2>();
    }

    void InitBounds(){
        Camera mainCamera = Camera.main;
        minBounds = mainCamera.ViewportToWorldPoint(new Vector2(0,0));
        maxBounds = mainCamera.ViewportToWorldPoint(new Vector2(1,1));
    }

    
    void Update()
    {
        Vector2 delta = rawInput * moveSpeed * Time.deltaTime;
        Vector2 newPos = new Vector2();
        newPos.x = Mathf.Clamp(transform.position.x+delta.x, minBounds.x+paddingLeft, maxBounds.x-paddingRight);
        newPos.y = Mathf.Clamp(transform.position.y+delta.y, minBounds.y+ paddingBottom, maxBounds.y-paddingTop);
        transform.position = newPos;
    }
}
