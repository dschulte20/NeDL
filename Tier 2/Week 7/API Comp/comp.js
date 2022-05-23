async function getInfo(){

    var apiString = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
    https://ron-swanson-quotes.herokuapp.com/v2/quotes

    alert(apiString)
  
    console.log(apiString);
  
    var response = await fetch(apiString);
    //making call to web service

    document.getElementById("newCoin").innerHTML="";
    //printing response

    var jsonData = await response.json();
  
    //document.getElementById("newCoin").innerHTML = JSON.stringify(jsonData);
    //printing JSON object in newCoin section

    for (var para in jsonData){
      document.getElementById("newCoin").innerHTML += "<p>" + jsonData[para] + "</p>";
    }//loop through and print each object

    return true;
  }