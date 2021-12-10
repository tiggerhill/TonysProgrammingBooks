This template:

*	MVC template with basic minimum Folders and Files
*	Client-side Library items added:
		jquery
		twitter-bootstrap
		popper.js
		jquery-validate
		jquery-validation-unobstrusive
*	NeGet packages added:
		Microsoft.EntityFrameworkCore.SqlServer
		Microsoft.EntityFrameworkCore.Tools

*	Model added
		TODO change name from ClassModel to appropriate name
*	_ViewImports added
		TODO change using statements to current project name
*	_Layout Razor layout added
*	_ViewStart Razor View Start item added
*	Index.chtml Razor View item added

**	Models: files that define the class, plus a Context class
			that handles communcation with the database
**	Views:	files associated with the action methods in the
			Controller classes, plus a Shared folder that
			contains a layout that's shared by the views
** Controllers:	the files that define the Home Controller
			that gets a list of items, and a controller that
			handles the adding, editing, and deleting
** Migrations:	files that create a SQL Server LocalDB
			database and seed it with initial data

***	Three classes provided by EF Core
		DbContext - the primary class for communicating with the database
		DbContextOptions - provides configuration options for the DbContext object
		DbSet<Entity> - a collection of model classes, aka 'entity classes' or
			'domain model classes' that map to a database table

*	Create a DbContext Class and seed initial data

**	Added a connection string to the appsettings.json file
**	Enabled dependency injection in the Startup class

***** Create the Database *****
	Select the Tools / NuGet Package Manager / Package Manager Console command
	Make sure the connection string and dependency injection are set up
	Type "Add-Migration Initial" in the PMC at command prompt and enter
	Type "Update-Database" at the command prompt and enter
		

******** TODO ********
search files to TODO comments to fix code names, etc.



