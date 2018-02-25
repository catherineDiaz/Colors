# colors
1. **1)**What is your project?
  1. **a)**_The project is going to be a story game created in Unity_
  2. **b)**_The story will be that all the color in the Universe is gone and it&#39;s hidden and we need to get it back.  The format is similar to a mario game, in that he has a home land and he goes to different lands and does tasks or plays mini games._
  3. **c)**_The following are the universe themes:_
    1. **i)**_Paint_
    2. **ii)**_Ink_
    3. **iii)**_Colored Pencil_
  4. **d)**_There will be a character and this character&#39;s goal is to go to each of the universes and complete the task of the universe which results in a token that will be taken back to the home land.  The game is complete when the character completes the tasks of all universes._
  5. **e)**_In addition to the universes, the character will have special powers that it can collect during its travels and these powers will be stored in a &quot;box of powers&quot;.  Each power will give the character unique abilities that apply to the different universes._
  6. **f)**_I will use the singleton design pattern for my character object_
  7. **g)**_The following are the powers:_
    1. **i)**_X ray vision_
      1. **(1)**_ for when the character is going through a maze_
    2. **ii)**_Super Jump_
      1. **(1)**_ change the physics of the character to make it jump or bounce higher_
    3. **iii)**_Change to ball_
      1. **(1)**_have the character transform to a ball when going through a roller coaster like environment_
  8. **h)**_The following are the possible tasks of the different universes:_
    1. **i)**_Look for stuff game, hidden objects_
    2. **ii)**_Obstacle course, roller coaster_
    3. **iii)**_Going Through Maze, collecting objects_
2. **2)**What technologies are you planning on using? (Programming languages, libraries, etc. Be as comprehensive as possible. Rate each technology on a scale from &quot;not familiar&quot; to &quot;completely familiar&quot;)
  1. **a)**Unity - completely familiar
    1. **i)**Unity is a game engine used for creating applications with 3D objects.  It works by adding 3D objects into a scene and then code is used to create objects
  2. **b)**C# - familiar
    1. **i)**Language used in unity
  3. **c)**Maya - familiar
    1. **i)**Needed to create the 3D objects and the universes
  4. **d)**Photoshop - completely familiar
    1. **i)**Needed for creating textures and modifying the appearances of 3D objects
3. **3)**What are the essential parts of the project (complete the sentence &quot;My project won&#39;t work if it doesn&#39;t have \_\_\_\_\_\_\_\_\_\_&quot; as many times as necessary). Why are these essential and do you have a backup plan if they don&#39;t work?
  1. **a)**My project won&#39;t work if it doesn&#39;t have 3D objects.  These are essential because these are what the code is attached to.  This is going to be a very art heavy game.
4. **4)**Resources
  1. **a)**What outside resources do you require?
    1. **i)**The only resources I require are Unity, Maya, and Photoshop, which I already have
  2. **b)**Where will the outside resources come from?
    1. **i)**Unity
      1. **(1)**Comes from [https://unity3d.com/get-unity/download](https://unity3d.com/get-unity/download), I have the personal edition already downloaded
    2. **ii)**Maya
      1. **(1)**Comes from my student license, [https://www.autodesk.com/education/free-software/maya](https://www.autodesk.com/education/free-software/maya)
    3. **iii)**Photoshop
      1. **(1)**I have a creative cloud account because I use the adobe creative suite very often for other projects, [https://www.adobe.com/creativecloud.html](https://www.adobe.com/creativecloud.html)
  3. **c)**Have you already located them and know that you have access to them?
    1. **i)**Yes
5. **5)**Make a proposal for your architecture.
  1. **a)**If you will have a front end and a back end, how will they interact, what will your database be?
    1. **i)**I will have a front end and a back end.  The front end will consist of the visual elements of the games including all the 3D objects that will make up the universes and menus to control the character.  The front end will be created through the backend with C# scripts to place everything, apply the physics, and apply the materials to the objects as well as storing all location data.  The backend is where all data associated with the positioning of elements, and methods for checking if the character has collided with a power, and constant positional updates for the character.
  2. **b)**What will your data model be?
    1. **i)**The data model will be an organized hierarchy for the universes created and separate objects for the player and powers
  3. **c)**How will your front end work?
    1. **i)**The front end will take in the arrow keys, mouse and the space bar as input to move the character and control the game.  It will function like any regular PC game.
  4. **d)**How will you deal with your user interface?
    1. **i)**The interface is the game, and will have certain button and menus for bringing up for example the &quot;box of powers&quot;
  5. **e)**How will it communicate?
    1. **i)**All of the objects will be connected, for example, if the player touches a power then the power gets added to a vector in the character object.  The Universe objects will have a list of the locations of the powers within the Universes
  6. **f)**What classes/objects do you plan on having?
    1. **i)**I plan on having a **Universe** object that will be the base class for all the universes
    2. **ii)**There will also be 3 different classes that inherit from the Universe object, they will be named after the theme of the universe, i.e. **Paint, Ink, or Colored\_Pencil** will be a children of the **Universe** class
    3. **iii)**There will be a **Character** object, which will store all of the objects the character collects as well as contain all of the physics associated with the character
    4. **iv)**There will be a **Power** object, which will contain the special attributes of each different power that will be applied to the character
    5. **v)**Last, there will be a **Token** object which is going to contain the methods to change the home environment once it is collected
  7. **g)**What is each in charge of and how will they interact?
    1. **i)****Universe** Object contains:
      1. **(1)**Vector of 3D objects in the universe
      2. **(2)**Physics associated with the universe
      3. **(3)**Vector of base materials used
      4. **(4)**Positions of all objects
      5. **(5)**Create Universe
        1. **(a)**Position in world
    2. **ii)****Paint, Ink, Colored\_Pencil : Universe**
      1. **(1)**Vector of 3D objects in the universe
      2. **(2)**Physics associated with the universe
      3. **(3)**Vector of materials used
      4. **(4)**Create Universe methods
        1. **(a)**Method to place objects
        2. **(b)**Method to apply physics to objects
        3. **(c)**Method to time animation of objects
        4. **(d)**Method to apply materials to objects
    3. **iii)****Character**
      1. **(1)**Will be a **singleton**
      2. **(2)**3D object representation of character
      3. **(3)**Vector of **Powers** collected
      4. **(4)**Character attributes
        1. **(a)**Color
        2. **(b)**Size
        3. **(c)**Physics
        4. **(d)**Current Position
      5. **(5)**Method for input movements and how it translates to the character
    4. **iv)****Power**
      1. **(1)****Factory design pattern**
      2. **(2)**3D object representation of the power
      3. **(3)**What the power does
      4. **(4)**Method to put it into box of powers
    5. **v)****Token**
      1. **(1)****Flight weight**
      2. **(2)**3D object representation of token
      3. **(3)**Vector of position in world
      4. **(4)**Method for if the character touched the token
      5. **(5)**Animations associated with token
  8. **h)**How will the different technologies that you are planning on using work together?
    1. **i)**Maya will be used to create the complicated 3D objects, Photoshop will be used to create the art and textures of the 3D objects, and I will store all 3D objects in Unity, and C# will put everything together.
6. **6)**Detailed plan.
  1. **a)**What do you plan to accomplish each week between February 19th and May 2nd?
    1. **i)**Feb 19th - 23rd
      1. **(1)**Start Character object
      2. **(2)**Complete Rough 3D models for the home land
    2. **ii)**Feb 26th - Mar 2nd
      1. **(1)**Finish Character Object
    3. **iii)**Mar 5th - 9th
      1. **(1)**Complete Power Object
      2. **(2)**Complete Token Object
    4. **iv)**Mar 12th- 16th
      1. **(1)**Start writing 1st universe
    5. **v)**Mar 19th- 23rd
      1. **(1)**Finish 1st universe
    6. **vi)**Mar 26th- 30th
      1. **(1)**Start second universe class
    7. **vii)**Apr 2nd - 6th
      1. **(1)**Finish the 2nd universe class
    8. **viii)**Apr 9th - 13th
      1. **(1)**Start the last universe class
    9. **ix)**Apr 16th - 20th
      1. **(1)**Finish the last universe class
    10. **x)**Apr 23rd - 27th
      1. **(1)**Write test cases
    11. **xi)**Apr 30th-  May 2nd
      1. **(1)**Run through test cases
  2. **b)**What will you turn in for each class due date?
    1. **i)**HW 3 - Feb 28th
      1. **(1)**The character class will be finished
      2. **(2)**The character will be able to move around and collect stuff if it runs into something
      3. **(3)**There will also be a very rough representation of the homeland that the character will walk on and explore
  3. **c)**What knowledge do you think that you will need to accomplish the goals for the week?
    1. **i)**Syntax of writing classes and objects in C#
  4. **d)**Of that knowledge, what will you need to learn?
    1. **i)**Syntax of writing classes and objects in C#
