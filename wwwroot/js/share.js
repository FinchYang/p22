
document.getElementById("search_foreigner").addEventListener("click", function (event) {
    var foreigner_name = document.getElementById("foreigner_name").value;   
    connection.invoke("search_foreigner", foreigner_name).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});