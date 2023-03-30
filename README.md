# Web_Driver_Experiment


Page Object Design Pattern says operations and flows in the UI should be separated from verification.

This concept makes our code cleaner and easy to understand, Dry pattern.
The Second benefit is the object repository is independent of test cases, so we can use the same object repository for a different purpose with different tools.

Have to look this up: For example, we can integrate Page Object Model in Selenium with TestNG/JUnit for functional Testing and at the same time with JBehave/Cucumber for acceptance testing.


Methods get more realistic names which can be easily mapped with the operation happening in UI. i.e. if after clicking on the button we land on the home page, the method name will be like ‘gotoHomePage()’.
