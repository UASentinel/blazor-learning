function callMethod() {
    DotNet.invokeMethodAsync("BlazorServerApp", "GetValue").then(result => {
        alert(result);
    });
}

function callInstanceMethod(instanceObject) {
    instanceObject.invokeMethodAsync("GetValueFromInstance").then(result => {
        alert(result);
    });
}