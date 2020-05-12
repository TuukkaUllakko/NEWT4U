### FAUNA

##### The final group task in part 7 of the Software Development course, made by Team4u.

[Trello link](https://trello.com/b/AGGB9EzQ/team4you)

Here is our **sequence diagram**:
(It is behind a link, since the picture is so huge)
[Sequence Diagram Link](https://raw.githubusercontent.com/TuukkaUllakko/NEWT4U/master/assets/Sequence%20Diagram%20FaunaProject.png)

Our sequence diagram became really long because of the way we coded our program. However, the program works like it should, and the sequence diagram does show exactly what the program does. In the diagram, *main* first calls the *user interface*, and starts it. The rest of the program is run in the user interface. Since the program is based on the user's input, there are loops that "force" the user to always pick a valid option.

As the sequence diagram goes lower, there are different animals that the user can choose. Each animal has its own loop, inside the big loop running the whole program, except the beginning greetings. Each animal has access to the methods dedicated to that animal type and individual animal. These methods are called with different user inputs. If statements determine which method to use with each unique input.

The user can break the infinite animal loop with a certain input, and this loop break will take the user back to the animal selection part of the program, where the user can either break that loop with 0, which will end the program, or choose another animal.


 Here is **folderstructure**
```
├── README.md
├── assets
│     ├── class_diagram_with_connections.png
│     └── sequence_diagram.png
├── src
│    └── FaunaProject
│	        ├── TextInterface.cs
│           │
│	        └── Animals
│                 │       ├── Animal.cs
│                 │       ├── Tame
│                 │       │    ├── Cat.cs
│                 │       │    ├── Bird.cs
│                 │       │    ├── Dog.cs
│                 │       │    ├── Pig.cs
│                 │       │    └── Rat.cs
│                 │       │
│                 │       └── Wild
│                 │		        ├── Wolf.cs
│                 │		        ├── Bear.cs
│                 │		        └── Tiger.cs
│                 │
│                 ├── FaunaProject.csproj
│                 └── Program.cs
└── test
    └── FaunaProjecttests
          ├── FaunaProjectTest.cs
          └── FaunaProjectTest.csproj
```