# Waa.ai
Waa.ai link shorter API Wrapper for C#

***How To Use***

```cs
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Waa.ai;

namespace Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            WaaaiClient Client = new WaaaiClinet("API KEY");
            WaaaiResponse Response = Client.ShortUrl("URL");
            Console.Write(Response.Data.Url);
            await Task.Delay(-1);
        }
    }
}
```

The Data types you can find in ``Waaai Response`` are 

```cs
WaaaiData Data;
bool Success; // it be true if the call is success
int Status; // the status code of the request
```
The Data tpyes you can find in ``Waaai Data`` are
```cs
string Url; // the short url
string ShortUrlCode; // the hash of the short url
string Extension; // the Extension of the file if it was link to file or image
string DeleteLink; // the link to delete the short Url
string DeleteHash; // the Hash of the delete link
string LongUrl; // the original Url
```
