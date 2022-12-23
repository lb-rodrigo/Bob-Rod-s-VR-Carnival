# Bob & Rod's VR Carnival


### Introduction
- With Bob&Rod’s, our goal is to simulate the experience of a fun-filled carnival in a VR environment. Not everyone has access to a carnival near them so by recreating this experience in VR we hope to make fun and comforting carnival games more accessible. Each booth is inspired by classic carnival games. At Bob&Rod’s the user is able to enjoy Angry Birds, Put a Ring On It!, and Food Fight. Hitting cans, sliding in rings, and taking down dummy enemies, the user is able to rank up in points to test and perfect their carnival skills. 
- What makes Bob&Rod’s so interesting is the immersive experience and out-of-the-ordinary approaches to classic carnival games. At Angry Birds, the user is able to throw chickens at towers of cans to mimic the idea of the worldwide mobile game phenomenon, Angry Birds. At Put a Ring On It! the user is able to practice proposing to their special someone by throwing a ring on greater-than-life-sized fingers. At Food Fight, the user able to live out their high school fantasy of a high school cafeteria food fight by choosing one of many foodie weapons to fight dummy enemies.
- Bob&Rod’s utilization of VR enhances the carnival gameplay tenfold. Set at the bottom of a scenic mountain range, the user is able to be quickly immersed in the life of a carnival. Placed at the center of the three booths, the user is already provided the space to enjoy the world from all angles. With Angry Birds, the user is able to crash the cans with more than just a wiffle ball. With VR, the classic game of can toss can be viewed in a much more enticing and exciting way by throwing live chickens. With Put a Ring On It!, VR allows developers to take a creative spin on the game of ring toss by replacing the poles with fingers. As for Food Fight, the user must defend themselves from dummy enemies from all angles. With this booth, we are able to take advantage of the space that the VR medium grants us by allowing the user to physically move and rotate. 

![INTRO!](Carnaval_VR/Images/intro_1.png)

### Design
`Landscape Design`
- When designing the world of Bob&Rod’s, it was important to us that despite the short timeline to complete the project, we wanted to ensure the user’s experience is up to par with fully scaled and implemented games. We did this by focussing on world-building. Taking advantage of free assets from the Unity Asset store, we kept close to a low-poly aesthetic by utilizing a handful of assets to build a landscape that encapsulated our carnival. Adding numerous trees, mountain ranges, hot air balloons, and a few clouds, the attention to detail was something we prioritized to grab the attention of the user and increase immersion as well as enjoyment.

<img src = "Carnaval_VR/Images/Screenshot 2022-12-04 152021.png" width="400" height="200">

`Carnival Design`
- When approaching the games the first thing we had to consider was booth design. We decided to construct the booths from scratch using unity’s 3D GameObjects in conjunction with free downloaded materials and textures from the Unity Asset Store. When designing the booth, we wanted to ensure that the booth itself had an open and dynamic shape. To execute this vision, we made sure to set the pillars at an angle to showcase depth and movement. We also set the front counter to be lower than the rest of the booth so that the player will be able to pick up objects with ease. 
- Designing the layout of each booth followed a similar formula: title at the bottom, eye-catching figures showcasing the game’s theme on top, an array of interactive GameObjects in the front, collision GameObjects in the middle, and game instructions and a scoreboard at the back wall.
- Lastly, we wanted to ensure that the user feels as if they are in for an experience. The second the user presses play, they are greeted with a welcome sign with a star rotating behind it. In addition, the player is also greeted by fun upbeat music we downloaded for fair use from Pixabay called positive-cartoon-loop.

`Control Design`
- Using the Oculus Touch controllers allows users to be completely immersed into the world of Bob&Rod’s. With the Touch controllers, users are able to physically grab rings/chickens/weapons and use them in a way that mimics real life. In addition, by choosing to use the Touch controllers, decreases remapping motor programs in VR. If we were to use a keyboard or a mouse we lose the natural and intuitive, gesture-driven interactions that make VR so immersive. 
- When it comes to mapping controls to actions in the virtual world, the user is able to utilize the Touch controllers just as much as the VR Headset. To traverse through the world, the user is able to move with the left joystick. To rotate the user has two options: to physically move their body or to use the right joystick to look in a certain direction. To grab we attached hands to the user’s controller to simulate the grabbing motion.
- In the effort to replicate the experience of classical carnival games in virtual reality, our game design conformed and broke some VR developer tips. A tip that we made sure to conform to was touching as it relates to selection methodologies. We opted for having objects within local reach meaning that the layout of their colliders accurately conforms to the dimensions of each object. Therefore when a player reaches to grab an object they could only do so within the dimensions of such an object. In addition, we also decided to have naturally mapped hands to not create a sense of discomfort to the users. 
- When implementing movement into our experience we decided to use smooth locomotion. Smooth locomotion is achieved by having the user move using their left and right joystick. Although this type of movement can cause motion sickness for some users, the low-poly game design compensates for this by allowing for optimal frame rate rendering which mitigates motion sickness in users. 



### Implementation 
- In order to differentiate between colliders we used tags to label GameObjects. Tags allowed us to reference GameObjects for player-controlled actions and reference “target” GameObjects for gameplay-logic interactions. Doing this ensured that only collisions with target-tagged objects illicit an increment in the scoreboard on the game booth.
- The implementation of each carnival game at Bob&Rod’s is centered around the relationship between two scripts (_Game.cs and _Trigger.cs) and objects with a ‘target’ tag. Each interactive object inside our booths included a rigid body and a box collider.
- At Angry Birds, the goal of the game is to destroy can towers with a throw of a chicken. Setting up the game, we utilized free assets from the Unity Asset Store to construct three can towers that were set on top of stacked crates. Each can tower is encapsulated within an empty parent labeled ‘Tower1’, ‘Tower2’, and ‘Tower3’ that were all children to an overhead parent called ‘Towers’. For this booth, there exist two scripts that took care of scoring: ChickenGame.cs and ChickenTrigger.cs. ChickenGame.cs is used to update the current game score on the scoreboard. As for ChickenTrigger.cs, it uses OnTriggerEnter() to check if its attached colliders come into contact with a “target” tagged object. The overhead parent object, ‘Towers’, has ChickenGame.cs as a component whereas each of the cans has ChickenTrigger.cs. To score points, the cans, which had rigid bodies and mesh colliders, has to touch the floor of the booth. With this, we set the floor tag to be ‘target’.
- A Put a Ring On It!, the goal of the game is to successfully throw a ring onto a finger. Setting up the game, we downloaded hands from the Unity Asset Store and constructed our own rings using organic 3D GameObjects. Some encountered issues that we were able to overcome with this game revolved around the hands and rings themselves. The imported hands did not come with any sort of internal skeleton that allowed us to throw rings on. As a result, we decided to construct Invisible Hands which were made up of cylinders with a transparent material to act as its skeleton. To detect if the ring had successfully been thrown upon a finger, we inserted a sphere collider within each finger. As for the rings, before making them ourselves, we initially wanted to download a ring from the Unity Asset Store. However, with each imported asset, the ring itself could not be penetrated through its center. With this, we constructed square rings made up of four 3D rectangular prisms and attached two box colliders on two sides. This allowed users to grab rings as well as toss them successfully onto a finger.
- To keep score at Put a Ring On It!, there exist two scripts: FingerGame.cs and FingerTrigger.cs. Similar to the scripts of Angry Brids, FingerGame.cs is used to update the current score on the scoreboard and FingerTrigger.cs uses OnTriggerEnter() to check if its attached colliders come into contact with a “target” tagged object. FingerGame.cs is attached to the parent of both Invisible Hands and FingerTrigger.cs is attached to each of the empty GameObjects that hold each sphere collider within each finger. To score points, target tagged objects (rings) must collide with the sphere collider placed inside the finger.
- At Food Fight, the goal of the game is to survive a wave of dummy enemies using foodie weapons. Setting up the game, we imported free assets from the Unity Asset Store including sparring dummys and a variety of food objects. For Food Fight, we wanted the user to endure a 360-degree experience. With this in mind, the user is able to enter the booth and stand in the center of randomly spawning dummys.
- For this booth, there are scripts that take care of the random spawning and scoring: KnightGame.cs and KnightTrigger.cs. KnightGame.cs, which is attached to the parent of the dummy knights, has a countdown variable alongside a Random.range(0,3) function call that selects a knight at a random location to be spawned in the environment every three seconds. Depending on the output of Random.range(0,3), we call .SetActive() on each dummy knight and set the randomly generated index to be true and the rest false. This .SetActive() call determines their appearance in the durationof the game. In addition, KnightGame.cs keeps track of the score and outputs it to the scoreboard.
- The script KnightTrigger.cs takes care of checking if any of the knight dummies were hit with a target tagged GameObject. If a collision is detected, the script will increase the score count by one and called transform.eulerAngles() to rotate the dummy into a laying position to mimic the “death” of the dummy.
- Lastly, a feature we wanted to implement is to have the knights only begin to be randomly spawn once the user is inside the booth. If the user were to step out, all of the knights will be shown. This is done with a script called EntrancePoint.cs which uses OnTriggerExit() and a public boolean variable called ‘enter’. By setting a box collider at the entrance of Food Fight, it searches for a ‘walk’ tagged object, which is the OVRCameraRig. If this were to be triggered, EntrancePoint.cs flips this boolean value which KnightGame.cs is able to access. In KnightGame.cs, if ‘enter’ were set to false, .SetActive() would be called upon each of the knights and being set to true. However, if ‘enter’ was set to true, the game would begin.
