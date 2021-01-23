# Angular10.Net5FoodPlaner &nbsp;

----

Its my project developed in free time to learn things and 'stash' some best practises solutions.

So far I've focused 90% on Angular side of the project. In following weeks I'am going to switch to develop backend in a better way.&nbsp;

From the 'business side' of this project I've done 'ingredients' and 'recipes'. I'll implement in the near future 'planns' module.&nbsp;

The plans module will be responsible for picking in an easy way recipes, place them in calendar for next week and output a shopping list.&nbsp;

It will help me organise, eat healthier, don't waste food. In future I want to implement 'best seasons' for recipes f.ex. to suggest asparagus when it's season for this ingredient.&nbsp;

----
## Angular app has:&nbsp;

- Lazy loaded (with preloading strategy) feature modules with chilid routing. In routing there are also implemented guards and resolvers;&nbsp;

- Http calls are enriched by interceptors(to add header, cache and log responses). http calls are made from a separate services provided in root module;&nbsp;

- Data for feature modules (so far only in ingredients) is fetched by observables provided by injected services. Feature modules uses shared module for common imports;

- Reactive Forms are used, so far the most advanced usage: FormGroup nested in FormArray which is nested in FormGroup (in components code and it's template) 
    for better understanding of the way it works. Custom validator (with parameter)&nbsp;

- Basic global error handling is implemented('ErrorTracker');&nbsp;

- Implemented Mediator pattern through an EventBus service to communicate between components (other than parent-child);&nbsp;

- Styles are based on material design with flex-layout;&nbsp;

- RxJs Observables with some basic operators;&nbsp;

- 'Business' features so far:&nbsp;

- Tables of ingredients, recipes and ability to perform basic RESTful CRUD operations linked to ASP.Net core backend with MS SQL database(EF Core).&nbsp;

- The 'Get' requests are implemented with filtering(by name and category), sorting, paging.&nbsp;

- There is many-to-many relation between ingredients and recipes.&nbsp;


## not yet implemented:&nbsp;
- Nested components with communication,&nbsp;

- Unit tets (will be until 15.02.2021),&nbsp;

- Security (I'll start with OpenId and Oauth2)&nbsp;



----
## .Net:&nbsp;
I havent spend much time on backend so far, only to provide data for frontend. I will develop it in the following few months.

- Entity Framework with SqlServer, 

- App is devided into feature modules,

- Few extension methods to convert domain models to database models and vice versa,

- LINQ querries,

- repository pattern which I want to quit in the future.

- Unit tests in Xunit (I'll add them till 15.02.2021),

- Mocking with NSubstitute
----
## Plans for february,march:&nbsp;
- Make all the handling calls asynchronous,

- Sorting, filtering, paging on server side,

- Implement rest of the basic features,

- Implement CQRS, divide app to two separate ones and communicate them with RabbitMq (in the future i want to use some service bus)

- Dockerize my 'microservices'

- Increase my raw SQL knowledge

- I AM OPEN FOR SUGGESTIONS

