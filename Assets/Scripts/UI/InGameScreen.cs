using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameScreen : ScreenBase
{

    public void Return()
    {
        App.gameManager.ReturnToMenu();
        Hide();
    }
}
