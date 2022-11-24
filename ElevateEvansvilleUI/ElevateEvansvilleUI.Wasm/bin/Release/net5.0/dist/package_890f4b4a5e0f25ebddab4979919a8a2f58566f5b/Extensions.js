//Checks the Browser for mobile devices and returns a bool
function IsDeviceMobile()
{
    if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent))
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Checks if the user clicks the forward or back button then calls C# function
window.onpopstate = function () {
    const HandleURI = Module.mono_bind_static_method(
        "[ElevateEvansvilleUI.Wasm] ElevateEvansvilleUI.Extensions.Navigation:HandleURI");

    HandleURI();
}


//Updates the URL in the browser when a user navigates inside the web app
function PushURL(PageRoute)
{
    //window.history.pushState({ page: "" }, "", PageRoute);
    window.history.replaceState({ page: "" }, "", PageRoute);
}

function ReplaceURL(PageRoute) {
    window.history.replaceState({ page: "" }, "", PageRoute);
}