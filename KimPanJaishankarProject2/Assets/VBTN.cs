using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        cube.SetActive(false);
        /*cube = GameObject.Find("VirtualButton");
        cube.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        cube.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        Vb.GetComponent<Animator>();*/
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
        /*Vb.Play("cube_animation");
        Debug.Log("Button pressed");*/
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
        //Vb.Play("none");
        //Debug.Log("Button released");
    }
}
