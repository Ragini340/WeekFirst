
const register = function (event) {

    let r_name = document.querySelector("#name").value;
    let r_email = document.querySelector("#email").value;
    let r_address = document.querySelector("#address").value;
    let r_contact = document.querySelector("#contact").value;

    tname.innerHTML = r_name;
    temail.innerHTML = r_email;
    tadd.innerHTML = r_address;
    tcontact.innerHTML = r_contact;
    event.preventDefault();
};

