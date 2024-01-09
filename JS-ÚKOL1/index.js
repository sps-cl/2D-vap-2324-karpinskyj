function vytvoritTabulku () {

    var pocetRadku = document.getElementById("pocet-radku").value;
    var pocetSloupcu = document.getElementById("pocet-sloupcu").value;
    var tabulka = document.createElement("table");
    for (var i = 0; i < pocetRadku; i++) {
        var radek = tabulka.insertRow(i);
        for (var j = 0; j < pocetSloupcu; j++) {
            var bunka = radek.insertCell(j);
            bunka.textContent = (i * pocetSloupcu + j + 1);
        }
    }
    document.body.appendChild(tabulka);
}
