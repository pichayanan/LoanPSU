// Write your Javasc

function AddDocument(id) {
    console.log("AddDocument: ", id + 1)
    return id + 1
}

function Cardimgheader(file) {
    console.log("UploadFile: ", file)
}

window.displayTickerAlert = (text) => {
    alert(`${text}`);
};

function Cardimgheader() {
    $(document).ready(function () {
        $(".owl-carousel").owlCarousel();
    })
}

function myFunction() {
    var file = document.querySelector('input');
    var emptyFile = document.createElement('input');
    emptyFile.type = 'file';
    file.files = emptyFile.files;
}

