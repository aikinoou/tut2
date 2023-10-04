using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    [SerializeField] private float speed;

    private Vector3 _moveDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this); //calls back to this player
        InputManager.GameMode();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += speed * Time.deltaTime * _moveDirection; //so things move at the same time
    }

    public void SetMoveDirection(Vector3 newDirection) //function for moving
    {
        _moveDirection = newDirection; //sets direction 
    }
}
