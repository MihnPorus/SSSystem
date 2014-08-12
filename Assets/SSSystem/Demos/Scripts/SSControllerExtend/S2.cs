﻿using UnityEngine;
using System.Collections;

public class S2 : SSController 
{
	public override void Awake ()
	{
		BgmType = Bgm.PLAY;
		BgmName = "S2";

		IsCache = true;
	}

    public override void OnKeyBack()
    {
        SceneManagerDemo.Instance.GoHome();
    }

    public void OnButtonPopUp1Tap()
    {
        SceneManagerDemo.Instance.PopUp("P1");
    }

    public void OnButtonPopUp2Tap()
    {
        SceneManagerDemo.Instance.PopUp("P2");
    }

    public void OnButtonAddScreen4Tap()
    {
        SceneManagerDemo.Instance.AddScreen("S4");
    }
}
