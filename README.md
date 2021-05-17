# Design Patterns
    
Hi my name is Everton, I from Brasil, and in this project I aim to use all patterns that I find on books and developer community.

## Ducks Generator

This project is a Duck Generator, it only show some ducks on your console, but using the best patterns and pratices of agile development.

## How to make the best use of it

In my country (Brasil), we have a popular saying, called, Cereja do Bolo or in inglish, Icing on the cake
Find in all project "Icing on the cake" and read the comments on the reasons that made me use such strategies.

## Patterns used
- Strategy          - Reference, Head First Book "Design Patterns"
- Factory           - References, Head First Book "Design Patterns" and https://refactoring.guru/pt-br/design-patterns
- Abstract Factory  - References, Head First Book "Design Patterns" and https://refactoring.guru/pt-br/design-patterns
- Command           - Reference, https://refactoring.guru/pt-br/design-patterns/command
- Iterator          - Reference, Head First Book brasilian version 2° Edition

## Steps

**1 Step** 
I Created  ducks classes using interfaces and composition classes reducing coupling and dependence for herance this is strategy

**2 Step** 
I needed a motive for use Factory and Abstracty Factory, so i used a ducks generator for generate a some ducks, after this,
I created too a difference behavior of the ducks by countries, this force me to created a good way for use to same classes,
but with resilience way, with this, i can add more ducks and your diferences behavior whithout so more problems.

**3 Step**
Oh God! Where is the tests! I maked a tests for to test ducks behavior in your different countries.

**4 Step**
I thought a good way to use Command Pattern would be to created some diferences ways of to show duck behaviors on console.
I created a Command interface and ShowCommand Classes with your behaviors, with this I can to use command pattern and to have a resilience way,
to keep many show way.

**5 Step**
For To implement Iterator Pattern, in my project I was already using a list of ducks for show your behaviors on console, now, I run my list using Iterator Pattern
This patterns seems not coused obvious effect, but you can modify your list type, or your source data, and all clients of your object not will afected.


To By Continue!
