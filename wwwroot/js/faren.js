
document.getElementById("farensearch").addEventListener("click", function (event) {
    var mqxm = document.getElementById("sfzh").value;
    connection.invoke("faren",mqxm).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});