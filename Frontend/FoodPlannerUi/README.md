# FoodPlannerUi

Contains so far:
-Lazy loaded (with preloading strategy) feature modules with chilid routing. In routing there are also implemented guards and resolvers;
-Http calls are enriched by interceptors(to add header, cache and log responses). http calls are made from a separate services provided in root module;
-Data for feature modules is fetched by observables provided by injected services. Feature modules uses shared module for common imports;
-Implemented Mediator pattern through an EventBus service to communicate between components (other than parent-child);
-Styles are based on material design with flex-layout;
-Reactive Forms are used, so far the most advanced usage: FormGroup nested in FormArray which is nested in FormGroup (in components code and it's template) 
    for better understanding of the way it works. Custom validator
-Basic global error handling is implemented('ErrorTracker');
-'Business' features so far:
Tables of ingredients, recipes and ability to perform basic RESTful CRUD operations linked to ASP.Net core backend with MS SQL database(EF Core).
The 'Get' requests are implemented with filtering(by name and category), sorting, paging.
There is many-to-many relation between ingredients and recipes.

not yet implemented:
nested components with communication,
