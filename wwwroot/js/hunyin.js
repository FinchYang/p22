
document.getElementById("searchAllButton").addEventListener("click", function (event) {
    var id = document.getElementById("id_card").value;
    var name = document.getElementById("fullname").value;

    connection.invoke("MarriageSearch", id, name).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

