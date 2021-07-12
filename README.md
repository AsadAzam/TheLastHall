# Final Project (Unity)
## The Last Hall
The last hall, is a simple 3D game which uses features from nearly all the lectures in Games50. It is an endless game with the aim of reaching the furthest point in the game.

The first block/platform is where the FPS controller is initiallized. We now find the current transform of the initial block. The initial block is a Pipe with 8 sides (dealing with pipes and transforms is a bit tricky). There are 5 diffent types of Prefabs (created).
The prefabs are:
- None -> This is a simple pipe the player can pass through without any hinderance
- Hole -> This pipe has a large hole in between, the user has to jump over it else he will fall and game will be over.
- Axe -> This pipe has a axe swinging around the block, which checks for collision with the player.
- Hammer -> This pipe has a hammer which is rotating in a circle and also checks for collision with the player.
- Saw -> This pipe has a saw attached to it, which moves back and forth and check for collisin with the player.

The prefabs are randomly loaded one after the other so that the game is endless (in the video I render only one block ahead to demonstrate this), as the user keeps on moving forward the previous block keeps on despawning after every 2 seconds. The user scores by the distance he has moved forward.

The game also has fog and a differnt kind of lighting (it makes the game really really hard so not included in the video).