### FAUNA

#### The final group task in part 7 of the Software Development course, made by Team4u.
Our goal was to make a *menagerie program* for our *customer*, where the user can visit, watch and interract with different kind of animals.   

The project was completed by delegating different parts for our team members with the help of Trello (Kanban) to keep track of what has to still be done. For communication, we used Slack, WhatsApp and Discord voice & screen sharing. All implementation was done in Visual Studio Code. The class diagram was created in yuml.me. The sequence diagram was created in draw.io.    

For more specific details about the program's functionality, please check out the class and sequence diagrams below.   

[Trello link](https://trello.com/b/AGGB9EzQ/team4you)

Here is our **sequence diagram**:
(It is behind a link, since the picture is so huge)
[Sequence Diagram Link](https://raw.githubusercontent.com/TuukkaUllakko/NEWT4U/master/assets/Sequence%20Diagram%20FaunaProject.png)

Our sequence diagram became really long because of the way we coded our program. However, the program works like it should, and the sequence diagram does show exactly what the program does. In the diagram, *main* first calls the *user interface*, and starts it. The rest of the program is run in the user interface. Since the program is based on the user's input, there are loops that "force" the user to always pick a valid option.

As the sequence diagram goes lower, there are different animals that the user can choose. Each animal has its own loop, inside the big loop running the whole program, except the beginning greetings. Each animal has access to the methods dedicated to that animal type and individual animal. These methods are called with different user inputs. If statements determine which method to use with each unique input.

The user can break the infinite animal loop with a certain input, and this loop break will take the user back to the animal selection part of the program, where the user can either break that loop with 0, which will end the program, or choose another animal.

**Class diagram** can be found in the assets. The Fauna-project has an abstract class called _Animals_ with the methods MakeSound() and Eat() and weight property. There are two interfaces, one for the _ITame_ and the other for _IWild_ animals. The classes inheriting ITame are _Bird, Cat, Dog, Pig and Rat_. ITame contains public methods TalkToOwner():string, ComeHere():string and GiveName():string and also a name property. The interface IWild has the method Hunt():string and is inherited by _Tiger, Wolf and Bear_ -classes. There is also a _user interface UI_ with the method Start() that is associated with _both the IWild and ITame interfaces_ and also the _abstract Animal class_. 

https://yuml.me/5e68852b.jpg


 Here is the **folder structure**
```
├── README.md
├── assets
│     ├── class_diagram_with_connections.png
│     └── sequence_diagram.png
├── src
│    └── Fauna
│	        ├── Animals
│           │       ├── Animal.cs
│           │       ├── UI.cs
│           │       ├── Tame
│           │       │    ├── ITame.cs
│           │       │    ├── Cat.cs
│           │       │    ├── Bird.cs
│           │       │    ├── Dog.cs
│           │       │    ├── Pig.cs
│           │       │    └── Rat.cs
│           │       │
│           │       └── Wild
│           │            ├── IWild.cs
│           │		     ├── Wolf.cs
│           │		     ├── Bear.cs
│           │		     └── Tiger.cs
│           │
│           ├── FaunaProject.csproj
│           └── Program.cs
└── test
    └── FaunaTests
          ├── FaunaTest.cs
          └── FaunaTest.csproj
```