document.addEventListener("DOMContentLoaded", function () {
    // Select your elements
    let langue = document.querySelector("#langue");
    let text = document.querySelector("#texte");
    let titreProjet = document.querySelector("#titreProjet"); // optional — include only if you have this element

    // French text
    let francais = `<strong style="font-size:20px;">« Essentiellement, l’entrainement utilise peu de technologie et n’a pas changé drastiquement à travers le temps. En même temps, l’analyse de l’entrainement en natation est le secteur où le potentiel de haute technologie croît rapidement. »</strong>
- Todd Desorbo, entraineur en chef de l’université de Virginie (traduite).

Êtes-vous un passionné du sport qui est à la recherche de votre prochain sport sortant de l’ordinaire?

La natation est un sport où chaque détail compte, autant d’un côté biologique qu’au côté physique. C’est un sport qui a grandement évolué depuis ses débuts et qui est devenu extrêmement compétitif, rendant la marge d’erreur de plus en plus petite. Chaque athlète travaille durement pour chercher les millièmes de secondes manquantes; de gagner et d’être celui qui finit avec leur main au mur en premier.  Certains athlètes ont naturellement un avantage génétique, mais plusieurs autres facteurs ont fait en sorte que le sport de la natation soit de plus en plus avancé et rapide. Pour les athlètes de haut niveau, savoir comprendre ses propres avantages biologiques ainsi que des nouvelles technologies est essentiel pour battre leurs propres records personnels, et parfois même pour battre des records au niveau international. Compte tenu de la montée en popularité que la natation connaît depuis les quelques dernières années, ces technologies et faits scientifiques sont pertinents à savoir pour réaliser à quel point ce sport a évolué. Il est intéressant de savoir par quels moyens la natation est devenue aussi rapide et également les aspects déjà connus qui expliquent ce même phénomène.
`;

    // English text
    let anglais = `<strong style="font-size:20px;">“Training basically is low tech and really has not changed a tremendous amount in that time. At the same time, the analysis of swim training is where the high-tech potential is growing rapidly.”</strong> 
- Todd Desorbo, head coach of the University of Virginia.

Are you a sports fanatic looking for your next favorite niche activity?

Swimming is a sport where every detail counts, as much from a biological perspective to a physical perspective. It is a sport that has greatly evolved from its beginnings and that has become very competitive, making the margin of error smaller. Every athlete works hard to get those missing milliseconds; to win and to be the one with their hand on the wall first.  Some athletes naturally have a genetical advantage, but many other factors have made the sport of swimming more advanced and faster.  For high-level athletes, understanding their own biological advantages and the new rising technologies is essential to beat their own records and to even beat records on the international level. Considering the rise in popularity that swimming has been getting in the past couple of years, these technologies and scientific aspects are relevant and important to know to realize just how much the sport of swimming has evolved. It is interesting to learn how swimming has gotten faster and why swimming is so much faster now.
`;

    // Start in english
    let enAnglais = true;
    text.innerHTML = anglais;

    // Handle language toggle
    langue.addEventListener("click", function () {
        if (enAnglais) {
            text.innerHTML = francais;
            langue.textContent = "EN";
            if (titreProjet) titreProjet.textContent = "Projet Anglais";
            enAnglais = false;
        } else {
            text.innerHTML = anglais;
            langue.textContent = "FR";
            if (titreProjet) titreProjet.textContent = "English Project";
            enAnglais = true;
        }
    });
});
