function onButtonClick(expectedEvent, arguments) {

    var current_window = window;
    var current_browser = current_window.navigator.appCodeName;
    var ism = current_browser == "Mozilla";

    if (ism) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
