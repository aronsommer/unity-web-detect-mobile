var DetectMobilePlugin = {
    IsMobile: function () {
        // Check if iPad
        if (navigator.userAgent.match(/Mac/) && navigator.maxTouchPoints && navigator.maxTouchPoints > 2) {
            return true;
        }
        else {
            return Module.SystemInfo.mobile;
        }
        // return (/iPhone|iPad|iPod|Android/i.test(navigator.userAgent));
        // return UnityLoader.SystemInfo.mobile;
    }
};
mergeInto(LibraryManager.library, DetectMobilePlugin);