ASP.NET Chapter 8 Homework
--

1. Describe the difference between a view and a partial view.


--A partial view is a view that's rendered within another view. The HTML output generated by executing the partial view is rendered into the calling (or parent) view.


2. Throughout the book you have seen examples of LINQ, in your own words describe what it is used for and how it works.


--MS language developers provided a way to express queries directly in their languages (such as c# and vb). The techniques for forming these queries do not rely on the implementation details of the thing being queried, so that you can write valid queries against many targets (databases, in-memory objects, xml) with practically no consideration of the underlying way in which the query will be executed.


3. Look at this piece of code and tell me what it does, and where I would find it written: a. routes.MapRoute(null, "{category}/Page{page}", new { controller = "Product", action = "List" },new { page = @"\d+" }); b. Which call maps to 3a?
RouteConfig.cs


4. Give a brief explanation of the ASP.Net routing system.


--ASP.NET routing system is used by MVC to handle incoming requests from clients, but it also generates outgoing URLs that conform to the URL scheme and that can be embedded in web pages


5. ASP.Net has a concept of child actions, can you describe it? How would you use it?


--Relies on the HTML helper method called html.action, which lets you include the output from an arbitrary action method in the current view


6. What is a _Layout.cshtml file? How do you use it, if at all?


--The _layout.cshtml files integrates the child action into the rest of the application - the child action is rendered in the layout rather than a specific view


7. What is a ViewResult? A PartialViewResult? An ActionResult? When/how would you use them?

--Difference Between ViewResult() and ActionResult() ActionResult is an abstract class that can have several subtypes. ViewResult-Renders a specifed view to the response stream. PartialViewResult-Renders a specifed partial view to the response stream. EmptyResult-An empty response is returned.

8. What is an Entity and how is it used in this project?

--Entity framework and MVC is different. Entity Framework is object-relational mapper used in .Net to access database without caring about the most of the data access code the developer needs to write. So it eases data access for developers.

9. When creating a form in ASP.Net what command can you use that will generate the traditional HTML element? What are action attributes and what kind of actions can a form perform?

--Attributes (at least those that apply to the filters) mark what the filter is applied to, i.e. an action method or a controller. An example would be the Authorize attribute. This attribute corresponds to an AuthorizationFilter that implements the IAuthorizationFilter interface. Applying the Authorize attribute to an action method tells MVC to authorize a request targeting that action method, applying it to a controller tells MVC to authorize any request targeting an action method of the controller, or authorization can also be applied globally for all requests. Now I said before, at least those that apply to the filters, because Attributes are a concept and syntax of .NET and not just MVC. There are attributes for so many other things and are generally to provide additional information about the property, method, class, they are applied to.

10. What is an ASP.Net session state? How is it being used in this project?

--ASP.NET session state enables you to store and retrieve values for a user as the user navigates ASP.NET pages in a Web application. HTTP is a stateless protocol. This means that a Web server treats each HTTP request for a page as an independent request.

11. Why would you create a separate Model object? What is it’s purpose?

--Create a new project with appropriate name and move the models to a new project. It is as simnple as that. Then add a reference to the project you are using. Next step is to Create interfaces and implement those interfaces for code separation. Next use IoC (Inversion of control or dependency injection). I suggest asp.net mvc structure map for Ioc. You can use NuGet tool to do the job for you.

12. Describe some ways that Bootstrap was used in this chapter.12. 

--Right click the solution and select Manage NuGet packages for solution.. option.
In the Manage NuGet screen, select Installed Packages section.
Then select the bootstrap package in the center pane to see the version details.
