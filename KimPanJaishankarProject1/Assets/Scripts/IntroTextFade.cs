using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTextFade : MonoBehaviour
{
   public GameObject canvasText1;
    void Start ()
    {
        Invoke("DisableText", 5f);//invoke after 5 seconds
    }
    void DisableText()
    {
        // canvasText1.enabled = false;
        canvasText1.SetActive(false);
    }
}


// public class IntroTextFade : MonoBehaviour
// {
//     public Color targetColor = new Color(0, 0, 0, 0); 
//     public Material materialToChange;
//     void Start()
//     {
//         materialToChange = gameObject.GetComponent<Renderer>().material;
//         StartCoroutine(LerpFunction(targetColor, 5));
//     }
//     IEnumerator LerpFunction(Color endValue, float duration)
//     {
//         float time = 0;
//         Color startValue = materialToChange.color;
//         while (time < duration)
//         {
//             materialToChange.color = Color.Lerp(startValue, endValue, time / duration);
//             time += Time.deltaTime;
//             yield return null;
//         }
//         materialToChange.color = endValue;
//     }
// }