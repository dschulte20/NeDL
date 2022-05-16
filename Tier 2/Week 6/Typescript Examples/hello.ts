function myFunction() {
    let newName : string = "Derek"; 
    newName = (<HTMLInputElement>document.getElementById("fname")).value;
    document.getElementById("greeting").innerHTML = "Hello " + newName + "!";
}
