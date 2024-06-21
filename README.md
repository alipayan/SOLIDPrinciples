# SOLID Principles Repository

![Solid principles](https://media.dev.to/cdn-cgi/image/width=1280,height=720,fit=cover,gravity=auto,format=auto/https%3A%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Farticles%2Ftq5fahfhe0kdc8muaiyg.png)

Welcome to the **SOLID** Principles repository 🤟 This repository is dedicated to providing examples, explanations, and resources related to the **SOLID** principles of object-oriented design. Whether you are a beginner looking to learn about these principles or an experienced developer seeking to refine your skills, this repository has something for you.

# Table of contents

- [Introduction](#introduction)
- [Principles Overview](#principles-overview)
  - [Single Responsibility Principles](#single-responsibility-principle-)
  - [Open/Close Principle](#openclose-principle-)
  - [Liskov Substitution Principles](#liskov-substitution-principle-)
  - [Interface Segregation Principles](#interface-segregation-principle-)
  - [Dependency Inversion Principles](#dependency-inversion-principle-)
- [Real-World Examples](#real-world-examples)
- [Resources](#resources)
- [Contributing](#contributing)
- [License](#license)

## Introduction
The **SOLID** principles are a set of five design principles intended to make software designs more understandable, flexible, and maintainable. The principles were introduced by [_Robert C. Martin_](https://en.wikipedia.org/wiki/Robert_C._Martin "Robert C. Martin"), also known as Uncle Bob, and have since become a fundamental part of [_object-oriented design_](https://www.educative.io/blog/object-oriented-programming "Object-oriented desing").

## Principles Overview

### [Single Responsibility Principle](SOLID.SingleResponsibilityPrinciple) ![Static Badge](https://img.shields.io/badge/(SRP)-blue?style=flat)

Goal of this principle is that a class should only have one repsonsibility, only single reason to change.
You may think why this principle is improtant? By apply this principle in our code, we can improve the ability of team working and reduce conflices.

### [Open/Close Principle](SOLID.OpenClosedPrinciple) ![Static Badge](https://img.shields.io/badge/(OCP)-blue?style=flat)

A class or method, should be open for extension and close to modification.
That mean, we can always come back and add new functionality, but never change the previous code base.Why this rule is important? When we modify a code base which is stable and test by end users, we take the risk of making new bugs!By help of interfaces and abstract class we can achive to this goal.

### [Liskov Substitution Principle](SOLID.LiskovSubstitutionPrinciple) ![Static Badge](https://img.shields.io/badge/(LSP)-blue?style=flat)

Sub classes should be sustitutable for their base classes without facing to abnormal behavior of thier base classes.

### [Interface Segregation Principle](SOLID.InterfaceSegregationPrinciple) ![Static Badge](https://img.shields.io/badge/(ISP)-blue?style=flat)

In simple word, keep the interfaces seprated.Our classes should not force to implement interface contracts which is irrelevent to them.

### [Dependency Inversion Principle](SOLID.DependencyInversionPrinciple) ![Static Badge](https://img.shields.io/badge/(DIP)-blue?style=flat)

Main reason which DIP introduce is to reduce classes from it's dependencies. Instead, we depend on contracts and abstraction.By applying DIP in our code, our class will focus on his own responsibility.

---

> [!NOTE]
> Remember that, to deeply understad this principles, you should keep reading about them and try to implement them in your code bases.

---

## Real-World Examples

Now, you can go and see the code which I write down at this repo.Every dll is assign to signle principle. There are two class, one of them violate principle and in another one, I write down the code base on the principle.

## Resources

Here are some recomended resources to learn more about solid principles:

[SOLID: The First 5 Principles of Object Oriented Design](https://www.digitalocean.com/community/conceptual-articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design "Solid Article")

[The SOLID Principles of Object-Oriented Programming Explained in Plain English](https://www.freecodecamp.org/news/solid-principles-explained-in-plain-english/ "Solid Article")

[SOLID Principles in Programming: Understand With Real Life Examples](https://www.geeksforgeeks.org/solid-principle-in-programming-understand-with-real-life-examples/ "Solid Article")

## Contributing

I wellcom contributions from the community! If you have another examples or resources to share, please submit a pull request. For major changes, please open an issue first to discuss what you would like to change.

### How to contribute

1. Fork the repository.
2. Create new branch(git checkout -b example/newExample)
3. Make your changes.
4. Commit your changes.(git commit -m "example: your example"
5. Push the branch.(git push origin example/newExample)
6. Open a pull request.

## License

This repository is licensed under the MIT License. See the LICENSE file for more information.

