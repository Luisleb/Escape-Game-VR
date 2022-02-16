## Notre escape game n'étant pas totalement fini nous vous conseillons donc pour le tester au mieux de suivre ces conseils:

- *`optionnel`* Aller sur la scène menu qui malheureusement ne charge pas de scène quand on clique sur play.
- Commencer à expérimenter l'escape game sur la scène nommé Chriscene qui contient: 
    1. la première salle fonctionnelle. (`spoil:` un sablier à abaisser afin d'allumer les lumières de la salle ainsi que d'activer les interactions avec les objets et une épée à chercher afin de couper une corde qui déclenche un mécanisme ouvrant la porte de la salle)
    2. le menu de fin(en cas de victoire) que vous pouvez obtenir en activant le gameobject endtrailer pendant le test.
    3. le menu de fin(en cas de défaite) que vous pouvez obtenir en activant le gameobject Lost Canva(enfant de Camera Offset lui-même enfant de XR Origin)  pendant le test.

    ---
    *`les deux parties précédentes ayant été implémentées dans un script gameManager (singleton) qui malheureusement n'est affecté a aucun objet n'ayant pas réussi à fusionner nos deux scènes à temps`*

    *`De plus, ces dernières on un bouton restart qui fonctionnerais si l'on avait pu ajouter dans onClick() la fonction RestartGame() du gameManager.`*

    ---

    4. Un timer est lancé dans le gameManager dés que le sablier est abaissé(ce qui déclenche donc l'escape game). 

- Continuer ensuite sur la scène nommée Luiscene dés que vous êtes sorti de la première salle afin de continuer et de finir l'escape game.
Cette scène contient (*`spoil: ne pas lire si vous voulez explorer par vous même`*):
    1. Un dialogue avec un pnj en haut d'une tour qui lance un mini-jeu
    2. Une fois ce jeu fini, une clef peut être récupérée pour ouvrir le portillon se trouvant en bas.
    3. Une torche peut etre récupérée dans la zone juste avant le portillon, une fois celle ci pick, vous pouvez l'allumer avec la torche accrochée à un poteau trouvable proche de l'eau sur la plateforme en hauteur.
    4. Une fois la torche allumée, vous pouvez la jeter dans le "feu de camp" pour allumer le brasier
    5. Ceci fait, un bateau s'amarre et vous pouvez embarquer pour quitter l'ile.
-----------------

Crédits
-------------
Jeu réalisé par Christopher BILLOT et Luis LEBOULLENGER.

Utilisation du site Mixamo pour récupérer le chevalier.

Utilisation des assets suivantes trouvées sur l'asset store :
- CHRISTOPHER FANTAUZZO, Old Sea Port `(environnement)`
- CAPTAINCATSPARROW, Fantasy interior props free `(mug pour le mini-jeu)`
- ALEKSN09, Rust Key `(clef)`
- 3D.RINA, Sand Clock `(sablier)`
- FEROCIOUS INDUSTRIES, FREE Medieval Props Assets `(cordes et poulies)`
- PURE POLY, Free Low Poly Swords `(épée)`
- SIMPLEMODELSFORME, Old Hand Torch `(torche)`
