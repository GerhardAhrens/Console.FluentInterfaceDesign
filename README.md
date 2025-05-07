# Fluent Interface Design

![NET](https://img.shields.io/badge/NET-8.0-green.svg)
![License](https://img.shields.io/badge/License-MIT-blue.svg)
![VS2022](https://img.shields.io/badge/Visual%20Studio-2022-white.svg)
![Version](https://img.shields.io/badge/Version-1.0.2025.0-yellow.svg)]

Das Fluent Interface Design Pattern in C# ist eine Methode für den Entwurf objektorientierter APIs, die einen besser lesbaren und leicht zu wartenden Code ermöglicht. Es basiert auf dem Konzept der Methodenverkettung, bei der jede Methode selbst ein Objekt zurückgibt, so dass mehrere Aktionen in einer einzigen Anweisungssequenz aufgerufen werden können. Sie ist nützlich für die Erstellung einer API, bei der sich der Code wie eine Reihe von Anweisungen in natürlicher Sprache liest, was die Lesbarkeit und Benutzerfreundlichkeit verbessert.

**Method Chaining:** Jede Methode gibt eine Instanz des Objekts selbst zurück, in der Regel dieses, was die Verkettung mehrerer Methodenaufrufe in einer einzigen Anweisung ermöglicht.

  ```csharp
    FluentContact obj = new FluentContact();

    obj.NameOfTheContact("Gerhard Ahrens")
            .BornOf(new DateTime(1960,6,28))
            .DeveloperOf("C#")
            .Salery(5500.96)
            .StateOf(true);
    obj.ShowDetails();
  ```

