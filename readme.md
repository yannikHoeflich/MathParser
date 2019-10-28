# GImage
parse an string with mathematical operations to an int / float / double

## Downloads
[MathParser.dll](/downloads/MathParser.dll)

## Getting Started
Only tested on Windows with the .NET framework.

Import The namespace Gidyyy.MathParser with
```
using Gidyyy.MathParser;
```

## latest changes
```
18.10.2019:
    added:
        signs:  
            ^: pow
        methods:
            SetBrackets
27.10.2019:
    first version
```

### Supported mathematical signs
```
+: add
-: subtract
*: multiply
/: divide
^: pow
```

### Supported mathematical rules
```
point before line: calculates * and / before + and -
supports brackets
```

### Methods
```
static int ParseToInt(string)
static float ParseToFloat(string)
static double ParseToDouble(string)

static string SetBrackets(string)
```
