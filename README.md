[`Install-Package Lervik.JsonClient`](https://www.nuget.org/packages/Lervik.JsonClient)

**Usage**

```csharp
var post = await Lervik.JsonClient.GetAsync<Post>("http://jsonplaceholder.typicode.com/posts/1");
```