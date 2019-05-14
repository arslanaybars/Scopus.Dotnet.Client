# Scopus.Dotnet.Client

Easy to understand C#.NET client for Scopus API

## Installation

**Nuget Package Manager**
```
PM> Will be added
```

## Getting Started
In order to use signed methods you need to [sign up to Elsevir](https://id.elsevier.com/as/yWNAW/resume/as/authorization.ping), 
if you already have one, go to [create a Elsevir api key](https://dev.elsevier.com/apikey/create) create a new API private key.

Create api client base on domain <br />
Pass *ApiUrl* and *ApiKey*

```c#
private ScopusSearchClient apiClient = new ScopusSearchClient("https://api.elsevier.com/", "7f59af901d2d86f78a1fd60c1bf9426a");
```

Retrieve data by using created api client<br />
**Do not forget** to pass *EndPoint* and *Query*

To write better scopus search queries, please see [scopus search tips](https://dev.elsevier.com/tips/ScopusSearchTips.htm)

```c#
var scopusSearchResult = await apiClient.GetAsync<SearchResults<Models.Search.Scopus>>("content/search/scopus", "query=AFFILCITY(KARABUK)AUTHOR-NAME(TURKER I)");
```

## Useful Links
- [Elsevier Developer Site](https://dev.elsevier.com/)
- [Elsevier Scopus APIs](https://dev.elsevier.com/sc_apis.html)
- [Elsevier Scopur Interactice Swagger Document](https://dev.elsevier.com/scopus.html)
- [Scopus search tips](https://dev.elsevier.com/tips/ScopusSearchTips.htm)
 

### License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details
