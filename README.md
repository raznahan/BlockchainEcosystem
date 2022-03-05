# Blockchain Ecosystem Connection Graph

This is a web-based connection graph for the blockchain ecosystem in my home country, developed using ASP.NET MVC and JavaScript.

## Preview


![](./extras/readme/preview.gif)


## About the **Project**

What this project does is it basically provides you with a visual representation of companies/institutes that are working within the blockchain ecosystem.
This visualization is helpful for managers or anyone working in the industry to understand how competitors are connected to one another. One could use this project
to create the same structure for other sectors as well.

In order to visualize companies/entities, I have used [vis.js][vis library] library. Using that, I was able to render each entity as a node on the web page. Connections are also easily
managed by the input you give to the library. **Link.cs** class is the model that stores relationships/connections between entities.

>Therefore, all you need to do is provide two model databases to the application. The first is the entities themselves, modelled in **Node.cs**, and the second is **Link.cs**, which stores relational connection between nodes.

You can also search within the graph via the search box provided at the upper center of the page.


>** The data in the live version is an old dataset that I had previously collected. Most of them are not really valid anymore.


[vis library]:https://visjs.org/
