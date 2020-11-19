const path = require("path")
const HtmlWebpackPlugin = require("html-webpack-plugin")

module.exports = {
    entry: {
        application: path.resolve("build/Program.js")
    },
    output: {
        path: path.resolve("deploy")
    },
    plugins: [
        new HtmlWebpackPlugin({
            filename: "index.html",
            template: "public/index.html"
        })
    ],
    resolve: {
        symlinks: true
    },
    devServer: {
        publicPath: "/",
        contentBase: path.resolve("public"),
        host: "0.0.0.0",
        port: "8080",
        hot: true,
    }
}