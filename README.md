# UnitTesting

## Summary
The purpose of this project is to offer a simple sandbox to look at examples of unit testing on a simple object orientated project. Nothing will run if you simply run the project so instead navigate to the ``StoreProject.Tests`` to begin running tests on the classes to demonstrate their functionality against expected outcomes.

The project is still in progress and further logic will be added to make testing the classes slightly harder but ultimately give us an understanding of how to set the test environment up.

## Key Parts to gaining an understanding

-  Packages ``Moq`` and ``FluentAssertions`` have been used to add functionality to enable full testing within a controlled envrionment.
- ``Moq`` - Is used to essentially create mocked objects that can be injected into classes and setup to return specific values based on the context we want to test a method.
- ``FluentAssertions`` - Simply used to enable our assertions on the results of the tests to have a more of a flow, ultimately making them more readable.
