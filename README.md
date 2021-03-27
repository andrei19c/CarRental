# CarRental

In order to use database, I choosed to set a docker container with a mssql server express image and use a real database. 
To run on your local machine, you need to have already installed Docker Desktop and to run the following command to create the docker image:

docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourPassword' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu

The command will create a mssql server express image that can be accessed from SQL Management Studio (if you have it installed) using the following info:
server name: localhost, 1433
Authentification: SQL Server Authentification
Login: SA
Password: yourPassword

