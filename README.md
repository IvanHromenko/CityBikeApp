# CityBikeApp
Exercise for Solita Dev Academy. Deployed in Azure, the link - https://citybiketrips.azurewebsites.net/
Used ASP.NET MVC framework with C# programming language, data was imported to Microsoft SQL Server in Azure.

# Data import
Imported CSV files to SQL Server, cleaned records with journeys lasted less than 10 seconds or less than 10 metres long.
# Journey list view
In the home page 10 journeys are shown with Departure station, Return station, Distance in km and Duration in minutes.
# Station List
Listed all the stations in data table format(tried to do the same with journeys, but number of records is too large:( ), added functionality to add a new station.
Also wrote a small e2e test to check the adding functionality.
# Single station view
You can click on the details button near each station to check the Station address.
