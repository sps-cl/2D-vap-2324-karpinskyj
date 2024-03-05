const express = require('express');
const Person = require('./person');
const app = express();
const path = require('path');

app.use(express.urlencoded({extended: true}));
app.use(express.static(__dirname));

app.get("/", (req, res) => {
  res.sendFile(path.join(__dirname + '/index.html'));
});

app.get('/', (req, res) => {
  res.sendFile(__dirname + '/index.html');
});

app.get('/random-person', (req, res) => {
  const randomPerson = new Person (
    getRandomName(),
    getRandomSurname(),
    generateRandomId()
);

  res.json(randomPerson);
});

function getRandomName() {
  const names = ["Petr", "David", "Tadeáš", "Filip", "Jan", "Josef", "Tomáš"];
  return names[Math.floor(Math.random() * names.length)];
}

function getRandomSurname() {
    const names = ["Novák", "Svoboda", "Černý", "Bílý", "Veselý", "Kučera"];
    return names[Math.floor(Math.random() * names.length)];
}

function generateRandomId() {
  return Math.floor(Math.random() * 1000);
}

app.listen(7707);
