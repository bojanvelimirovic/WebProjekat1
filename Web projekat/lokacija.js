export class Lokacija{
    constructor(i,j,ime, boja) {
        this.x=i;
        this.x=j;
        this.kapacitet=0;
        this.maxKapacitet = 1;
        this.boja=boja; //zavisno od vrste karte
        this.ime = ime;
        this.miniKontejner =null;
        
    }


    vratiBoju(){
        if(!this.boja)
        return "white";
        else 
        return this.boja;
    }

    crtajLokaciju(host){
        this.miniKontejner = document.createElement("div");
        this.miniKontejner.className="lok";
        this.miniKontejner.innerHTML="Slobodno sediste";
        this.miniKontejner.style.backgroundColor = this.vratiBoju();
        host.appendChild( this.miniKontejner);
    }

    azurirajLokaciju(ime, kolicina,boja,x,y){

        console.log("pozvano azuriranje");

        if(kolicina+this.kapacitet>this.maxKapacitet)
            alert("Kapacitet lokacije je popunjen");
        else
        {

            this.ime=ime;
            this.boja=boja;
            this.kapacitet+=kolicina;
            this.miniKontejner.innerHTML = this.ime+", "+"Popunjeno sediste";
            this.miniKontejner.style.backgroundColor=this.vratiBoju();
        }
    }
}