function changeStyle(){
    var element = document.getElementById("myElement");
    element.style.width = "20000px";
}
function randomQuote() {
    var quotes = new Array();
    quotes[0] = "Action is the real measure of intelligence.";
    quotes[1] = "My life has got to be like a shooting star old sport. its got to keep going up";
    quotes[2] = "Every goal, every action, every thought, every feeling one experiences, whether it be consciously or unconsciously known, is an attempt to increase one's level of peace of mind.";
    quotes[3] = "A good head and a good heart are always a formidable combination.";
    var rand = Math.floor(Math.random()*quotes.length);

    let randomQuoteDiv = document.getElementById
    ("random quote");

    if(){
    let quotebody = document.createElement("p");
    quotebody.id="quotebody";
    quotebody.innerText=quotes[rand];
    randomQuoteDiv.appendChild(quotebody);
    }
    else{

    }
}






// start of API text message code
let message = {
    "Body": "Check out this cool website about Clinton", 
    "From": "+12674599904",
    "To":"+12406913415"
}
const accountSid="ACd67188397f67522b2840d34062b5c3ec";
const authToken="0457966e810d18398709513195861ca3";

$(document).ready(function(){
    $.ajax({
        type: "POST",
        url: "https://api.twilio.com/2010-04-01/Accounts/ACd67188397f67522b2840d34062b5c3ec/Messages.json",
        headers: {"Authorization": "Basic " + btoa(accountSid + ":" + authToken)}, 
        data: jQuery.param(message),
        success: function (response) {
            alert(response.status);
        },
        error: function () {
            alert("error");
        }
    });
})
//end of text message code

