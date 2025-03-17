## Comparison of Hand-Testing vs. Unit Testing with NUnit
1. Extensibility
Unit Testing (NUnit) is more extensible.

New test cases can be added easily by writing new test methods or using [Test].
Hand-testing requires manually running the program each time, making it harder to extend efficiently.
2. Maintainability
Unit Testing is easier to maintain.

Changes in the Calculator class require only updating the test methods.
With hand-testing, a change means manually re-executing different test scenarios, increasing the chance of human error.
3. Readability
Unit Testing is more readable for developers.

Tests are written in structured code using NUnit assertions (Assert.AreEqual(), etc.).
A new developer can understand how the class is expected to behave by just looking at the test cases.
Hand-testing relies on written documentation or trial and error, which is harder to follow.
4. Automation
Unit Testing is highly automatable.

NUnit tests can be integrated into CI/CD pipelines to run automatically (e.g., every 15 minutes or before merging code).
Hand-testing is not automatable and requires a person to execute tests manually.