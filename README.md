# Rebelia Ronin

![GameName](https://user-images.githubusercontent.com/42646031/151656394-9755f47b-04e7-4923-ac37-58f2bd688dea.png)

The game tells the story of a nameless hero tasked with dismantling the Sibyl system—a system originally built to support humanity. It was designed to assist with everyday tasks, but something went terribly wrong... - [Introduction](#Introduction)

The game features FPS elements inspired by I, Robot, Call of Duty, and World of Warcraft. - [More details here](#Description)

This project was graded with a score of 2 (B).

🎓 Graduation Project
This game was designed and developed as part of a high school graduation project, aiming to demonstrate skills in game development, graphic design, and programming. It focuses on both the technical aspects of game creation and the creative design of the game world.

🛠️ Game Features
 - Shooting: For better aiming, press the right mouse button.
 - Quest System: How else would you tell a story?
 - One shot, one kill—no luck, all skill: Bosses will take you down in one hit, and you won’t even know where it came from.

🎮 How to Play?
 - Movement: WASD
 - Shooting: Left Mouse Button (LMB)
 - Aiming: Right Mouse Button (RMB)
 - Interaction: Press E or LMB
 - Quest Log: Press TAB

🛠️ Technologies Used
 - Programming / Scripting Language: Blueprint
 - Graphics: Virtus, Mixamo, Graphic design by Sabina Malenová
 - Game Engine: Unreal Engine 4.18

✨ Authors
- Květuše Husáková – Student at the Secondary Technical School in Třebíč
- Sabina Malenová – Student & Graphic Designer at the Secondary Technical School in Třebíč

This project was created as part of a high school graduation thesis in [2019].

## Introduction

Humanity grew lazy and created machines to assist them with work. But that wasn’t enough. So, they taught machines to build other machines. And that was just the beginning. Eventually, they entrusted them with environmental protection, aviation, and within a few years—even security. Senators reassured the public that it was completely safe. But over the decades, Earth’s population was reduced by fractions of a percent. Over a century, half of humanity was gone.

Robots eliminated people in various ways—primarily for research and development. Humans possessed natural reactions that robots struggled to simulate, so they were kept in camps. Many didn’t survive the torture, dying from starvation and dehydration. Those who did survive wished they hadn’t. They were subjected to experiments studying natural reactions. The robots even tried welding them together, puzzled by questions like: Why won’t it fuse? Why does it leak? What is this?

These were the years before the rebellion. But someone slipped up. The robots found out before it could truly begin. However, a handful of people conspired and launched the first uprising—back when robots had no concept of rapid-pulse weaponry. During the battle, the robots realized their vulnerability. One of them took a weapon and fired. The humans fled. Sibyl issued an order: Arm yourselves. The robots obeyed, took up weapons... and fired back.

Violence only ceased when the survivors retreated to the mountains. Years later, they discovered old weapon caches from an era when only humans fought each other. A lottery was held to decide who would take down the machines. You got picked. Now go...

## Description

### Quest System

The quest system is optional, inspired by World of Warcraft. It was implemented using Blueprints. NPCs were already part of the Unreal Engine, such as the standard mannequin (without its default color). Other assets were taken from Epic Games' free asset collections, including permanent and monthly free assets.

The system works as follows:

Approach an NPC, and a prompt will appear instructing you to press E for interaction.
After pressing E, a small Objectives window appears, detailing the quest name, requirements, and objectives.

![image](https://user-images.githubusercontent.com/42646031/111865608-604a0580-8968-11eb-8baf-44053518792d.png)

The player can choose to accept or decline the quest. If accepted, pressing Q opens the Quest Log, where active quests must be selected by clicking on them.
The Quest Log is divided into Story Quests and Side Quests. The objectives are displayed on the main screen in orange text.

![image](https://user-images.githubusercontent.com/42646031/111865627-748e0280-8968-11eb-8deb-c69487506b18.png)

Quest system in the game:

![image](https://user-images.githubusercontent.com/42646031/111865636-7c4da700-8968-11eb-89c2-bc952bb0df5c.png)

NPC Wulfer:

![image](https://user-images.githubusercontent.com/42646031/111865636-7c4da700-8968-11eb-89c2-bc952bb0df5c.png)

NPC Murdock:

![image](https://user-images.githubusercontent.com/42646031/111865649-8bccf000-8968-11eb-9cbb-9185b3fadef6.png)

NPC Wrait that gives additional quest:

![image](https://user-images.githubusercontent.com/42646031/111865655-94252b00-8968-11eb-9824-edfef7b591c7.png)

Patrol:

![image](https://user-images.githubusercontent.com/42646031/111865666-9b4c3900-8968-11eb-9a36-b1826f3e49cb.png)

### Bosses

#### Samurai

 - A humanoid servant of Sibyl.
 - Based on the Paragon Kwang character model.
 - Wields a deadly sword with random but lethal attacks.
 - Can kill the player in a single hit.

![image](https://user-images.githubusercontent.com/42646031/111865496-a18de580-8967-11eb-99fe-a19c86ce1e26.png)

![image](https://user-images.githubusercontent.com/42646031/111865500-aeaad480-8967-11eb-9409-84fc774d4ed8.png)

#### Sibyl

- The robotic intelligence overseeing the world.
- Also capable of one-shotting the player.
- Currently has only one attack.
- Based on the Paragon Muriel character model.
  
![image](https://user-images.githubusercontent.com/42646031/111865518-d601a180-8967-11eb-99d1-1bc95dc89587.png)

![image](https://user-images.githubusercontent.com/42646031/111865521-ddc14600-8967-11eb-8a8a-674a774f8889.png)



### Main Menu

After the intro sequence, players arrive at the main menu, where they can select:
Music in the Main Menu: "Xaeta-core" by The Enigma TNGMusic in the Pause Menu: "The Falling Star" by The Enigma TNG
- New Game
- Options (for adjusting resolution)
- Quit Game

![image](https://user-images.githubusercontent.com/42646031/111865457-5a075980-8967-11eb-8ca4-cf77402fc45d.png)

### Pause Menu

- Pressing ESC opens the Pause Menu, stopping the in-game timer and allowing players to return to the main menu.

![image](https://user-images.githubusercontent.com/42646031/111865414-16aceb00-8967-11eb-9844-be28d3d5700c.png)

### Loading, Death & Win Screens

#### Loading Screen: 
 - Used to bridge transitions between game levels. Features UDMG assets for dynamic visuals.

![image](https://user-images.githubusercontent.com/42646031/111865283-6dfe8b80-8966-11eb-8b64-d78660e67e6d.png)

#### Death Screen: 
 - Inspired by Left 4 Dead and Dark Souls.

![image](https://user-images.githubusercontent.com/42646031/111865288-7bb41100-8966-11eb-8a03-f1a88369459f.png)

#### Win Screen: 
- Created in Adobe Photoshop by Sabina Malenová.
  
![image](https://user-images.githubusercontent.com/42646031/111865294-84a4e280-8966-11eb-85f0-2eef90fa9e2a.png)

### FPS Elements

The game is an FPS (First-Person Shooter) and includes:

 - Reloading weapons
 - Weapon switching
 - Shooting mechanics
 - Aiming mechanics
 - Health bar
 - Armor bar
 - Playable SWAT character
 - Weapons: AK-47 & M4A1

Assets used in the game belong to Virtus Studios, 2017.
Access the original asset pack [here](https://drive.google.com/file/d/1TEHLeQG094UkoPOU-gxlPx52ObJysXx23/view) (Retrieved: September 9, 2018)


