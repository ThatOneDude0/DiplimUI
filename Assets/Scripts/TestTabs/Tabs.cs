using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Tabs : EditorWindow 
{
    public int tabs = 3;
    string[] _tabName = new string[] { "Step 1", "Step 2", "Step 3" };

    //test
    public ButtonBehaviourType buttonBehaviourType;
    private IButtonBehaviour _buttonBehaviour;


    public Color baseColor = Color.white;
    public Color enterColor = Color.white;
    public Color clickColor = Color.white;

    public Vector3 baseScale = new Vector3(1f, 1f);
    public Vector3 enterScale = new Vector3(1.2f, 1.2f);
    public Vector3 clickScale = new Vector3(1f, 1f);
    //test

    [MenuItem("Window/Tabs")]
    public static void ShowWindow()
    {
        Tabs t = (Tabs)GetWindow(typeof(Tabs));
        t.minSize = new Vector2(300, 200);
        t.maxSize = new Vector2(300, 200);
    }

    private void OnGUI()
    {
        tabs = GUILayout.Toolbar(tabs, _tabName);

        switch (tabs)
        {
            case 0:
                FirstButton();
                break;
            case 1:
                SecondButton();
                break;
            case 2:
                ThirdButton();
                break;
        }
    } 
    
    //private void OnGUI()
    //{
    //    tabs = GUILayout.Toolbar(tabs, _tabName);

    //    switch (tabs)
    //    {
    //        case 0:
    //            FirstButton();
    //            break;
    //        case 1:
    //            SecondButton();
    //            break;
    //        case 2:
    //            ThirdButton();
    //            break;
    //    }
    //}

    private void FirstButton()
    {
        //switch (buttonBehaviourType)
        //{
        //    case ButtonBehaviourType.ScaleChange:
        //        {
        //            _buttonBehaviour = new ScaleChanger(baseScale, enterScale, clickScale); 
        //            break;
        //        }
        //    case ButtonBehaviourType.ColorChange:
        //        {
        //            _buttonBehaviour = new ColorChanger(baseColor, enterColor, clickColor);
        //            break;
        //        }

        //}
    }

    private void SecondButton()
    {

    }

    private void ThirdButton()
    {

    }
}
