using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//this is the code for the simple editor window which launches the popup:
public class FallenChairScript : EditorWindow
{
    //used code from website: https://docs.unity3d.com/ScriptReference/PopupWindow.html 
    // Add menu item
    [MenuItem("Example/Popup Example")]
    static void Init()
    {
        EditorWindow window = EditorWindow.CreateInstance<FallenChairScript>();
        window.Show();
    }

    Rect buttonRect;
    void OnGUI()
    {
        {
            GUILayout.Label("Editor window with Popup example", EditorStyles.boldLabel);
            if (GUILayout.Button("Popup Options", GUILayout.Width(200)))
            {
                PopupWindow.Show(buttonRect, new Popup());
            }
            if (Event.current.type == EventType.Repaint) buttonRect = GUILayoutUtility.GetLastRect();
        }
    }
}

//this is the code for the popup itself 
public class Popup: PopupWindowContent
{
    bool toggle1 = true;
    //bool toggle2 = true;
    //bool toggle3 = true;

    public override Vector2 GetWindowSize()
    {
        return new Vector2(200, 150);
    }

    public override void OnGUI(Rect rect)
    {
        GUILayout.Label("Popup Options Example", EditorStyles.boldLabel);
        toggle1 = EditorGUILayout.Toggle("Toggle 1", toggle1);
        //toggle2 = EditorGUILayout.Toggle("Toggle 2", toggle2);
        //toggle3 = EditorGUILayout.Toggle("Toggle 3", toggle3);
    }

    public override void OnOpen()
    {
        Debug.Log("Popup opened: fallen chair" + this);
    }

    public override void OnClose()
    {
        Debug.Log("Popup closed: " + this);
    }
}
