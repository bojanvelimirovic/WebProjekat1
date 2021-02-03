import {Avion} from "./avion.js"


fetch("https://localhost:5001/Avion/PreuzmiAvione").then(p => {
    p.json().then(data =>{
        data.forEach(avion=>{
            const avion1 = new Avion(avion.id, avion.naziv, avion.x,avion.y, avion.kapacitetLokacije);
            avion1.napraviAvion(document.body);

            avion.lokacije.forEach(lok => {
                avion1.lokacije[lok.n * avion.x + lok.m].azurirajLokaciju(lok.ime, lok.kolicina, lok.boja, lok.x, lok.y);
            });
        });
    })
});

//const avion1 = new Avion("LowCost", 10, 4, 1);
//avion1.napraviAvion(document.body);

//const avion2 = new Avion("Beograd - Milano", 30, 4, 1);
//avion2.napraviAvion(document.body);