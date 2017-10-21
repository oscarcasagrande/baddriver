function modelSelectChange() {
    clearSelect('ModelSelect');
    bindModel('form1', 'ModelSelect', document.getElementById('SupplierSelect').value);

}

function clearSelect(obj) {
    if (document.getElementById(obj) != null)
        document.getElementById(obj).options.length = 0;
}


function bindModel(activeForm, selectToBePopulate, supplier) {
    var j = 0;

    clearSelect(selectToBePopulate);

    for (var i = 0; i < xwm.length; i++) {
        if (supplier == zwm[i]) {
            j++;
            document.getElementById(activeForm).ModelSelect.options[j] = new Option(xwm[i], ywm[i]);
        }
    }

}

function bindSupplier(activeForm) {
    var j = 0;

    clearSelect('SupplierSelect');

    for (var i = 0; i < twm.length; i++) {
        j++;
        document.getElementById(activeForm).SupplierSelect.options[j] = new Option(twm[i], vwm[i]);
    }
}


function getLocation(objectToReceiveResult) {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition, showError);
    } else {
        objectToReceiveResult.innerHTML = "Geolocation is not supported by this browser.";
    }
}

function showPosition(position, latitudeObject, longitudeObject) {
    document.getElementById("divlatitude").innerHTML = position.coords.latitude;
    document.getElementById("divlongitude").innerHTML = position.coords.longitude;

    document.getElementById("latitudeTextBox").value = position.coords.latitude;
    document.getElementById("longitudeTextBox").value = position.coords.longitude;
}

function showPositionMap(position) {
    var latlon = position.coords.latitude + "," + position.coords.longitude;
    var img_url = "https://maps.googleapis.com/maps/api/staticmap?center="
    + latlon + "&zoom=14&size=400x300&key=AIzaSyBu-916DdpKAjTmJNIgngS6HL_kDIKU0aU";
    document.getElementById("mapholder").innerHTML = "<img src='" + img_url + "'>";
}
//To use this code on your website, get a free API key from Google.
//Read more at: https://www.w3schools.com/graphics/google_maps_basic.asp

function showError(error, objectToReceiveResult) {
    switch (error.code) {
        case error.PERMISSION_DENIED:
            objectToReceiveResult.innerHTML = "User denied the request for Geolocation."
            break;
        case error.POSITION_UNAVAILABLE:
            objectToReceiveResult.innerHTML = "Location information is unavailable."
            break;
        case error.TIMEOUT:
            objectToReceiveResult.innerHTML = "The request to get user location timed out."
            break;
        case error.UNKNOWN_ERROR:
            objectToReceiveResult.innerHTML = "An unknown error occurred."
            break;
    }
}