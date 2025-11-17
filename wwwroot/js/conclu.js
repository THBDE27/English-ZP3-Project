document.addEventListener("DOMContentLoaded", function () {
    // Select your elements
    let langue = document.querySelector("#langue");
    let text = document.querySelector("#texte");
    let titreProjet = document.querySelector("#titreProjet"); // optional — include only if you have this element

    // French text
    let francais = `<strong style="font-size:20px;">« La natation est une activité tellement peu naturelle pour les humains — des créatures terrestres — que je dirais que les humains dans l’eau sont encore en train d’évoluer… Nous sommes toujours en train d’apprendre. Nous cherchons encore les meilleures pratiques et les meilleures choses à faire. »</strong>
- Russell Mark, conseiller de l’American Swimming Coaches Association (traduite).

Comme nous l’avons vu, la natation est l’un des sports les plus compétitifs qui existent. C’est depuis toujours un sport où l’objectif est d’être le plus rapide et de battre le record précédemment établi. La natation exige beaucoup de technique et de compétences, mais favorise également les personnes ayant des avantages génétiques, comme Michael Phelps, dont l’acide lactique s’accumule 50 % moins vite que chez la personne moyenne, ce qui lui permet d’être moins fatigué et de récupérer plus rapidement.

Les nageurs bénéficient aussi de technologies qui les aident à battre des records dans le monde de la natation, comme les plaques de toucher, les « super suits », les tours de

puissance (« power towers »), les combinaisons techniques (« tech suits ») et les lunettes conçues pour réduire la résistance, augmenter la propulsion et aider au développement d’une meilleure technique.

Non seulement cela, mais les nageurs ont également développé de meilleures techniques qui ont permis de réduire drastiquement les temps, comme le crawl, la brasse, le papillon et le dos crawlé. Chaque technique comprend un large éventail de mouvements des bras et des jambes, chacun étant utile dans le contexte d’une course de natation compétitive.

En fin de compte, la natation s’est énormément améliorée grâce au développement de nouvelles technologies, aux nouvelles techniques créées ou perfectionnées, ainsi qu’aux avantages génétiques comme une grande envergure, de plus grandes mains, une plus grande taille ou une meilleure flexibilité des articulations.`;

    // English text
    let anglais = `<strong style="font-size:20px;">“Swimming is such an unnatural thing for humans — land-based creatures — that I’d say humans in water are still evolving … We’re still learning. We’re still figuring out best practices and best things to do.”</strong> 
- Russell Mark, American Swimming Coaches Association adviser.

As we have covered, swimming is one of the most competitive sports out there. It’s always been a sport about who’s the fastest and which person can break the time record that has been previously set. Swimming is a sport that requires a lot of technique and skills but is still favorable to people who have genetic advantages such as Micheal Phelps and his lactic acid which builds up 50% less than the average Joe which in turn leads him to less fatigue and faster recovery. Swimmers also have technologies which help them break records in the world of swimming such as touchpads, super suits, power towers, tech suits and googles that help swimmers move with less drag, more power and help develop better techniques. Not only that but swimmers also developed better techniques that helped drastically reduce the swimming times such as Freestyle, Breaststroke, Butterfly and Backstroke. Each technique covers a wide array of arm and legs movements, which each makes them useful in the context of a competitive swimming race. In the end swimming has improved a lot because of the development of new technologies, new techniques that were created or improved and with the genetic advantages such as the wide wingspan, bigger hands, taller height and better flexibility in articulations.`;

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
