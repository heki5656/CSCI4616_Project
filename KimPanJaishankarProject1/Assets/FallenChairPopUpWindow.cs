// using UnityEngine;
// using UnityEditor;

// public class ShowPopupExample : EditorWindow
// {
//     [MenuItem("Example/ShowPopup Example")]
//     static void Init()
//     {
//         ShowPopupExample window = ScriptableObject.CreateInstance<ShowPopupExample>();
//         window.position = new Rect(Screen.width / 2, Screen.height / 2, 250, 150);
//         window.ShowPopup();
//     }

//     void OnGUI()
//     {
//         EditorGUILayout.LabelField("Fallen chair was found at the scene of the crime, forensics have verified that the victime was sitting on it before their death.", EditorStyles.wordWrappedLabel);
//         GUILayout.Space(70);
//         if (GUILayout.Button("close")) this.Close();
//     }
// }

// /*using UnityEngine;
// using UnityEditor;

// public class EditorWindowWithPopup : EditorWindow
// {
//     // Add menu item
//     [MenuItem("Example/Popup Example")]
//     static void Init()
//     {
//         EditorWindow window = EditorWindow.CreateInstance<EditorWindowWithPopup>();
//         window.Show();
//     }

//     Rect buttonRect;
//     void OnGUI()
//     {
//         {
//             GUILayout.Label("Fallen Chair found at crime scene", EditorStyles.boldLabel);
//             if (GUILayout.Button("Press for more information", GUILayout.Width(200)))
//             {
//                 PopupWindow.Show(buttonRect, new PopupExample());
//             }
//             if (Event.current.type == EventType.Repaint) buttonRect = GUILayoutUtility.GetLastRect();
//         }
//     }
// }

// public class PopupExample : PopupWindowContent
// {
//     bool toggle1 = true;
//     bool toggle2 = true;
//     bool toggle3 = true;

//     public override Vector2 GetWindowSize()
//     {
//         return new Vector2(200, 150);
//     }

//     public override void OnGUI(Rect rect)
//     {
//         GUILayout.Label("Popup Options Example", EditorStyles.boldLabel);
//         toggle1 = EditorGUILayout.Toggle("Toggle 1", toggle1);
//         toggle2 = EditorGUILayout.Toggle("Toggle 2", toggle2);
//         toggle3 = EditorGUILayout.Toggle("Toggle 3", toggle3);
//     }

//     public override void OnOpen()
//     {
//         Debug.Log("Popup opened: " + this);
//     }

//     public override void OnClose()
//     {
//         Debug.Log("Popup closed: " + this);
//     }
// }*/