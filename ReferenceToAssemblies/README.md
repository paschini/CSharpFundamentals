# References To Assemblies
## Demonstrates external libraries can be used in the program.

This project was created by installing a nuget package. It doesn't do anything.

The following projects demonstrate this concept further:

- [MyCodeLibrary](jetbrains://rd/navigate/reference?project=Fundamentals&path=MyCodeLibrary%2FScrape.cs) - Contains an example library.
- [MyClient](jetbrains://rd/navigate/reference?project=Fundamentals&path=MyClient%2FProgram.cs) - Is a project that uses the library.

> [!hint]
> Notice that in the `/bin` folder In MyClient there is a `MyCodeLibrary.dll` file.

Running MyClient will print the [MSDN Microsoft](http://msdn.microsoft.com) website.

By building both the library and the client in the same Solution, it is easier to access the library and add it to the client.

Whether to create a separate solution for the library and client is up to you, and dependant on the needs of each specific project.
