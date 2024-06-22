# OpenFootballApp
For this project, I have used .net + angular approach and it is a single page app.
As mentioned in the task given, this app shows team information of any country chosen and the data is pulled from "open football api". I have chosen C# as the coding language and .NET for the backend part because the environment of .NET allows for easy and quick implementation of the task given.
Angular was used to present my work and knowledge and how data is called and flows between the frontend and backend of the application.
The user enters the country name and then clicks submit to get the data. The data is then presented in a table with columns that can be sorted. Pagination has also been implemented so the user can choose to which page to navigate. This is helpful when 1 country has over 200 teams, so they won't be displayed on a single page at the same time.
The app is tested and works flawlessly, but in case of teams not appearing, this might be because the calls per day limit have been reached for 1 day(using free plan of the API), consider then replacing the api key with a new created one, but this shouldn't happen in testing, so just in case.
