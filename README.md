# Shapes
Dans le cadre de la soumission "Programming theory in action" du parcours de formation Unity "Junior Programmer" (POO illustration).

Le projet implémente les 4 piliers de la POO : **héritage**, **polymorphisme**, **encapsulation** et **abstraction**.
* Il y a 3 types de formes géométriques colorées héritant d'une classe de base Shape (héritage).
* Le script GameManager génère régulièrement ces formes aléatoires : carré, rectange, cercle.
* Quand on clique sur une forme, la barre d'information affiche la surface de la forme (polymorphisme). Chaque forme dispose de la possibilité de surcharger la méthode Surface () et le texte d'information (ainsi un carré affiche *côté* et un cercle affiche *rayon*).
* Chaque forme contient des données (nom, paramètres) stockées comme propriétés avec getter et setter (encapsulation).
* Le code est organisé de manière à réduire la duplication de code (abstraction). Par exemple le carré utilise la même méthode UpdateText () que la classe de base.
