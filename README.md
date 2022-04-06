# AspNet Self Host
Host ASP.NET Web API in a console application, using OWIN to self-host the Web API framework.

Open Web Interface for .NET (OWIN) defines an abstraction between .NET web servers and web applications. OWIN decouples the web application from the server, which makes OWIN ideal for self-hosting a web application in your own process, outside of IIS.

```
            using (WebApp.Start<Startup>("http://localhost:8080"))
            {
                Console.WriteLine("Web Server is running.");
                Console.WriteLine("http://localhost:8080/api/home");
                Console.ReadLine();
            }
```
