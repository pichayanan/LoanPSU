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
        $(".owl-carousel").owlCarousel({
            autoplay: true,
            autoplayhoverpause: true,
            items: 4,
            nav: true,
            loop: true,
            margin: 5,
            padding: 5,
            stagepadding: 5,
            responsive: {
                0: {
                    items: 1,
                    dots: false
                },
                485: {
                    items: 2,
                    dots: false
                },
                728: {
                    items: 2,
                    dots: false
                },
                960: {
                    items: 2,
                    dots: false
                },
                1200: {
                    items: 3,
                    dots: false
                },
            }
        });
    })
}

function emptyFile() {
    var file = document.querySelector('input');
    var emptyFile = document.createElement('input');
    emptyFile.type = 'file';
    file.files = emptyFile.files;
}

function checkboxSwitch() {
    const cb = document.getElementById('checkbox');
    console.log(cb.checked);
    return cb.checked
}

