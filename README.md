Drupal7.Services
================

.NET API to integrate with Drupal 7 via XML-RPC and Services 3 module.

The DrupalServices class “wraps” around a proxy generated by Charles Cook's excellent XML-RPC.NET library and provides a number of convenience methods to consume Drupal services both synchronously and asynchronously.

It is splitted into partial classes to facilitate ease of reading and maintenance.

Quickstart
----------

Drupal7.Services (prerelease) is available in NuGet.

User Manual
-----------

[Click here to go to the Wiki.](https://github.com/titobrasolin/Drupal7.Services/wiki)
It is far from complete, but it's a start. Updates happen every now and then but the goal is to have a complete documentation.



Usage is simple: create a new instance of DrupalServices passing the url of your service endpoint to the constructor:
```C#
    using Drupal7.Services;

    string url = "http://www.example.net/services/xmlrpc";
    var drupal = new DrupalServices (url);
```
Then call NodeIndex to retrieve an array of Drupal nodes:
```C#
    int page = 0;
    string fields = "*";
    int size = 20;
    var items = drupal.NodeIndex (page, fields, size);
```
