// See https://aka.ms/new-console-template for more information
using Linq_example;
using Linq_example.Method;

var testingData = new TestData();

var data = testingData.GetTestingData();

// Example for method syntax
var methodSyntax = new LinqTest();
methodSyntax.TestMethod(data);