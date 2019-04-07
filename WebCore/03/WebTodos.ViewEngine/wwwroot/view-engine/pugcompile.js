var pug = require('pug');

module.exports = function (callback, viewPath, model, viewDictionary, modelState, opts) {
	// Invoke some external transpiler (e.g., an NPM module) then:
    var pugCompiledFunction = pug.compileFile(viewPath, opts);

    model = model || {};
    model.ViewData = viewDictionary;
    model.ModelState = modelState;
	callback(null, pugCompiledFunction(model));	
};