using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaveSpinner : MonoBehaviour
{

    public Renderer FidgetBody;
    public Renderer FidgetCap;
    public Renderer FidgetRing1;
    public Renderer FidgetRing2;
    public Renderer FidgetRing3;

    void Start()
    {
        if (SpinnerColor.colorChanged){
            bodySet();
            capSet();
            rightSet();
            topSet();
            leftSet();
    }
}


   
    void bodySet()
    {
        if(SpinnerColor.bodyChange){
            FidgetBody.material.color = SpinnerColor.newColorBody;
        }
    }
    void capSet()
    {
        if(SpinnerColor.capChange)
        FidgetCap.material.color = SpinnerColor.newColorCap;
    }
    void rightSet()
    {
        if(SpinnerColor.rightChange)
        FidgetRing1.material.color = SpinnerColor.newColorRight;
    }
    void topSet()
    {
        if(SpinnerColor.topChange)
        FidgetRing2.material.color = SpinnerColor.newColorTop;
    }
    void leftSet()
    {
        if(SpinnerColor.leftChange)
        FidgetRing3.material.color = SpinnerColor.newColorLeft;
    }


}