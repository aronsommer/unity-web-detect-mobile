using System.Runtime.InteropServices;

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