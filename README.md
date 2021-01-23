# Angular10.Net5FoodPlaner
Its my project developed in free time to learn things and 'stash' some best practises solutions.
So far I've focused 90% on Angular side of the project. In following weeks I'am going to switch to develop backend in a better way.
From the 'business side' of this project I've done 'ingredients' and 'recipes'. I'll implement in the near future 'planns' module.
The plans module will be responsible for picking in an easy way recipes, place them in calendar for next week and output a shopping list.
It will help me organise, eat healthier, don't waste food. In future I want to implement 'best seasons' for recipes f.ex. to suggest asparagus when it's season for this ingredient.

Angular app has:
-Lazy loaded (with preloading strategy) feature modules with chilid routing. In routing there are also implemented guards and resolvers;
-Http calls are enriched by interceptors(to add header, cache and log responses). http calls are made from a separate services provided in root module;
-Data for feature modules (so far only in ingredients) is fetched by observables provided by injected services. Feature modules uses shared module for common imports;
-Reactive Forms are used, so far the most advanced usage: FormGroup nested in FormArray which is nested in FormGroup (in components code and it's template) 
    for better understanding of the way it works. Custom validator (with parameter)
-Basic global error handling is implemented('ErrorTracker');
-Implemented Mediator pattern through an EventBus service to communicate between components (other than parent-child);
-Styles are based on material design with flex-layout;
-Rxjs Observables with some basic operators;
-'Business' features so far:
Tables of ingredients, recipes and ability to perform basic RESTful CRUD operations linked to ASP.Net core backend with MS SQL database(EF Core).
The 'Get' requests are implemented with filtering(by name and category), sorting, paging.
There is many-to-many relation between ingredients and recipes.

not yet implemented:
-nested components with communication,
-unit tets (will be until 15.02.2021),
-security (I'll start with OpenId and Oauth2)



.Net:
I havent spend much time on backend so far, only to provide data for frontend. I will develop it in the following few months.
-Entity Framework with SqlServer, 
-app is devided into feature modules,
-few extension methods to convert domain models to database models and vice versa,
-LINQ querries,
-repository pattern which I want to quit in the future.
-Unit tests in Xunit (I'll add them till 15.02.2021),
-mocking with NSubstitue.

Plans for february,march:
- Make all the handling calls asynchronous,
- implement rest of the basic features,
- implement CQRS, divide app to two separate ones and communicate them with RabbitMq (in the future i want to use some service bus)
- dockerize my 'microservices'
- increase my raw SQL knowledge
- I AM OPEN FOR SUGGESTIONS