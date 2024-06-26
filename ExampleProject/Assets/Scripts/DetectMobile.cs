using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;

public class DetectMobile : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern bool IsMobile();

    private bool _isMobile()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        return IsMobile();
#else
        return false;
#endif
    }

    public TextMeshProUGUI Txt;

    void Start()
    {
        if (_isMobile())
        {
            Txt.text = "Its a mobile device";
        }
        else
        {
            Txt.text = "Its not a mobile device";
        }
    }
}
