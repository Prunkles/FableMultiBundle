module Application

open Fable.Core
open Browser
open Browser.Types
open PluginFramework


/// Copied from ./Plugin/deploy/plugin.js
let pluginCode = """
!function(t){var e={};function n(r){if(e[r])return e[r].exports;var u=e[r]={i:r,l:!1,exports:{}};return t[r].call(u.exports,u,u.exports,n),u.l=!0,u.exports}n.m=t,n.c=e,n.d=function(t,e,r){n.o(t,e)||Object.defineProperty(t,e,{enumerable:!0,get:r})},n.r=function(t){"undefined"!=typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},n.t=function(t,e){if(1&e&&(t=n(t)),8&e)return t;if(4&e&&"object"==typeof t&&t&&t.__esModule)return t;var r=Object.create(null);if(n.r(r),Object.defineProperty(r,"default",{enumerable:!0,value:t}),2&e&&"string"!=typeof t)for(var u in t)n.d(r,u,function(e){return t[e]}.bind(null,u));return r},n.n=function(t){var e=t&&t.__esModule?function(){return t.default}:function(){return t};return n.d(e,"a",e),e},n.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},n.p="",n(n.s=0)}([function(t,e,n){"use strict";function r(t){return Array.isArray(t)||ArrayBuffer.isView(t)}function u(t){return"function"==typeof t.GetHashCode}function i(t,e){return Object.getPrototypeOf(t).constructor===Object.getPrototypeOf(e).constructor}n.r(e),n.d(e,"mkPlugin",(function(){return G})),n.d(e,"runPlugin",(function(){return H}));function o(t){const e=t;return"number"==typeof e.offset?e.offset:1===t.kind?0:-6e4*t.getTimezoneOffset()}(()=>{class t{static id(e){return t.idMap.has(e)||t.idMap.set(e,++t.count),t.idMap.get(e)}}t.idMap=new WeakMap,t.count=0})();function s(t){let e=0,n=5381;const r=t.length;for(;e<r;)n=33*n^t.charCodeAt(e++);return n}function f(t){return 2654435761*t|0}function l(t){return 0===t.length?0:t.reduce((t,e)=>(t<<5)+t^e)}function c(t){if(null==t)return 0;switch(typeof t){case"boolean":return t?1:0;case"number":return f(t);case"string":return s(t);default:if(u(t))return t.GetHashCode();if(r(t)){const e=t.length,n=new Array(e);for(let r=0;r<e;r++)n[r]=c(t[r]);return l(n)}if(t instanceof Date)return t.getTime();if(Object.getPrototypeOf(t).constructor===Object){return l(Object.values(t).map(t=>c(t)))}return s(String(t))}}function a(t,e,n){if(null==t)return null==e;if(null==e)return!1;if(t.length!==e.length)return!1;for(let r=0;r<t.length;r++)if(!n(t[r],e[r]))return!1;return!0}function h(t,e){return a(t,e,g)}function g(t,e){return t===e||(null==t?null==e:null!=e&&("object"==typeof t&&(function(t){return"function"==typeof t.Equals}(t)?t.Equals(e):r(t)?r(e)&&h(t,e):t instanceof Date?e instanceof Date&&0===m(t,e):Object.getPrototypeOf(t).constructor===Object&&function(t,e){const n=Object.keys(t),r=Object.keys(e);if(n.length!==r.length)return!1;n.sort(),r.sort();for(let u=0;u<n.length;u++)if(n[u]!==r[u]||!g(t[n[u]],e[r[u]]))return!1;return!0}(t,e))))}function m(t,e){let n,r;return"offset"in t&&"offset"in e?(n=t.getTime(),r=e.getTime()):(n=t.getTime()+o(t),r=e.getTime()+o(e)),n===r?0:n<r?-1:1}function y(t,e){return function(t,e,n){if(null==t)return null==e?0:1;if(null==e)return-1;if(t.length!==e.length)return t.length<e.length?-1:1;for(let r=0,u=0;r<t.length;r++)if(u=n(t[r],e[r]),0!==u)return u;return 0}(t,e,d)}function d(t,e){return t===e?0:null==t?null==e?0:-1:null==e?1:"object"!=typeof t?t<e?-1:1:function(t){return"function"==typeof t.CompareTo}(t)?t.CompareTo(e):r(t)?r(e)?y(t,e):-1:t instanceof Date?e instanceof Date?m(t,e):-1:Object.getPrototypeOf(t).constructor===Object?function(t,e){const n=Object.keys(t),r=Object.keys(e);if(n.length!==r.length)return n.length<r.length?-1:1;n.sort(),r.sort();for(let u=0,i=0;u<n.length;u++){const o=n[u];if(o!==r[u])return o<r[u]?-1:1;if(i=d(t[o],e[o]),0!==i)return i}return 0}(t,e):-1}function p(t){let e=0,n="[";for(const r of t){if(0===e)n+=b(r);else{if(100===e){n+="; ...";break}n+="; "+b(r)}e++}return n+"]"}function b(t,e=0){if(null!=t&&"object"==typeof t){if("function"==typeof t.toString)return t.toString();if(Symbol.iterator in t)return p(t);{const n=Object.getPrototypeOf(t).constructor;return n===Object&&e<10?"{ "+Object.entries(t).map(([t,n])=>t+" = "+b(n,e+1)).join("\n  ")+" }":n.name}}return String(t)}Symbol.iterator;class O{get name(){return this.cases()[this.tag]}toJSON(){return 0===this.fields.length?this.name:[this.name].concat(this.fields)}toString(){if(0===this.fields.length)return this.name;{let t="",e=!0;if(1===this.fields.length){const n=b(this.fields[0]);e=n.indexOf(" ")>=0,t=n}else t=this.fields.map(t=>b(t)).join(", ");return this.name+(e?" (":" ")+t+(e?")":"")}}GetHashCode(){const t=this.fields.map(t=>c(t));return t.splice(0,0,f(this.tag)),l(t)}Equals(t){return this===t||!!i(this,t)&&(this.tag===t.tag&&h(this.fields,t.fields))}CompareTo(t){return this===t?0:i(this,t)?this.tag===t.tag?y(this.fields,t.fields):this.tag<t.tag?-1:1:-1}}function j(t){const e={},n=Object.keys(t);for(let r=0;r<n.length;r++)e[n[r]]=t[n[r]];return e}function S(t){return"{ "+Object.entries(t).map(([t,e])=>t+" = "+b(e)).join("\n  ")+" }"}function w(t){return l(Object.values(t).map(t=>c(t)))}function P(t,e){if(t===e)return!0;if(i(t,e)){const n=Object.keys(t);for(let r=0;r<n.length;r++)if(!g(t[n[r]],e[n[r]]))return!1;return!0}return!1}function T(t,e){if(t===e)return 0;if(i(t,e)){const n=Object.keys(t);for(let r=0;r<n.length;r++){const u=d(t[n[r]],e[n[r]]);if(0!==u)return u}return 0}return-1}class C{toJSON(){return j(this)}toString(){return S(this)}GetHashCode(){return w(this)}Equals(t){return P(this,t)}CompareTo(t){return T(this,t)}}class k{constructor(t,e,n,r,u,i,o){this.fullname=t,this.generics=e,this.construct=n,this.parent=r,this.fields=u,this.cases=i,this.enumCases=o}toString(){return function t(e){const n=null==e.generics||D(e)?[]:e.generics;return n.length>0?e.fullname+"["+n.map(e=>t(e)).join(",")+"]":e.fullname}(this)}GetHashCode(){return M(this)}Equals(t){return x(this,t)}}function v(t){return null!=t.generics?t.generics:[]}function M(t){return l([s(t.fullname),...v(t).map(M)])}function x(t,e){return""===t.fullname?""===e.fullname&&a(I(t),I(e),([t,e],[n,r])=>t===n&&x(e,r)):t.fullname===e.fullname&&a(v(t),v(e),x)}new k("System.Object"),new k("Microsoft.FSharp.Core.Unit"),new k("System.Char"),new k("System.String"),new k("System.Boolean"),new k("System.SByte"),new k("System.Byte"),new k("System.Int16"),new k("System.UInt16"),new k("System.Int32"),new k("System.UInt32"),new k("System.Single"),new k("System.Double"),new k("System.Decimal");function D(t){return t.fullname.endsWith("[]")}function I(t){if(null!=t.fields)return t.fields();throw new Error(t.fullname+" is not an F# record type")}class _ extends O{constructor(t,...e){super(),this.tag=0|t,this.fields=e}cases(){return["PluginId"]}}class E extends C{constructor(t){super(),this.Id=t}}function G(){return new E(new _(0,"THE_PLUGIN_ID"))}function H(t){globalThis.GlobalPlugin=t}H(G())}]);
"""

let loadPlugin () =
    Promise.create(fun res _ ->
        let scriptElement: HTMLScriptElement = downcast Dom.document.createElement("script")
//        scriptElement.onload <- fun _ -> res ()
        scriptElement.innerHTML <- pluginCode
        Dom.document.getElementById("plugin-container").appendChild(scriptElement) |> ignore
        JS.setTimeout res 1000 |> ignore
    )
    |> Async.AwaitPromise
    

[<Emit """
globalThis.GlobalPlugin
""">]
let getGlobalPlugin () : Plugin = jsNative


async {
    do! loadPlugin ()
    let plugin = getGlobalPlugin ()

    let expectedId = PluginId "THE_PLUGIN_ID"
    let actualId = plugin.Id
    let controlId = PluginId "THE_PLUGIN_ID" // another instance, for check if there is no instance equality issue

    printfn "actualId = %A" actualId
    printfn "expectedId = %A" expectedId
    printfn "controlId = %A" controlId
    printfn "(expectedId = actualId) = %b" (expectedId = actualId)
    printfn "(expectedId = controlId) = %b" (expectedId = controlId)
    
}
|> Async.StartImmediate
