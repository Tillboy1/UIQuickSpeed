using UnityEngine;

public class CameraOptions : MonoBehaviour
{
    [Header("Camera")]
    float horizontalRotateSpeed;
    float verticalRotateSpeed;
    bool invertHorizontalRotate = false, invertVerticalRotate = false;
    float ambiantCameraSway;

    [Header("Aim Camera")]
    float aimHorizontalRotateSpeed;
    float aimVerticalRotateSpeed;
    bool aimAssist;

    [Header("Combat Camera")]
    bool recenterCamOnAttack;
    bool strafeAssist;

    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Sensitivity
    public void SetXSensvalue(float Xsens)
    {
        horizontalRotateSpeed = Xsens;
        PlayerPrefs.SetFloat("XSens", Xsens);
    }
    public void SetYSensvalue(float Ysens)
    {
        verticalRotateSpeed = Ysens;
        PlayerPrefs.SetFloat("YSens", Ysens);
    }
    public void SetAimXSensvalue(float Xsens)
    {
        aimHorizontalRotateSpeed = Xsens;
        PlayerPrefs.SetFloat("AimXSens", Xsens);
    }
    public void SetAimYSensvalue(float Ysens)
    {
        aimVerticalRotateSpeed = Ysens;
        PlayerPrefs.SetFloat("AimYSens", Ysens);
    }

    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Inverting

    public void InvertHorizontal()
    {
        if (invertHorizontalRotate)
        {
            invertHorizontalRotate = false;
        }
        else
        {
            invertHorizontalRotate = true;
        }
    }
    public void InvertVertical()
    {
        if (invertVerticalRotate)
        {
            invertVerticalRotate = false;
        }
        else
        {
            invertVerticalRotate = true;
        }
    }

    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Bool's

    public void AimAssist()
    {
        if (aimAssist)
        {
            aimAssist = false;
        }
        else
        {
            aimAssist = true;
        }
    }
    public void RecenterCameraOnAttack()
    {
        if (recenterCamOnAttack)
        {
            recenterCamOnAttack = false;
        }
        else
        {
            recenterCamOnAttack = true;
        }
    }
    public void StrafeAssist()
    {

        if (strafeAssist)
        {
            strafeAssist = false;
        }
        else
        {
            strafeAssist = true;
        }
    }
}
