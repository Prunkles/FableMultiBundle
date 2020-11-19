module Plugin

open PluginFramework
open Fable.Core


[<Emit """
globalThis.GlobalPlugin = $0
""">]
let setGlobalPlugin (plugin: Plugin) : unit = jsNative

let mkPlugin () =
    let plugin = { Id = PluginId "THE_PLUGIN_ID" }
    plugin

let runPlugin plugin =
    setGlobalPlugin (plugin)


mkPlugin ()
|> runPlugin