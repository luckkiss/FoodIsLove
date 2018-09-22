﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodWorldMenu : UIScreen
{

    [Space, Header("Screens to switch to")]
    [SerializeField]
    private SO_Tag _CreateRoomScreenTag;
    [SerializeField]
    private SO_Tag _JoinRoomScreenTag;
    [SerializeField]
    private SO_Tag _MainMenuScreenTag;

    public void OnClickCreateRoom()
    {
        _UIManager.SetScreen(_CreateRoomScreenTag);
    }

    public void OnClickJoinRoom()
    {
        _UIManager.SetScreen(_JoinRoomScreenTag);
    }

    public void OnClickMainMenu()
    {
        _UIManager.SetScreen(_MainMenuScreenTag);
    }
}
