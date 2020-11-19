# FableMultiBundle

## Running

1. Restore tools (fable) 
    * `dotnet tool restore`
2. Build plugin
    1. `cd Plugin`
    2. `npm i`
    3. `npm run build`
3. Copy all code from the file `./Plugin/deploy/plugin.js` to Application `./Application/Program.fs` (field `pluginCode`, line 11)
4. Build and run Application
    1. `cd ../Application`
    2. `npm i`
    3. `npm run watch`
5. Go to `localhost:8080`
6. View the console
