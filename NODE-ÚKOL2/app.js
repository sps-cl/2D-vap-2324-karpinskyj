const mysql2 = require("mysql2");
const express = require("express");
const path = require("path");

const connection = mysql2.createConnection(
    {
        host: "127.0.0.1",
        user: "root",
        password: "root",
        port: "3306",
        database: "moje_db"
    }
);

connection.connect((error) => {
    if (error) {
        console.log(error)
    } else {
        console.log("Úspěšně připojeno.");
        const jmeno = "Andrej";
        const prijmeni = "Karpinskyj";
        connection.query(
            `INSERT INTO uzivatele(jmeno, prijmeni) VALUES('${jmeno}', '${prijmeni}');`
        , (error, data) => {
            if (error) console.log(error);
        });
        connection.query(
            'SELECT * FROM uzivatele;', (error, data) => {
                if (error) console.log(error);
                else {
                    console.log(data);
                }
            }
        )
    }
});

const app = express();
app.use(express.static(__dirname));
app.use(express.urlencoded({extended: true}));
app.use(express.json());

app.get("/", (reg, res) => {
    res.sendFile(path.join(__dirname, 'index.html'));
});

app.post("/uloz-uzivatele", (req, res) => {
    console.log(req.body);
    res.redirect("/");
});

app.listen(5500);
