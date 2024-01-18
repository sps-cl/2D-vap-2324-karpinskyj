class Platno{
    constructor(sirka, vyska) {
        this.platno = document.createElement("canvas");
        this.platno.width = sirka;
        this.platno.height = vyska;
        document.body.appendChild(this.platno);
        this.kontext = this.platno.getContext("2d");
        this.kontext.lineCap = "round";
    }

    nastavSirkuObtazeni(sirka) {
        this.kontext.lineWidth = sirka;
    }

    nastavBarvuObtazeni(barva) {
        this.kontext.strokeStyle = barva;
    }

    nastavBarvuVyplne(barva) {
        this.kontext.fillStyle = barva;
    }

    nakresliCaru(startX, startY, konecX, konecY) {
        this.kontext.beginPath();
        this.kontext.moveTo(startX, startY);
        this.kontext.lineTo(konecX, konecY);
        this.kontext.stroke();
    }

    vymaz() {
        this.kontext.clearRect(0, 0, this.platno.width, this.platno.height);
    }
}

let platno = new Platno(800, 800);
platno.nastavBarvuObtazeni("blue");
platno.nastavSirkuObtazeni(10);
let x = 0;
let y = 0;
let draw = false;

document.addEventListener("keydown", (event) => {
    if (event.key.toLowerCase() === "c") {
        platno.vymaz();
    }
})

platno.platno.addEventListener("mousedown", (event)=> {
    let rect = platno.platno.getBoundingClientRect();
    x = event.clientX - rect.x;
    y = event.clientY - rect.y;
    draw = true;
});

platno.platno.addEventListener("mouseup", (event)=> {
    draw = false;
});

platno.platno.addEventListener("mousemove", (event) => {
    if (draw) {
        let rect = platno.platno.getBoundingClientRect();
        let newX = event.clientX - rect.x;
        let newY = event.clientY - rect.y;
        platno.nakresliCaru(x, y, newX, newY);
        x = newX;
        y = newY;
    }
});