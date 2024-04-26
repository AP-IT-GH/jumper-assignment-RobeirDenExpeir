"# jumper-assignment-RobeirDenExpeir" 
ML-Jumper Tutorial

1.	Go to Unity Hub and make a new 3D project
2.	Open Package Manager and select Packages: Unity Registry
3.	Search and install ML Agents
4.	Get a 3D object cube and name it road
5.	Make it look like a road
6.	Add a tag road in the inspector screen
7.	 On the left side of the road place another cube, named MLAgent
8.	Add a tag Player in the inspector screen
9.	On the right side of the ride place another cube, named Obstacle and make it into a rectangle
10.	Add a tag ob in the inspector screen
11.	Add some materials to the objects
12.	Add this script to the ML Agent, also a behaviour parameter script will automatically be placed with it
 [MLAgent class](./Tutorial_Images/Afbeelding1.png)
 [MLAgent class](Tutorial_Images/Afbeelding2.png)
 [MLAgent class](Tutorial_Images/Afbeelding3.png)
13.	Add this script to Obstacle
  [MLAgent class](Tutorial_Images/Afbeelding4.png)
14.	Make a prefab from obstacle by dragging it to the Assets folder
15.	Make a Spawner script
  [MLAgent class](Tutorial_Images/Afbeelding5.png)
16.	Place the Spawner script on the Road
17.	In the inspector of Spawner script you need to give a prefab, drag Obstacle in here
18.	Make a empy GameObject named SpawnPoint and place it where the Obstacle needs to be spawning
19.	Give this the tagname spawnpoint
20.	In the inspector of Spawner script you need to give a spawnpoint, drag SpawnPoint in here
21.	Make a empty GameObject named Reset and place it in the exact location of the ML Agent cube
22.	Give this the tagname reset
23.	Make a wall named WallEnd and place it on the left side edge of the Road next to the ML Agent
24.	Give this the tagname wallend
25.	Make a cube above the ML Agent named WallTop
26.	Give this the tagname walltop
27.	Make a wall next to the right side of Obstacle and name it WallReward
28.	Give this the tagname wallreward
29.	Make this a child of Obstacle
30.	Click the box next left to the name to make it invisible
31.	Put WallEnd, SpawnPoint, Reset, WallTop as childs of Road
32.	Put everything except the Obstacle with the child in a empty GameObject named TrainingArea
33.	Make a prefab out of TrainingArea
34.	Add these paramters to ML Agent
[MLAgent class](Tutorial_Images/Afbeelding6.png)
 [MLAgent class](Tutorial_Images/Afbeelding7.png)
35.	Add these paramters to Road
[MLAgent class](Tutorial_Images/Afbeelding8.png)
36.	Add these paramters to Obstacle
[MLAgent class](Tutorial_Images/Afbeelding9.png)
37.	Place the RaySensor so that it looks like this
[MLAgent class](Tutorial_Images/Afbeelding10.png)
38.	Open Anaconda Navigator
39.	Open Terminal for ML-Agents environment
40.	cd to Assets folder of this project
41.	Enter “mlagents-learn” to train the project
42.	Enter “mlagents-learn config/JumperAgent.yaml –run-id=JumperAgent” to train the project and save the results aswell ass being able to see the results under the run-id
43.	Press Play button in Unity
44.	Enter “tensorboard –logdir results” in another terminal to see the graph results on localhost:6006
45.	Go to Assets/results/ppo/JumperPlayer.NN Model and then place this in Inspector MLAgent  Behaviour Paramters in Model
46.	Then we can unview/delete Obstacle with the WallReward child since this is getting spawned
47.	Go to Hierarchy and CTRL+D on the TrainingArea scenario to make copies in parallel for efficiency training
48.	Now you can keep training and testing using the previously mentioned commands

