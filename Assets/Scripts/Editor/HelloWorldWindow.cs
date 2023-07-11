using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HelloWorldWindow : EditorWindow
{

    [MenuItem("Tools/HelloWorld")]
    static void Init()
    {
        HelloWorldWindow w = (HelloWorldWindow)EditorWindow.GetWindow(typeof(HelloWorldWindow));
        w.minSize = new Vector2(250, 400);
        w.Show();
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("Press the button!");

        if(GUILayout.Button("Press me"))
        {
            Debug.Log("hello world!");
        }
    }
}
