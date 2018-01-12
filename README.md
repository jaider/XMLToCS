# XML To C#

Ideally you will run this tool once to examine your XML and the output will be a C# Code that you can use in your application.

[w3schools XML Samples](https://www.w3schools.com/xml/)


## Sample #1
```xml
<?xml version="1.0" encoding="UTF-8"?>
<note>
  <to>Tove</to>
  <from>Jani</from>
  <heading>Reminder</heading>
  <body>Don't forget me this weekend!</body>
</note>
```

The result will be:
```csharp
return new XElement("note",
    new XElement("to", "Tove"),
    new XElement("from", "Jani"),
    new XElement("heading", "Reminder"),
    new XElement("body", "Don't forget me this weekend!"));
```


## Sample #2
```xml
<?xml version="1.0" encoding="UTF-8"?>
<breakfast_menu>
<food>
    <name>Belgian Waffles</name>
    <price>$5.95</price>
    <description>
   Two of our famous Belgian Waffles with plenty of real maple syrup
   </description>
    <calories>650</calories>
</food>
<food>
    <name>Strawberry Belgian Waffles</name>
    <price>$7.95</price>
    <description>
    Light Belgian waffles covered with strawberries and whipped cream
    </description>
    <calories>900</calories>
</food>
<food>
    <name>Berry-Berry Belgian Waffles</name>
    <price>$8.95</price>
    <description>
    Belgian waffles covered with assorted fresh berries and whipped cream
    </description>
    <calories>900</calories>
</food>
<food>
    <name>French Toast</name>
    <price>$4.50</price>
    <description>
    Thick slices made from our homemade sourdough bread
    </description>
    <calories>600</calories>
</food>
<food>
    <name>Homestyle Breakfast</name>
    <price>$6.95</price>
    <description>
    Two eggs, bacon or sausage, toast, and our ever-popular hash browns
    </description>
    <calories>950</calories>
</food>
</breakfast_menu>
```

The result will be:
```csharp
new XElement("breakfast_menu",
    new XElement("food",
        new XElement("name", "Belgian Waffles"),
        new XElement("price", "$5.95"),
        new XElement("description", "Two of our famous Belgian Waffles with plenty of real maple syrup"),
        new XElement("calories", "650"))
    ,
    new XElement("food",
        new XElement("name", "Strawberry Belgian Waffles"),
        new XElement("price", "$7.95"),
        new XElement("description", "Light Belgian waffles covered with strawberries and whipped cream"),
        new XElement("calories", "900"))
    ,
    new XElement("food",
        new XElement("name", "Berry-Berry Belgian Waffles"),
        new XElement("price", "$8.95"),
        new XElement("description", "Belgian waffles covered with assorted fresh berries and whipped cream"),
        new XElement("calories", "900"))
    ,
    new XElement("food",
        new XElement("name", "French Toast"),
        new XElement("price", "$4.50"),
        new XElement("description", "Thick slices made from our homemade sourdough bread"),
        new XElement("calories", "600"))
    ,
    new XElement("food",
        new XElement("name", "Homestyle Breakfast"),
        new XElement("price", "$6.95"),
        new XElement("description", "Two eggs, bacon or sausage, toast, and our ever-popular hash browns"),
        new XElement("calories", "950"))
);
```
