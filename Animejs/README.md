Fable bindings for [Animejs](http://animejs.com).
=======

### Using
1. `paket add Fable.Import.Animejs`
2. `yarn add animejs`

In your webpack config add `"animejs"` to your entry option.

Example:

```js
 module.exports = {
   entry: [
       "animejs",
       "MyProject.fsproj"
   ]
   ...
 }
```

### Building the package
1. `dotnet restore`
2. `dotnet pack`
