var d = new Date();

var charList = [{name: "Heiel", story: "Heiel was a curious case."},
{name: "Elros", story: "Elros was a more serious and good elf. Still, from a good heart and virtuos values he fell into de depths of despair, becaming the bringer of tyranny"},
{name: "Night", story: "Night was a lost child, searching for the truth behind his existence, he came to a revelation of his undead body"},
{name: "Ghanis", story: "Ghanis was a crazy fire mage, his mind almost fully filled with insanity and the will to burn everything in sight, still have a little space for friendship and evolution"}
];

alert(d.getHours);

function initPage(){
    document.getElementById("page-time").innerHTML = d.getHours + ":" + d.getMinutes;
    document.getElementById("charstory").innerHTML = charList[0].story;
}

window.onload = initPage;

function getStory(){
document.getElementById("charstory").innerHTML = charList[3].story;
}

