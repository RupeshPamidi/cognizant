// Exercise 10 - Modern JS Features
const add = (a=0,b=0)=>a+b;
const events=[{name:'X'},{name:'Y'}];
const clone=[...events];
const [{name: firstName}]=events;
console.log(add(1,2), clone, firstName);
