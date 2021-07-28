# Final Project (Unity)
## The Last Hall
### Introduction
The last hall, is a simple 3D game which uses features from nearly all the lectures in Games50. It is an endless game with the aim of reaching the furthest point in the game.

The first block/platform is where the FPS controller is initialized. We now find the current transform of the initial block. The initial block is a Pipe with 8 sides (dealing with pipes and transforms is a bit tricky). There are 5 different types of Prefabs (created).

The prefabs are:
- None -> This is a simple pipe the player can pass through without any hinderance
- Hole -> This pipe has a large hole in between, the user has to jump over it else he will fall and game will be over.
- Axe -> This pipe has a axe swinging around the block, which checks for collision with the player.
- Hammer -> This pipe has a hammer which is rotating in a circle and also checks for collision with the player.
- Saw -> This pipe has a saw attached to it, which moves back and forth and check for collision with the player.

The prefabs are randomly loaded one after the other so that the game is endless (in the video I render only one block ahead to demonstrate this), as the user keeps on moving forward the previous block keeps on de-spawning after every 2 seconds. The user scores by the distance he has moved forward.

The game also has fog and a different kind of lighting (it makes the game really hard so not included in the video).

----
### Prefab(s) Breakdown
There are a few different types of prefabs which I have used in the project, including two imported directly from libraries. <br>
Prefabs:
1. Imported from Library:
    1. **FPSControllerNew** -> This prefab has been imported from StarterAssets Package. It is a new FPS Controller which doesn't use the legacy input mode of unity, but the new Input System. It has better animations for the walking and running and feels a lot more realistic than the FPSController in the Standard Assets Package.
    2. **Axe, Hammer, Saw** -> These three prefabs have been directly imported from the DungeonTraps Package. Mostly I have used the standard animations that came with the package but I had to tweak the animation of Axe so that the user can cross it.
2. Created (using ProBuilder) :
    1. **BasePipe** : BasePipe is a simple 8 directional pipe which serves as the starting point from the game. The pipe has some irregularities in the floor as well as the walls so that it feels more like walking over floor than a perfectly straight line. The base pipe also serves as a reference for the other blocks to be laid after it. The pipe is closed from one end making sure that the user is unable to move behind the pipe and fall down.
    2. **GreatAxe** : It uses the same pipe structure from the BasePipe but rather it is open from both ends so that the user can continue walking forward. The pipe has an axe hanging from the top which is continuously swinging from side to side. The hitbox is near exactly the shape of the prefab and on collision with any object checks if it collided with the user or the wall.
    3. **Hammer** : It also uses the same pipe structure from the BasePipe and has a hammer hanging in between it, the hammer keeps on rotating in a circle and the hitbox is of the shape of a rectangle (the hammer head).
    4. **Saw** : It has a saw blade which is placed on the ground and performs to and fro animation continuously. The hitbox for this is the near exact shape of the saw blade.
    5. **Hole** : It is a simple pipe which a few tiles in it with inverted normals making an appearance of hole. The user can fall through the hole, it has no other hurdles in it.
    6. **None** : It is the simplest pipe which doesn't have any hurdles in it.

----
### Scene(s) Breakdown
There are three scenes in the game representing the three states a user can be.
1. **TitleScene** : This scene simply displays the name for our project and serves as the introduction scene for the game. It uses TextMeshPro.
2. **BaseScene** : This is the main scene which is transitioned just after the user exits the TitleScene. 
    1. It immediately starts the game placing the BasePipe and the FPSControllerNew on the scene.
    2. Procedurally generating a random block after the BasePipe. The pipes after the BasePipe are completely random and spawn in the same line.
    3. As the user exits a pipe that pipe is destroyed after two seconds.
    4. The Scene doesn't have any illumination and is dependent on the global illumination. Also the game has a very dense fog which makes it hard for the user to see the traps from far behind and prepare accordingly. 
    5. As the user keeps on moving forward he scores as the ammount of distance he moves forward, there is a check so that if the user turns behind the score doesn't start decreasing.
    6. The user can fail the level by either falling behind the pipe he is currently in, or falling in a hole, also he will fail by hitting either of the Axe, Hammer or Saw.
3. **GameOverScene** : This scene is triggered if the user fails anyhow. It will display the final score and the game ends.

----
### Script(s) Breakdown
The full game has 6 scripts:
1. **BaseTile** : This scripts finds the generated pipes in the game world and it the user enters a pipe then spawns a new random pipe ahead and destroys the current pipe after 2 seconds.
2. **CheckCollision** : This script just keeps on checking if the user has hit the Axe, Hammer or the Saw.
3. **LoadSceneOnInput** : This keeps a static integer score so that it resets every time the user restarts the game. Also it controls the current scene to be displayed.
4. **MapGenerator** : This is the main script which keeps track of the position of the current block and then starts spawning further blocks from the position's reference. Also this keeps on updating the current score of the user.
5. **MaxScore** : This checks the maximum score of the user and displays it in the GameOverScene.
6. **Score** : Finds the current position of the user camera and finds its position in the x-axis. The score is determined by the current position in the x-axis. Also it check if the user has fallen down below a certain point in the game world.

----
### Complexity and Uniqueness
The project is fairly complex with the procedural generation of the blocks being the most complex part of the project.
The project is unique as it feels like a game like temple run but with the flexibility of moving at one's own speed and meanwhile not knowing what is further ahead (due to the fog in the game too).
