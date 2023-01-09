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


//Gets a unique I.D. for a device that can be checked with the API to determine if the device belongs to a volunteer.
function GetMachineId() {

    let machineId = localStorage.getItem('MachineId');

    if (!machineId) {
        machineId = crypto.randomUUID();
        localStorage.setItem('MachineId', machineId);
    }

    return machineId;
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