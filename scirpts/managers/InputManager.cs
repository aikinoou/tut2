using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{

    private static Controls _controls; //declares _controls

    public static void Init(player wao) //calls to the player "wao"
    { 
        _controls = new Controls(); //initializes controls class

        _controls.game.movemoent.performed += ctx =>
        {
            wao.SetMoveDirection(ctx.ReadValue<Vector3>());
        };

        _controls.perma.Enable(); //enables 
    }
    
    
    public static void GameMode()
    {
        _controls.game.Enable(); //when in game mode the controls for game will be enabled and UI will be disabled
        _controls.UI.Disable();
    }



    public static void UImode()
    {
        _controls.game.Disable();
        _controls.UI.Enable();
    }





    


    





}
