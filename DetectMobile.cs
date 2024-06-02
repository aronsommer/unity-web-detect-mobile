using System.Runtime.InteropServices;

[DllImport("__Internal")]
private static extern bool IsMobile();

public bool isMobile()
{
    #if !UNITY_EDITOR && UNITY_WEBGL
    return IsMobile();
    #endif
    return false;
}