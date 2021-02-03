import { Lokacija } from "./lokacija.js";

export class Avion{
    constructor(id, naziv, x, y, kapacitetLokacije ){
        this.id = id;
        this.naziv=naziv;
        this.x=x;
        this.y=y;
        this.kapacitet=kapacitetLokacije;
        this.kontejner =null;
        this.lokacije=[];
        
    }

    dodajLokaciju(lok){
        this.lokacije.push(lok);
    }

    napraviAvion(host){

        if(!host)
            throw new Exception("Roditeljski element ne postoji");
        
        this.kontejner = document.createElement("div");
        this.kontejner.classList.add("kontejner");
        host.appendChild(this.kontejner);

        this.crtajFormu(this.kontejner);
        this.crtajSedista(this.kontejner);

    }

    
    

    crtajFormu(host){
        const kontForma = document.createElement("div");
        kontForma.className="forma";
        host.appendChild(kontForma);

        var imePrezime = document.createElement("label");
        imePrezime.className = "text";
        imePrezime.innerHTML = "Unesite ime za rezervaciju";
        kontForma.appendChild(imePrezime);

        let unosImena = document.createElement("input");
        unosImena.id = "ime";
        unosImena.className = "ime";
        kontForma.appendChild(unosImena);

        var odaberiKartu = document.createElement("label");
        odaberiKartu.className = "text";
        odaberiKartu.innerHTML = "Izaberite tip karte:";
        kontForma.appendChild(odaberiKartu);


        let tipoviKarata = ["Za odrasle", "Za decu", "Za studente"];
        let tipoviBoja = ["red","green", "blue"];

        let opcija = null;
        let labela = null;
        let div1 = null;
        
        
        tipoviKarata.forEach((karta, index)=>{
            div1 = document.createElement("div");
            opcija = document.createElement("input");
            opcija.type = "radio";
            opcija.name = this.naziv;
            opcija.value = tipoviBoja[index];

            labela = document.createElement("label");
            labela.innerHTML = karta;

            

            div1.appendChild(opcija);
            div1.appendChild(labela);
           
            kontForma.appendChild(div1);
        })

    

        div1 = document.createElement("div");
        let sediste = document.createElement("select");
        labela = document.createElement("label");
        labela.innerHTML = "Sediste";

        div1.appendChild(labela);
        div1.appendChild(sediste);
        

        for(let i=0; i<this.y;i++){
            opcija = document.createElement("option");
            opcija.innerHTML = i+1;
            opcija.value = i;
            sediste.appendChild(opcija);
        }

        kontForma.appendChild(div1);

        let red = document.createElement("select");
        labela = document.createElement("label");
        labela.innerHTML = "Red";
        div1.appendChild(labela);
        div1.appendChild(red);

        for(let i=0; i<this.x;i++){
            opcija = document.createElement("option");
            opcija.innerHTML = i+1;
            opcija.value = i;
            red.appendChild(opcija);
        }
        
        kontForma.appendChild(div1);

        const dugme = document.createElement("button");
        dugme.innerHTML = "Rezervisi kartu";
        kontForma.appendChild(dugme);
        dugme.onclick=(ev)=>{

            const ime = this.kontejner.querySelector(".ime").value;
            const boja = this.kontejner.querySelector(`input[name='${this.naziv}']:checked`);
            var kolicina = 1;


            if(boja==null)
                alert("Odaberite tip karte");

            let n = parseInt(sediste.value);
            let m = parseInt(red.value);

            //this.lokacije[n*this.x+m].azurirajLokaciju(ime, kolicina, boja.value, n,m);

            fetch("https://localhost:5001/Avion/UpisLokacije/" + this.id, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({
                    ime: ime,
                    kapacitet: kolicina,
                    maxKapacitet: this.kapacitet,
                    boja: boja.value,
                    n: n,
                    m: m
                })
            }).then(p => {
                if (p.ok) {
                    this.lokacije[n * this.x + m].azurirajLokaciju(ime, kolicina, boja.value, n, m);
                }
               
                else {
                    alert("Greška prilikom upisa.");
                }
            })
                
        }
       

       

    }

    

    crtajSedista(host){
        
        const kontSedista = document.createElement("div");
        kontSedista.className = "kontSedista";
        kontSedista.id = "kontSedista";
        host.appendChild(kontSedista);
        let ImeLeta = document.createElement("label");
        ImeLeta.innerHTML = this.naziv;
        kontSedista.appendChild(ImeLeta);
        let vrsta;
        let kolona;
        let lok;
        for(let i=0; i<this.y;i++){
            vrsta = document.createElement("div");
            vrsta.className = "vrsta";
            kontSedista.appendChild(vrsta);
            for(let j=0;j<this.x;j++){
                lok = new Lokacija(i,j,"","",this.kapacitet);
                this.dodajLokaciju(lok);
                lok.crtajLokaciju(vrsta);
            }
        }
        
    }




}