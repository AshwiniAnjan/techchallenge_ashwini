Crownbet_Ashwini Readme  file
-----------------------------------------

1. Database script is placed under Crownbet_database\Database_Scripts folder.
2. First create a database named "Crownbet" and execute the scripts from above mentioned folder.
3. Replace the connection string according to your server details in Crownbet_web\Web.config .
4. Log4Net has been used for logging purposes and Change the directory where log has to be logged in Crownbet_Web/Web.config file in <log4net> section. Currenlty it is set to "D:\\"
5. EntityFramework is used to connect to Database.
6. Automapper is used for mapping purposes.
7. Autofac is used for Dependency Injection.
8. Swagger is used for documentation purpose.
9. Currently route is configured as "http://localhost:52007/api/Controller/Action".If needs to be changed change in WebApiConfig in App_start folder.
10. The endpoints are
     a. http://localhost:52007/api/Race/GetRaces?name='Ashwini'  -- GetRaces endpoint provides information on the race and also the horses running in the race

     b.  http://localhost:52007/api/Race/GetCustomers?name='Ashwini' -- GetCustomers endpoint provides information on the customers

    c.  http://localhost:52007/api/Race/GetBets?name='Ashwini' -- GetBets gets the total value of bets of all the races


11. Swagger can be accessed at http://localhost:52007/swagger/

12. Once the code is deployed on to the server replace "http://localhost:52007/" with the server name and port name
     
13. Unit testing has been done using moq and visual studio testing framework. 