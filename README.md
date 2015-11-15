# DemonstrationProject by Gary Chadwick

This contains three projects:
Acceptance tests - Specflow
DemonstrationProject for website
Unit tests - Visual Studio + Rhino Mocks

The website containing the bill page is in demonstration project and contains a 
layered structure that gives you an impression of the structure of project that I 
work with in my current role.  This structure being:

Controller (BillController) -> Business Logic -> (CustomerBl) -> Adaptor (CustomerDataServiceAdaptor)

SimpleInjector has been used for the dependency injection.

I coded the project following TDD principles e.g. I wrote the tests alongside writing the code to get the JSON and return it back to the model.

A CustomerBillMapper converts the file from its raw CustomerDataService form to the domain model required for the business logic and eventually model - required for the view.

The adaptor connects to the web service project and retrieves the JSON file as requested.

The bill can be viewed at the following AWS server I have deployed the website to:
http://ec2-52-33-244-88.us-west-2.compute.amazonaws.com/CustomerBill

The webservice is located at a separate server:
http://ec2-52-33-19-179.us-west-2.compute.amazonaws.com/CustomerDataWebService.svc
