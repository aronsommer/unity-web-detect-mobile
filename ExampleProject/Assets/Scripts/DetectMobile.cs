using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;

public class DetectMobile : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern bool IsMobile();

    public bool isMobile()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
    return IsMobile();
#endif
        return false;
    }

    public TextMeshProUGUI Txt;

    void Start()
    {
        if (isMobile())
        {
            Txt.text = "Its a mobile device";
        }
        else
        {
            Txt.text = "Its not a mobile device";
        }
    }
}
