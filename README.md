# SpaceShipsYonatan

## Description
For this part I chose to change level 1 to be a cyclic world from left to right and vice versa, with the top and bottom walls being solid – for ease of use I also removed the portal to the next level and the game won’t end when a player collides with the enemy. </br>
This is accomplished by allowing the player to move a bit off screen at which point he reaches a trigger which teleports him symmetrically to the left or right  of the other trigger area (it does so accordingly) – this is a simple illusion used in many games! </br></br>
As for the original change – I added a ‘Mothership’ enemy prefab which is a larger and slower enemy, those spawn 2 enemy ‘saucers’ above them after death, a ‘Matryoshka’ enemy like in chicken invaders. </br>
This is accomplished by using the onDelete() monobehaviour using an Instantiation call for X game components (prefabs) decalred beforehand in the editor (in this case the flying saucer) - onDelete() may be bad practice for instantiating as i got an error when closing my game, but there are ways to handle this or use onDisable() instead!

## Highlights
1. The wall setup (4 colliders) </br>
   ![image](https://github.com/HolyTrie/SpaceShipsYonatan/assets/73063105/7c81241e-c8a5-4aea-86e7-0b7685404d10)
2. Teleport Collider script </br>
  ![image](https://github.com/HolyTrie/SpaceShipsYonatan/assets/73063105/482d2111-aca1-4fb5-8d29-f5b9c37a25dd) </br>
  ![image](https://github.com/HolyTrie/SpaceShipsYonatan/assets/73063105/29cb837c-7a66-41ce-9ddd-a91761e9869c)



