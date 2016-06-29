Httpclient helper to get and deserialize json. Made with .NET Core and [netstandard1.1](https://github.com/dotnet/corefx/blob/master/Documentation/architecture/net-platform-standard.md#mapping-the-net-platform-standard-to-platforms) so it should work on most platforms.

**Usage**

[`Install-Package Lervik.JsonClient`](https://www.nuget.org/packages/Lervik.JsonClient)

```csharp
var post = await Lervik.JsonClient.GetAsync<Post>("http://jsonplaceholder.typicode.com/posts/1");
```