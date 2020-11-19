const path = require("path")

module.exports = {
    entry: {
        plugin: path.resolve("build/Program.js")
    },
    output: {
        path: path.resolve("deploy")
    },
    resolve: {
        symlinks: true
    }
}