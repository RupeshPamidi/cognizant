// Exercise 13 - Debugging
console.log('Debugging page loaded');
function submit(){ const data={a:1}; console.log('Submitting',data); debugger; }
window.submitForDebug = submit;
