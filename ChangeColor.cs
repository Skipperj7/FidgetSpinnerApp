using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeColor : MonoBehaviour
{

    public Color Color;
    public Renderer FidgetBody;
    public Renderer FidgetCap;
    public Renderer FidgetRing1;
    public Renderer FidgetRing2;
    public Renderer FidgetRing3;
    public Image colorPreview;
    public Slider slide;
    public Slider slide1;
    public Slider slide2;
    public Slider slide3;
    public Button body;
    public Button cap;
    public Button rightRing;
    public Button topRing;
    public Button leftRing;
    public Button Reset;
    public Button Save;
    void Start()
    {
        FidgetBody.material.color = Color.white;
        FidgetCap.material.color = Color.white;
        FidgetRing1.material.color = Color.white;
        FidgetRing2.material.color = Color.white;
        FidgetRing3.material.color = Color.white;

        
        body.onClick.AddListener(bodySet);
        cap.onClick.AddListener(capSet);
        rightRing.onClick.AddListener(rightSet);
        topRing.onClick.AddListener(topSet);
        leftRing.onClick.AddListener(leftSet);
        Reset.onClick.AddListener(resetSet);
        Save.onClick.AddListener(saveSet);
        SpinnerColor.colorChanged = false;
        SpinnerColor.bodyChange = false;
    }

    void Update()
    {
         SpinnerColor.newColor = new Color(slide.value / 255, slide1.value / 255, slide2.value / 255, slide3.value / 255);
        colorPreview.material.color = SpinnerColor.newColor;
        
    }

   
    void bodySet()
    {
        SpinnerColor.newColorBody = SpinnerColor.newColor;
        FidgetBody.material.color = SpinnerColor.newColorBody;
        SpinnerColor.bodyChange = true;
    }
    void capSet()
    {
        SpinnerColor.newColorCap = SpinnerColor.newColor;
        FidgetCap.material.color = SpinnerColor.newColorCap;
        SpinnerColor.capChange = true;
    }
    void rightSet()
    {
        SpinnerColor.newColorRight = SpinnerColor.newColor;
        FidgetRing1.material.color = SpinnerColor.newColorRight;
        SpinnerColor.rightChange = true;
    }
    void topSet()
    {
        SpinnerColor.newColorTop = SpinnerColor.newColor;
        FidgetRing2.material.color = SpinnerColor.newColorRight;
        SpinnerColor.topChange = true;
    }
    void leftSet()
    {
        SpinnerColor.newColorLeft = SpinnerColor.newColor;
        FidgetRing3.material.color = SpinnerColor.newColorLeft;
        SpinnerColor.leftChange = true;
    }

    void resetSet()
    {
        SpinnerColor.newColorBody = Color.white;
        SpinnerColor.newColorCap = Color.white;
        SpinnerColor.newColorRight = Color.white;
        SpinnerColor.newColorTop = Color.white;
        SpinnerColor.newColorLeft = Color.white;
        FidgetBody.material.color = Color.white;
        FidgetCap.material.color = Color.white;
        FidgetRing1.material.color = Color.white;
        FidgetRing2.material.color = Color.white;
        FidgetRing3.material.color = Color.white;
    }

    void saveSet()
    {
        SceneManager.LoadScene(3);
        SpinnerColor.colorChanged = true;
    }
}
