indx = 0
const posi = document.getElementById("ind")
const pergunta = document.getElementById("pergunta")
const r1 = document.getElementById("r1")
const r2 = document.getElementById("r2")
const r3 = document.getElementById("r3")
const r4 = document.getElementById("r4")
const dica = document.getElementById("dica")

const levels = [
["Oque é código Morse?", "sinais longos e curtos", "zeros(0) e ums(1)", "uma linguagem", "Um animal", 1, "...---..."],
["pergunta2", "teste", "dalva", "carlinhos", "carteiro gosmico", 3, "o mestre"]
]
ind.textContent = indx+1
pergunta.textContent = levels[indx][0]
r1.textContent = levels[indx][1]
r2.textContent = levels[indx][2]
r3.textContent = levels[indx][3]
r4.textContent = levels[indx][4]

function enviar(res){
    if (res == levels[indx][5]){
        indx++;
        posi.textContent = indx+1
        pergunta.textContent = levels[indx][0]
        r1.textContent = levels[indx][1]
        r2.textContent = levels[indx][2]
        r3.textContent = levels[indx][3]
        r4.textContent = levels[indx][4]
        dica.textContent = ""
    }
}
function mostrar(){
    dica.textContent = levels[indx][6]
}