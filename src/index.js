const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question("Olá. Qual é o nome do seu Herói?\n", function(nomeHeroi) {
    rl.question(`Qual é o XP de ${nomeHeroi}?\n`, function(xp) {
        let nivel = obterNivel(parseFloat(xp));
        console.log(`O Herói ${nomeHeroi} está no nível ${nivel}`);
        rl.close();
    });
});

function obterNivel(xp) {
    if (xp < 1000)
        return "Ferro";
    else if (xp < 2000)
        return "Bronze";
    else if (xp < 5000)
        return "Prata";
    else if (xp < 7000)
        return "Ouro";
    else if (xp < 8000)
        return "Platina";
    else if (xp < 9000)
        return "Ascendente";
    else if (xp < 10000)
        return "Imortal";
    else
        return "Radiante";
}