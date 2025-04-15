# 🎮 Moving Ball Maze

Projet Unity URP 3D : guide une balle jusqu'à la sortie d’un labyrinthe en inclinant la plateforme sur laquelle elle repose.  
Le projet a été réalisé dans le cadre d’un TP de physique et de contrôle indirect.

---

## 📌 Fonctionnalités

- Contrôle indirect de la balle via la rotation de la plateforme
- Détection de collision avec des pièges
- Respawn automatique de la balle en cas de chute ou de mort
- Détection de la victoire si la balle atteint le point final
- Utilisation de prefabs pour tous les éléments de jeu

---

## 🎮 Contrôles

| Touche | Action                                  |
|--------|-----------------------------------------|
| Flèche du haut        | Incliner vers l’avant    |
| Flèche du bas         | Incliner vers l’arrière  |
| Flèche de droite      | Incliner vers la gauche  |
| Flèche de gauche      | Incliner vers la droite  |

---

## 🛠 Technologies

- Unity - Universal (URP 3D)
- C#
- TextMeshPro pour l’interface
- Input classique

---

## ▶️ Lancer le projet

```bash
git clone https://github.com/Swixos/moving-ball-maze.git
```

- Ouvrir le projet dans Unity Hub

- Lancer la scène Assets/Scenes/MainScene.unity

- Appuyer sur ▶️ dans l’éditeur pour jouer

## 📁 Structure du projet

```bash
Assets/
├── Scenes/               # Contient MainScene.unity
├── Scripts/              # Logique de la balle et de la plateforme
├── Prefabs/              # Ball, plateforme, murs, pièges
├── UI/                   # Interface utilisateur
├── Audio/                # Sons (optionnels)
├── Materials/Textures/   # Apparence des éléments
├── TextMesh Pro/         # Ressources TMP
```
