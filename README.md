`Install-Package Lervik.JsonClient`

**Usage**

```
var post = await Lervik.JsonClient.GetAsync<Post>("http://jsonplaceholder.typicode.com/posts/1");
```