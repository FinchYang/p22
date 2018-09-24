
document.getElementById("birthsearch").addEventListener("click", function (event) {
    var fqxm = document.getElementById("fqxm").value;
    var mqxm = document.getElementById("mqxm").value;
    var fqsfzhm = document.getElementById("fqsfzhm").value;
    var mqsfzhm = document.getElementById("mqsfzhm").value;
    var xsexm = document.getElementById("xsexm").value;
  
    connection.invoke("birthsearch",fqxm,mqxm,fqsfzhm,mqsfzhm, xsexm).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});