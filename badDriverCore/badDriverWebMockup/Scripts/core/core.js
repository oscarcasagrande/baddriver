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