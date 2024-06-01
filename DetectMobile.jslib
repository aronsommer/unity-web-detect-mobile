var DetectMobilePlugin = {
    IsMobile: function()
    {
        return UnityLoader.SystemInfo.mobile;
    }
};

mergeInto(LibraryManager.library, DetectMobilePlugin);