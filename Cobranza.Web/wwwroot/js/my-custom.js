function redirectTo(url) {
    window.location.href = url;
}


function loadList(comboBox, url) {
    clearComboBox(comboBox);
    $.ajax({
        url: url,
        success: function (response) {
            fillComboBox(response, comboBox);
        } 
    });
}

function fillComboBox(data, comboBox) {
    let option;
    if (data.length > 0) {
        const defaultOption = document.createElement('option');
        defaultOption.text = 'Sin definir';
        defaultOption.value = '';
        comboBox.add(defaultOption);
    }
    for (let i = 0; i < data.length; i++) {
        option = document.createElement('option');
        option.text = data[i].description;
        option.value = data[i].code;
        comboBox.add(option);
    }
}

function clearComboBox(comboBox) {
    while (comboBox.options.length > 0) {
        comboBox.remove(0);
    }
}




