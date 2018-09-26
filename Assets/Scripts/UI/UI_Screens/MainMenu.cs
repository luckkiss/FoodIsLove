﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : UIScreen
{

    [Space, Header("Screens to switch to")]
    [SerializeField]
    private SO_Tag _MainOptionsScreenTag;
    [SerializeField]
    private SO_Tag _CreditsScreenTag;
    [SerializeField]
    private SO_Tag _FoodWorldScreenTag;
    [SerializeField]
    private SO_GenericEvent _MainMenuMusicEvent;

    protected override void Start()
    {
        base.Start();
        _MainMenuMusicEvent.Invoke(null);
    }

    public void OnClickedMainOptions()
    {
        _UIManager.SetScreen(_MainOptionsScreenTag);
    }

    public void OnClickedCredits()
    {
        _UIManager.SetScreen(_CreditsScreenTag);
    }

    public void OnClickedFoodWorld()
    {
        _UIManager.SetScreen(_FoodWorldScreenTag);
    }

}
