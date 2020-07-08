// Overrides for default JSIL functionality

// Override the initBrowserHooks function created in JSIL.Browser
// This function would usually prevent event propagation of most key presses and pass it to a canvas
// But since we aren't making a game, we don't want this (e.g. it stops opening devtools with F12)
// So override it with a function that does nothing.
var initBrowserHooks = function () { }