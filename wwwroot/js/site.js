// Write your Javasc

function findGuarantorJS(guarantorVal) {
        let data = ["yes", "YouTube"];
        $("#guarantorList").empty();
    // ดึงชื่อจาก db ตรวจสอบแล้วกำหนดค่า
    if (guarantorVal == "y") {
        let liTax = "";
        for (let index = 0; index < data.length; index++) {
            const element = data[index];
            liTax =
                liTax +
                `<li><a class="dropdown-item" onclick="changeValGuarantor('${element}')"  >${element}</a></li>`;
        }
        const ulTax = `<ul>${liTax}</ul>`;
        $("#guarantorList").append(ulTax);
    } else {
        document.getElementById("guarantorVal").value = "";
    }
}

function changeValGuarantor(text) {
    document.getElementById("guarantorVal").value = text;
}

function AddDocument(id) {
    console.log("AddDocument: ", id+1)
    return id+1
}

function Cardimgheader(file) {
    console.log("UploadFile: ", file)
}

window.displayTickerAlert1 = (symbol, price) => {
    alert(`${symbol}: $${price}!`);
};

function Cardimgheader()
{
    $(document).ready(function () {
        $(".owl-carousel").owlCarousel();
    })
}

