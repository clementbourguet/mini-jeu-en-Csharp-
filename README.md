# 🧙‍♂️ Jeu de rôle en ligne de commande — C#

Un mini jeu de rôle développé en **C# (.NET) et jouable dans la **console**.  
Le joueur incarne un personnage (Guerrier, Archer ou Sorcier) et affronte des ennemis à travers un système de combat au tour par tour.

---

## 🎯 Objectif du projet

Ce projet a pour but de mettre en pratique :
- La **programmation orientée objet (POO)** en C#
- Les notions d’**héritage**, d’**encapsulation**, et de **polymorphisme**
- L’utilisation de classes abstraites, de méthodes virtuelles et de constructeurs hérités
- La manipulation du **console output** pour créer une expérience textuelle immersive

---

## 🧩 Fonctionnalités principales

- 🧙 Choix du type de personnage : **Guerrier**, **Archer**, ou **Sorcier**
- ⚔️ Système de combat : attaques, dégâts aléatoires, gestion des points de vie
- 💀 Détection de la mort et fin de combat
- 🧠 Système de progression : **niveaux**, **expérience**, et **dégâts évolutifs**
- 🎨 Affichage coloré dans la console (`Console.ForegroundColor`)
- 🔢 Génération aléatoire de noms pour les personnages

---

## 🧱 Structure du projet

JeuRole/
│
├── Program.cs
├── Entite.cs
├── Personnage.cs
├── Guerrier.cs
├── Archer.cs
├── Sorcier.cs
├── GenerateurDeNom.cs
└── README.md

---

## ⚙️ Technologies utilisées

- **Langage :** C#
- **Framework :** .NET 8.0
- **Environnement :** Visual Studio / Visual Studio Code
- **Type de projet :** Console Application

---

## 🚀 Exécution du jeu

### Depuis Visual Studio :
1. Ouvre la solution `.sln`
2. Appuie sur **Ctrl + F5** pour exécuter le jeu sans débogage  
3. Joue directement dans la console 🎮  

### Depuis le terminal :
```bash
cd JeuRole
dotnet run


📈 Améliorations possibles

Ajouter des objets et de l’équipement

Implémenter plusieurs types d’ennemis

Sauvegarder la progression du joueur

Ajouter une interface graphique (WinForms ou WPF)

Gestion du son et de la musique d’ambiance

👨‍💻 Auteur

Développé par Clément Bourguet
🗓️ Projet réalisé en 2025
📬 Contact : clement.bourguet@outlook.fr