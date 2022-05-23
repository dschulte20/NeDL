function validateANDadd() {
    // place the values in the form into variables
    var theNewWord = document.forms["myForm"]["newWord"].value;
    // validate that something was entered as a word
    if (theNewWord == "") {
        // no word was entered so tell the user
        alert("Please enter a word to check");
        return false;
    }
    else {
        var tableRef = document.getElementById("myList");
        var tableRow = (tableRef.insertRow(tableRef.rows.length));
        (tableRow.insertCell(tableRow.cells.length)).innerHTML = theNewWord;
        // erase the form fields
        document.forms["myForm"]["newWord"].value = "";
        return true;
    }
}
function clearList() {
    // clear the table of all rows
    var tableRef = document.getElementById("myList");
    tableRef.innerHTML = " ";
}
function removeItem() {
    //remove an item from the list
    var removeRef = document.forms["myForm"]["removeRef"].value;
    document.getElementById("myList").innerHTML = document.getElementById("myList").innerHTML.replace(removeRef, removeRef.strike());
}
