# NWU Vaal - Britehouse Project 2019
This is a project given to the North West University Vaal Triangle Campus BScIT third year students from Britehouse accompanied with a guest lecture on ASP.NET MVC Core Web app development, Entity Framework and Repository Pattern

## Data
The dataset is comprised of African Angelist startup companies recorded in multiple CSVs found on data.world: https://data.world/omayeli/angelist-startups-in-africa/workspace/intro

## Data Wrangling
A Python script has been added which was used to cycle through each of the CSVs, grab the filename, add it to the dataframe as country name, append the temp dataframe to the main dataframe and write the dataframe to a CSV.

## Requirements
In order to get the solution to work, the following should be done:
- Save the CSV data in a SQL Server database
- Scaffold the solution in ASP.NET using the previously mentioned database
- Add database connection string to appsettings.json
- Live long and prosper
