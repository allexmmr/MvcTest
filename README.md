# ASP.NET Core MVC Test
This is a sample code developed in ASP.NET Core, using Entity Framework Code First, HTML, CSS, Bootstrap, jQuery and more.
#

#### Objective
###### Given the following entity:

#
#### Contact
###### Id: int, assigned by DB
###### FirstName: string, maxlength(100), required
###### LastName: string, maxlength(100), required
###### Knickname: string, maxlength(20), optional
###### DisplayAs: {FirstLast, LastFirst (default), Knickname}, required
###### DateOfBirth: date, optional
###### PhoneNumber: string, required

#
#### Write an ASP.NET MVC program that:
###### · Stores contact data in SQL Server database
###### · Displays a list in HTML page using DisplayAs value
###### · Allows to add, edit and delete contacts from popup form

#
#### Notes
###### 1. Please use Entity Framework, Code First; provide seed data for testing.
###### 2. Please use Bootstrap and jQuery. Add Knockout only if necessary. We wouldn't mind if you use e.g. Angular or React but please provide very strong rationale for doing so.
###### 3. Please consider that this is not a standalone app but a part of an admin portal, where multiple entities would have to be managed in the same fashion (e.g. Contacts, Places, Events etc.)
###### 4. For bonus points indicate in code how you would do unit testing and functional testing. It's not necessary to provide fully working code.
###### 5. It's going to be super awesome if you use ASP.NET Core and put the code on your GitHub or BitBucket account.
