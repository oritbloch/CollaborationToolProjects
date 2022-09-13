# SharingTextWebApi


sever &amp; client

This project consists of serverAPI project and WebSite project (Which they are actually 2 seperated projects - for different places to deploy).
The website is calling the serverAPI by HTTPCLIENT services.
The server has static class and a simple static string member for saving all the text messages in memory during runtime.
The server gets the user-login-time from the website and give the rellevant messages according to time comarision.

For large scale data & more user details we may use a NoSql database and cloud.

I tried to use google API for authentication but it's integration had been changed lately and I couldn't complete implementation during the remaining time for the assignment.

Hope everything is cleared.
Orit Bloch
