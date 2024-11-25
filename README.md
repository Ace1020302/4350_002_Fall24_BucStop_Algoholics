# BucStop
### Team Algoholics (Fall 2024)
### Continuation of Team [Redacted] (Spring 2024)
### Members:
> Phillip Edwards, Tyler Waddell, Ethan Roberts, Keillor Cogswell, Levi Shingleton
#### CSCI 4350
#### Spring 2024, East Tennessee State University

### Overview:
This project is a game website made by and for ETSU students. It
is a place to put games created by ETSU students.

The only repo that is necessary for deployment is the one. The other associated repos are attempts at implementing functionality of microservices.

The submission microservice (Developed in Fall 2024 by Algoholics team) is capable of sending files across two separate services when running locally.

The other repos (pong, tetris, snake, and API gateway) were created by a previous team as another attempt at implementing microservice functionality. To our (Team Algoholics) understanding, they do not communicate properly when all of them are deployed. We spent the first 2-3 sprints trying to understand the implementation as it stands and didn't mae much progress. Be warned.


### Backlog Information:
* [Backlog Fall 2023](https://brandonbcb02.atlassian.net/jira/software/projects/SCRUM/boards/1/backlog?epics=visible&atlOrigin=eyJpIjoiMjgzYjkwZGI0ZjU3NDNiM2JhMDNiOWU4MDliZjQ0YjEiLCJwIjoiaiJ9)
* [Backlog Spring 2024](https://docs.google.com/document/d/100WxhA-8cx5tWQfZs9JMoHvPGJO37cdkfATp0Td0uos/edit?usp=sharing)
### Project Plan:
* [Project Plan Doc (Word)](Vision-DoD-MVP-Scope%20Doc.docx)
* [Project Plan Doc (PDF)](Vision-DoD-MVP-Scope%20Doc.pdf)

### Project Structure: 
To understand the project structure, familiarize yourself with the
MVC (Model View Controller) structure. When clicking on a game, 
a value will be passed to the controller, which will decide which 
game to load. This is divided between the MVC folders in the main
BucStop folder.

* Bucstop
	* Controllers
		* This folder has the controllers, which allow pages to 
			link together and pass information between them.
	* Models
		* This folder has the basis for the Game class.
	* Views
		* Games
			* This folder has the pages related to games, such as
				the index page and the default game page.
		* Home
			* This folder contains the main pages used by the site, 				
				such as the home page, admin page, and privacy page.
		* Shared 
			* This contains other important pages and/or resources 
				that aren't in the other two folders, including the
				default layout and the error page.
	* wwwroot
		* This folder contains the resources used by the project, 
			including images, the javascript games, the icons, etc.
### Associated Repositories
* [Microservice Repo](https://github.com/Redacted-Team/4350_002_Fall23_MicroService)
* [API Gateway](https://github.com/Redacted-Team/4350_002_Fall23_APIGateway)
* [Tetris Microservice](https://github.com/Redacted-Team/4350_002_Fall23_Tetris)
* [Snake Microservice](https://github.com/Redacted-Team/4350_002_Fall23_Snake)
* [Pong Microservice](https://github.com/Redacted-Team/4350_002_Fall23_Pong)
* [Submission Microservice](https://github.com/clafollette303/Submission)

### Help
For more documentation on how to run locally and how to set up deployments, see the relevant links below:
* [Team Redacted Video Playlist](https://youtube.com/playlist?list=PLxsGO-QGipWmVzxFkVbA-o6BUW5eRdk3H&si=a7jHaNBgdTtXgoJ4)
* [Running Locally](Documentation/Deployment/Algoholics_Local_Instance_Guide.txt)
* [How to Deploy](Documentation/Deployment/Algoholics_Deployment_Guide.txt)
