var DetectMobilePlugin = {
    IsMobile: function()
    {
        // return UnityLoader.SystemInfo.mobile;
        return Module.SystemInfo.mobile;
    }
};

mergeInto(LibraryManager.library, DetectMobilePlugin);