{
function Validation_of_form(){
    var userid = document.forms["reg"]["userid"];
    var password = document.forms["reg"]["password"];
    var name = document.forms["reg"]["name"];
    var address = document.forms["reg"]["address"];
    var country = document.forms["reg"]["country"];
    var zipcode = document.forms["reg"]["zipcode"];
    var email = document.forms["reg"]["email"];
    var sex= document.forms["reg"]["sex"];

    console.log(name.value);
    if(name.value == ""){
        window.alert("please enter your name in box");
        name.focus();
    }
    if()
}
}