
document.getElementById("shengyusearch").addEventListener("click", function (event) {
    var fqxm = document.getElementById("name").value;
    var mqxm = document.getElementById("sfzh").value;
    connection.invoke("shengyusearch",fqxm,mqxm).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});