# Webjob Timer

This is a repository created in order to reproduce a bug in which Continuous Azure WebJobs using TimerTrigger and NCrontab 3.10 run jobs more frequently than intended.

## How to reproduce the bug
1. Clone this repository and open the solution file in Visual Studio
2. Build the solution (make sure nuget packages have been restored"
3. Create an Azure storage account (v2, using the new portal)
4. Create an Azure web app (under app services) with an S1 app service plan
5. Under your web app settings > Application settings, set Always On, and create two App Settings
  * AzureWebJobsDashboard
  * AzureWebJobsStorage
6. Find the connection string for your storage account, and enter it as the value for both of these App Settings
7. Right-click on the WebJob1 project file in Visual Studio (Solution Explorer window) and select Publish as Azure WebJob
8. Go through the steps to publish to the existing web app you just created
9. Go back to the web app settings in Azure portal and scroll down to WEB JOBS. Select this, and open the URL that appears under Logs in the new pane
10. You are now in the dashboard for the WebJob, and should see the RunAtMidnight function. It should run every thirty minutes to an hour.
