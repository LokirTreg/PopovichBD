/**
 * Copyright (c) Tiny Technologies, Inc. All rights reserved.
 * Licensed under the LGPL or a commercial license.
 * For LGPL see License.txt in the project root for license information.
 * For commercial licenses see https://www.tiny.cloud/
 *
 * Version: 5.1.1 (2019-10-28)
 */
!function(f){"use strict";var r=function(t){function n(){return e}var e=t;return{get:n,set:function(t){e=t},clone:function(){return r(n())}}},t=tinymce.util.Tools.resolve("tinymce.PluginManager"),u=function(){return(u=Object.assign||function(t){for(var n,e=1,r=arguments.length;e<r;e++)for(var o in n=arguments[e])Object.prototype.hasOwnProperty.call(n,o)&&(t[o]=n[o]);return t}).apply(this,arguments)};function n(){}function a(t){return function(){return t}}function o(t){return t}function e(){return l}var i,c=a(!1),s=a(!0),l=(i={fold:function(t,n){return t()},is:c,isSome:c,isNone:s,getOr:g,getOrThunk:m,getOrDie:function(t){throw new Error(t||"error: getOrDie called on none.")},getOrNull:a(null),getOrUndefined:a(undefined),or:g,orThunk:m,map:e,each:n,bind:e,exists:c,forall:s,filter:e,equals:d,equals_:d,toArray:function(){return[]},toString:a("none()")},Object.freeze&&Object.freeze(i),i);function d(t){return t.isNone()}function m(t){return t()}function g(t){return t}function p(n){return function(t){return function(t){if(null===t)return"null";var n=typeof t;return"object"==n&&(Array.prototype.isPrototypeOf(t)||t.constructor&&"Array"===t.constructor.name)?"array":"object"==n&&(String.prototype.isPrototypeOf(t)||t.constructor&&"String"===t.constructor.name)?"string":n}(t)===n}}function h(t,n){return-1<function(t,n){return lt.call(t,n)}(t,n)}function v(t,n){for(var e=t.length,r=new Array(e),o=0;o<e;o++){var a=t[o];r[o]=n(a,o)}return r}function y(t,n){for(var e=0,r=t.length;e<r;e++){n(t[e],e)}}function b(t,n){for(var e=[],r=0,o=t.length;r<o;r++){var a=t[r];n(a,r)&&e.push(a)}return e}function k(t,n,e){return function(t,n){for(var e=t.length-1;0<=e;e--){n(t[e],e)}}(t,function(t){e=n(e,t)}),e}function O(t,n){for(var e=0,r=t.length;e<r;++e){if(!0!==n(t[e],e))return!1}return!0}function w(t){var n=[],e=[];return y(t,function(t){t.fold(function(t){n.push(t)},function(t){e.push(t)})}),{errors:n,values:e}}function x(t){return"inline-command"===t.type||"inline-format"===t.type}function C(t){return"block-command"===t.type||"block-format"===t.type}function E(t){return function(t,n){var e=st.call(t,0);return e.sort(n),e}(t,function(t,n){return t.start.length===n.start.length?0:t.start.length>n.start.length?-1:1})}function T(o){function a(t){return yt.error({message:t,pattern:o})}function t(t,n,e){if(o.format===undefined)return o.cmd!==undefined?it(o.cmd)?yt.value(e(o.cmd,o.value)):a(t+" pattern has non-string `cmd` parameter"):a(t+" pattern is missing both `format` and `cmd` parameters");var r=void 0;if(ft(o.format)){if(!O(o.format,it))return a(t+" pattern has non-string items in the `format` array");r=o.format}else{if(!it(o.format))return a(t+" pattern has non-string `format` parameter");r=[o.format]}return yt.value(n(r))}if(!ut(o))return a("Raw pattern is not an object");if(!it(o.start))return a("Raw pattern is missing `start` parameter");if(o.end===undefined)return o.replacement!==undefined?it(o.replacement)?0===o.start.length?a("Replacement pattern has empty `start` parameter"):yt.value({type:"inline-command",start:"",end:o.start,cmd:"mceInsertContent",value:o.replacement}):a("Replacement pattern has non-string `replacement` parameter"):0===o.start.length?a("Block pattern has empty `start` parameter"):t("Block",function(t){return{type:"block-format",start:o.start,format:t[0]}},function(t,n){return{type:"block-command",start:o.start,cmd:t,value:n}});if(!it(o.end))return a("Inline pattern has non-string `end` parameter");if(0===o.start.length&&0===o.end.length)return a("Inline pattern has empty `start` and `end` parameters");var e=o.start,r=o.end;return 0===r.length&&(r=e,e=""),t("Inline",function(t){return{type:"inline-format",start:e,end:r,format:t}},function(t,n){return{type:"inline-command",start:e,end:r,cmd:t,value:n}})}function R(t){return"block-command"===t.type?{start:t.start,cmd:t.cmd,value:t.value}:"block-format"===t.type?{start:t.start,format:t.format}:"inline-command"===t.type?"mceInsertContent"===t.cmd&&""===t.start?{start:t.end,replacement:t.value}:{start:t.start,end:t.end,cmd:t.cmd,value:t.value}:"inline-format"===t.type?{start:t.start,end:t.end,format:1===t.format.length?t.format[0]:t.format}:void 0}function N(t){return{inlinePatterns:b(t,x),blockPatterns:E(b(t,C))}}function P(){for(var t=[],n=0;n<arguments.length;n++)t[n]=arguments[n];var e=kt.console;e&&(e.error?e.error.apply(e,t):e.log.apply(e,t))}function S(t){var n=function(t,n){return gt(t,n)?at.from(t[n]):at.none()}(t,"textpattern_patterns").getOr(Ot);if(!ft(n))return P("The setting textpattern_patterns should be an array"),{inlinePatterns:[],blockPatterns:[]};var e=w(v(n,T));return y(e.errors,function(t){return P(t.message,t.pattern)}),N(e.values)}function M(t){var n=t.getParam("forced_root_block","p");return!1===n?"":!0===n?"p":n}function A(t){return t.nodeType===f.Node.TEXT_NODE}function I(t,n,e,r){void 0===r&&(r=!0);var o=n.startContainer.parentNode,a=n.endContainer.parentNode;n.deleteContents(),r&&!e(n.startContainer)&&(A(n.startContainer)&&0===n.startContainer.data.length&&t.remove(n.startContainer),A(n.endContainer)&&0===n.endContainer.data.length&&t.remove(n.endContainer),Tt(t,o,e),o!==a&&Tt(t,a,e))}function j(t,n){var e=n.get(t);return ft(e)&&function(t){return 0===t.length?at.none():at.some(t[0])}(e).exists(function(t){return gt(t,"block")})}function B(t){return 0===t.start.length}function D(t,n){return function(t,n){for(var e=0,r=t.length;e<r;e++){var o=t[e];if(n(o,e))return at.some(o)}return at.none()}(t,function(t){return 0===n.indexOf(t.start)&&(!function(t){return gt(t,"end")}(t)||!t.end||n.lastIndexOf(t.end)===n.length-t.end.length)})}function _(t,n){var e=at.from(t.dom.getParent(n.startContainer,t.dom.isBlock));return""===M(t)?e.orThunk(function(){return at.some(t.getBody())}):e}function U(t,n){return{element:t,offset:n}}function q(t,n){function e(t){for(var n=r[t]();n&&n.nodeType!==f.Node.TEXT_NODE;)n=r[t]();return n&&n.nodeType===f.Node.TEXT_NODE?at.some(n):at.none()}var r=new Et(t,n);return{next:function(){return e("next")},prev:function(){return e("prev")},prev2:function(){return e("prev2")}}}function L(t,n,e){return A(t)&&0<=n?at.some(U(t,n)):q(t,e).prev().map(function(t){return U(t,t.data.length)})}function V(t,n,e){if(A(n)&&(e<0||e>n.data.length))return[];for(var r=[e],o=n;o!==t&&o.parentNode;){for(var a=o.parentNode,i=0;i<a.childNodes.length;i++)if(a.childNodes[i]===o){r.push(i);break}o=a}return o===t?r.reverse():[]}function W(t,n,e,r,o){return{start:V(t,n,e),end:V(t,r,o)}}function X(t,n){var e=n.slice(),r=e.pop();return function(t,n,e){return y(t,function(t){e=n(e,t)}),e}(e,function(t,n){return t.bind(function(t){return at.from(t.childNodes[n])})},at.some(t)).bind(function(t){return A(t)&&0<=r&&t.data.length,at.some({node:t,offset:r})})}function z(n,e){return X(n,e.start).bind(function(t){var o=t.node,a=t.offset;return X(n,e.end).map(function(t){var n=t.node,e=t.offset,r=f.document.createRange();return r.setStart(o,a),r.setEnd(n,e),r})})}function F(r,o,t){q(o,o).next().each(function(e){Nt(e,t.start.length,o).each(function(t){var n=r.createRng();n.setStart(e,0),n.setEnd(t.element,t.offset),I(r,n,function(t){return t===o})})})}function G(n,t){if(0!==t.length){var e=n.selection.getBookmark();y(t,function(t){return function(n,t){var e=n.dom,r=t.pattern,o=z(e.getRoot(),t.range).getOrDie("Unable to resolve path range");return _(n,o).each(function(t){"block-format"===r.type?j(r.format,n.formatter)&&n.undoManager.transact(function(){F(n.dom,t,r),n.formatter.apply(r.format)}):"block-command"===r.type&&n.undoManager.transact(function(){F(n.dom,t,r),n.execCommand(r.cmd,!1,r.value)})}),!0}(n,t)}),n.selection.moveToBookmark(e)}}function H(t,n){return t.create("span",{"data-mce-type":"bookmark",id:n})}function J(t,n){var e=t.createRng();return e.setStartAfter(n.start),e.setEndBefore(n.end),e}function K(t,n,e){var r=z(t.getRoot(),e).getOrDie("Unable to resolve path range"),o=r.startContainer,a=r.endContainer,i=0===r.endOffset?a:a.splitText(r.endOffset),u=0===r.startOffset?o:o.splitText(r.startOffset);return{prefix:n,end:i.parentNode.insertBefore(H(t,n+"-end"),i),start:u.parentNode.insertBefore(H(t,n+"-start"),u)}}function Q(t,n,e){Tt(t,t.get(n.prefix+"-end"),e),Tt(t,t.get(n.prefix+"-start"),e)}function Y(t,e,n,r,o,a){if(void 0===a&&(a=!1),0!==e.start.length||a)return L(n,r,o).bind(function(n){return function(t,n,e,r,o){var a=new Et(n,o);return Mt(t,n,at.some(e),r,a.prev,at.none())}(t,n.element,n.offset,function(f,c,s){return function(e,r,t,n){if(r===c)return e.abort();var o=t.substring(0,n.getOr(t.length)),a=o.lastIndexOf(s.charAt(s.length-1)),i=o.lastIndexOf(s);if(-1===i)return-1!==a?Rt(r,a+1-s.length,c).fold(function(){return e.kontinue()},function(t){var n=f.createRng();return n.setStart(t.element,t.offset),n.setEnd(r,a+1),n.toString()===s?e.finish(n):e.kontinue()}):e.kontinue();var u=f.createRng();return u.setStart(r,i),u.setEnd(r,i+s.length),e.finish(u)}}(t,o,e.start),o).fold(at.none,at.none,at.some).bind(function(t){if(a){if(t.endContainer===n.element&&t.endOffset===n.offset)return at.none();if(0===n.offset&&t.endContainer.textContent.length===t.endOffset)return at.none()}return at.some(t)})});var i=t.createRng();return i.setStart(n,r),i.setEnd(n,r),at.some(i)}function Z(a,i,u){var f=a.dom,c=f.getRoot(),s=u.pattern,l=u.position.element,d=u.position.offset;return Rt(l,d-u.pattern.end.length,i).bind(function(t){var e=W(c,t.element,t.offset,l,d);if(B(s))return at.some({matches:[{pattern:s,startRng:e,endRng:e}],position:t});var n=It(a,u.remainingPatterns,t.element,t.offset,i),r=n.getOr({matches:[],position:t}),o=r.position;return Y(f,s,o.element,o.offset,i,n.isNone()).map(function(t){var n=function(t,n){return W(t,n.startContainer,n.startOffset,n.endContainer,n.endOffset)}(c,t);return{matches:r.matches.concat([{pattern:s,startRng:n,endRng:e}]),position:U(t.startContainer,t.startOffset)}})})}function $(n,t,e){n.selection.setRng(e),"inline-format"===t.type?y(t.format,function(t){n.formatter.apply(t)}):n.execCommand(t.cmd,!1,t.value)}function tt(o,t){var a=function(t){var n=(new Date).getTime();return t+"_"+Math.floor(1e9*Math.random())+ ++At+String(n)}("mce_textpattern"),i=k(t,function(t,n){var e=K(o,a+"_end"+t.length,n.endRng);return t.concat([u(u({},n),{endMarker:e})])},[]);return k(i,function(t,n){var e=i.length-t.length-1,r=B(n.pattern)?n.endMarker:K(o,a+"_start"+e,n.startRng);return t.concat([u(u({},n),{startMarker:r})])},[])}function nt(e,r,o){var a=e.selection.getRng();return!1===a.collapsed?[]:_(e,a).bind(function(t){var n=a.startOffset-(o?1:0);return It(e,r,a.startContainer,n,t)}).fold(function(){return[]},function(t){return t.matches})}function et(r,t){if(0!==t.length){var o=r.dom,n=r.selection.getBookmark(),e=tt(o,t);y(e,function(t){function n(t){return t===e}var e=o.getParent(t.startMarker.start,o.isBlock);B(t.pattern)?function(t,n,e,r){var o=J(t.dom,e);I(t.dom,o,r),$(t,n,o)}(r,t.pattern,t.endMarker,n):function(t,n,e,r,o){var a=t.dom,i=J(a,r),u=J(a,e);I(a,u,o),I(a,i,o);var f={prefix:e.prefix,start:e.end,end:r.start},c=J(a,f);$(t,n,c)}(r,t.pattern,t.startMarker,t.endMarker,n),Q(o,t.endMarker,n),Q(o,t.startMarker,n)}),r.selection.moveToBookmark(n)}}function rt(t,n,e){for(var r=0;r<t.length;r++)if(e(t[r],n))return!0}var ot=function(e){function t(){return o}function n(t){return t(e)}var r=a(e),o={fold:function(t,n){return n(e)},is:function(t){return e===t},isSome:s,isNone:c,getOr:r,getOrThunk:r,getOrDie:r,getOrNull:r,getOrUndefined:r,or:t,orThunk:t,map:function(t){return ot(t(e))},each:function(t){t(e)},bind:n,exists:n,forall:n,filter:function(t){return t(e)?o:l},toArray:function(){return[e]},toString:function(){return"some("+e+")"},equals:function(t){return t.is(e)},equals_:function(t,n){return t.fold(c,function(t){return n(e,t)})}};return o},at={some:ot,none:e,from:function(t){return null===t||t===undefined?l:ot(t)}},it=p("string"),ut=p("object"),ft=p("array"),ct=p("function"),st=Array.prototype.slice,lt=Array.prototype.indexOf,dt=(ct(Array.from)&&Array.from,Object.keys),mt=Object.hasOwnProperty,gt=function(t,n){return mt.call(t,n)},pt=function(i){if(!ft(i))throw new Error("cases must be an array");if(0===i.length)throw new Error("there must be at least one case");var u=[],e={};return y(i,function(t,r){var n=dt(t);if(1!==n.length)throw new Error("one and only one name per case");var o=n[0],a=t[o];if(e[o]!==undefined)throw new Error("duplicate key detected:"+o);if("cata"===o)throw new Error("cannot have a case named cata (sorry)");if(!ft(a))throw new Error("case arguments must be an array");u.push(o),e[o]=function(){var t=arguments.length;if(t!==a.length)throw new Error("Wrong number of arguments to case "+o+". Expected "+a.length+" ("+a+"), got "+t);for(var e=new Array(t),n=0;n<e.length;n++)e[n]=arguments[n];return{fold:function(){if(arguments.length!==i.length)throw new Error("Wrong number of arguments to fold. Expected "+i.length+", got "+arguments.length);return arguments[r].apply(null,e)},match:function(t){var n=dt(t);if(u.length!==n.length)throw new Error("Wrong number of arguments to match. Expected: "+u.join(",")+"\nActual: "+n.join(","));if(!O(u,function(t){return h(n,t)}))throw new Error("Not all branches were specified when using match. Specified: "+n.join(", ")+"\nRequired: "+u.join(", "));return t[o].apply(null,e)},log:function(t){f.console.log(t,{constructors:u,constructor:o,params:e})}}}}),e},ht=(pt([{bothErrors:["error1","error2"]},{firstError:["error1","value2"]},{secondError:["value1","error2"]},{bothValues:["value1","value2"]}]),function(e){return{is:function(t){return e===t},isValue:s,isError:c,getOr:a(e),getOrThunk:a(e),getOrDie:a(e),or:function(t){return ht(e)},orThunk:function(t){return ht(e)},fold:function(t,n){return n(e)},map:function(t){return ht(t(e))},mapError:function(t){return ht(e)},each:function(t){t(e)},bind:function(t){return t(e)},exists:function(t){return t(e)},forall:function(t){return t(e)},toOption:function(){return at.some(e)}}}),vt=function(e){return{is:c,isValue:c,isError:s,getOr:o,getOrThunk:function(t){return t()},getOrDie:function(){return function(t){return function(){throw new Error(t)}}(String(e))()},or:function(t){return t},orThunk:function(t){return t()},fold:function(t,n){return t(e)},map:function(t){return vt(e)},mapError:function(t){return vt(t(e))},each:n,bind:function(t){return vt(e)},exists:c,forall:s,toOption:at.none}},yt={value:ht,error:vt,fromOption:function(t,n){return t.fold(function(){return vt(n)},ht)}},bt=function(r){return{setPatterns:function(t){var n=w(v(t,T));if(0<n.errors.length){var e=n.errors[0];throw new Error(e.message+":\n"+JSON.stringify(e.pattern,null,2))}r.set(N(n.values))},getPatterns:function(){return function f(){for(var t=0,n=0,e=arguments.length;n<e;n++)t+=arguments[n].length;var r=Array(t),o=0;for(n=0;n<e;n++)for(var a=arguments[n],i=0,u=a.length;i<u;i++,o++)r[o]=a[i];return r}(v(r.get().inlinePatterns,R),v(r.get().blockPatterns,R))}}},kt="undefined"!=typeof f.window?f.window:Function("return this;")(),Ot=[{start:"*",end:"*",format:"italic"},{start:"**",end:"**",format:"bold"},{start:"#",format:"h1"},{start:"##",format:"h2"},{start:"###",format:"h3"},{start:"####",format:"h4"},{start:"#####",format:"h5"},{start:"######",format:"h6"},{start:"1. ",cmd:"InsertOrderedList"},{start:"* ",cmd:"InsertUnorderedList"},{start:"- ",cmd:"InsertUnorderedList"}],wt=tinymce.util.Tools.resolve("tinymce.util.Delay"),xt=tinymce.util.Tools.resolve("tinymce.util.VK"),Ct=tinymce.util.Tools.resolve("tinymce.util.Tools"),Et=tinymce.util.Tools.resolve("tinymce.dom.TreeWalker"),Tt=function(t,n,e){if(n&&t.isEmpty(n)&&!e(n)){var r=n.parentNode;t.remove(n),Tt(t,r,e)}},Rt=function(t,e,r){if(!A(t))return at.none();var n=t.textContent;return 0<=e&&e<=n.length?at.some(U(t,e)):q(t,r).prev().bind(function(t){var n=t.textContent;return Rt(t,e+n.length,r)})},Nt=function(t,n,e){if(!A(t))return at.none();var r=t.textContent;return n<=r.length?at.some(U(t,n)):q(t,e).next().bind(function(t){return Nt(t,n-r.length,e)})},Pt=pt([{aborted:[]},{edge:["element"]},{success:["info"]}]),St=pt([{abort:[]},{kontinue:[]},{finish:["info"]}]),Mt=function(n,e,t,r,o,a){function i(){return a.fold(Pt.aborted,Pt.edge)}function u(){var t=o();return t?Mt(n,t,at.none(),r,o,at.some(e)):i()}if(function(t,n){return t.isBlock(n)||h(["BR","IMG","HR","INPUT"],n.nodeName)||"false"===t.getContentEditable(n)}(n,e))return i();if(A(e)){var f=e.textContent;return r(St,e,f,t).fold(Pt.aborted,function(){return u()},Pt.success)}return u()},At=0,It=function(c,s,l,d,m){var g=c.dom;return L(l,d,g.getRoot()).bind(function(t){var n=g.createRng();n.setStart(m,0),n.setEnd(l,d);for(var e,r,o=n.toString(),a=0;a<s.length;a++){var i=s[a];if(e=o,r=i.end,function(t,n,e){return""===n||!(t.length<n.length)&&t.substr(e,e+n.length)===n}(e,r,e.length-r.length)){var u=s.slice();u.splice(a,1);var f=Z(c,m,{pattern:i,remainingPatterns:u,position:t});if(f.isSome())return f}}return at.none()})},jt=function(e,t){if(!e.selection.isCollapsed())return!1;var r=nt(e,t.inlinePatterns,!1),o=function(r,t){var o=r.dom,n=r.selection.getRng();return _(r,n).filter(function(t){var n=M(r),e=""===n&&o.is(t,"body")||o.is(t,n);return null!==t&&e}).bind(function(n){var e=n.textContent;return D(t,e).map(function(t){return Ct.trim(e).length===t.start.length?[]:[{pattern:t,range:W(o.getRoot(),n,0,n,0)}]})}).getOr([])}(e,t.blockPatterns);return(0<o.length||0<r.length)&&(e.undoManager.add(),e.undoManager.extra(function(){e.execCommand("mceInsertNewLine")},function(){e.insertContent("\ufeff"),et(e,r),G(e,o);var t=e.selection.getRng(),n=L(t.startContainer,t.startOffset,e.dom.getRoot());e.execCommand("mceInsertNewLine"),n.each(function(t){"\ufeff"===t.element.data.charAt(t.offset-1)&&(t.element.deleteData(t.offset-1,1),Tt(e.dom,t.element.parentNode,function(t){return t===e.dom.getRoot()}))})}),!0)},Bt=function(t,n){var e=nt(t,n.inlinePatterns,!0);0<e.length&&t.undoManager.transact(function(){et(t,e)})},Dt=function(t,n){return rt(t,n,function(t,n){return t.charCodeAt(0)===n.charCode})},_t=function(t,n){return rt(t,n,function(t,n){return t===n.keyCode&&!1===xt.modifierPressed(n)})},Ut=function(n,e){var r=[",",".",";",":","!","?"],o=[32];n.on("keydown",function(t){13!==t.keyCode||xt.modifierPressed(t)||jt(n,e.get())&&t.preventDefault()},!0),n.on("keyup",function(t){_t(o,t)&&Bt(n,e.get())}),n.on("keypress",function(t){Dt(r,t)&&wt.setEditorTimeout(n,function(){Bt(n,e.get())})})};!function qt(){t.add("textpattern",function(t){var n=r(S(t.settings));return Ut(t,n),bt(n)})}()}(window);