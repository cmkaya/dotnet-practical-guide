# Dependency Injections

Imagine you are running a coffee shop, and you have three types of employees: baristas, cashiers, and managers. Each type of employee represents a different dependency with a different lifetime in your coffee shop application.

1. **Transient Lifetime (Baristas):**

   - Transient services are like hiring a new barista for each customer who walks into your coffee shop.
   - When a customer comes in, you hire a new barista to make their coffee. After the customer leaves, that barista is no longer needed and can be let go.

   ```csharp
   services.AddTransient<IBarista, Barista>();
   ```

2. **Scoped Lifetime (Cashiers):**

   - Scoped services are like hiring a cashier for a single shift in your coffee shop.
   - When a customer comes in during a shift, the same cashier handles all their transactions. Once the shift ends, the cashier can go home, and a new cashier is hired for the next shift.

   ```csharp
   services.AddScoped<ICashier, Cashier>();
   ```

3. **Singleton Lifetime (Manager):**

   - Singleton services are like having a single manager overseeing your coffee shop at all times.
   - The manager is responsible for managing everything in the coffee shop and remains in place as long as the coffee shop is open.

   ```csharp
   services.AddSingleton<IManager, Manager>();
   ```

Now, let's apply this analogy to retrieving items from a database:

- Transient Lifetime (Baristas): If you configure a service as transient, a new instance of that service is created every time it's needed. In the context of a database, a new database connection or data access component is created for each database query. After the query is complete, that connection is closed and disposed of.

- Scoped Lifetime (Cashiers): If you configure a service as scoped, a single instance of that service is created for the duration of an operation or request. In the database context, a single database connection or data access component is created and shared across all queries within the same operation or request. Once the operation or request is complete, the connection is closed and disposed of.

- Singleton Lifetime (Manager): If you configure a service as a singleton, only one instance of that service is created and shared across the entire application's lifetime. In the database context, a single database connection or data access component is created and used for all queries from the start of the application until it's shut down.

The choice of which lifetime to use depends on factors like resource efficiency, isolation requirements, and concurrency considerations in your specific application scenario. Different lifetimes provide different trade-offs, and it's essential to choose the one that aligns with your application's requirements and performance constraints.

This image from the demo app which demonstrates the difference of lifetimes:

![Dependency-Injection-Lifetime](/docs/imgs/Dependency-injection.png)


**Check the related demo applications:**

- [DependencyInjectionDemo](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/ASPNETCoreDemoApps/DIServiceLifetimeDemo)

**Learn more:**

- [Microsoft documentation](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-7.0#service-lifetimes-and-registration-options)
- [stackoverflow](https://stackoverflow.com/questions/38138100/addtransient-addscoped-and-addsingleton-services-differences)