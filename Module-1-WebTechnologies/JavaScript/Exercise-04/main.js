// Exercise 04 - Functions & Closures
function addEvent(list,event){ list.push(event); }
function registerUser(){ let count=0; return function(){ count++; return count; }; }
const registrationsForCategory = (function(){ const counts={}; return function(cat){ counts[cat]=(counts[cat]||0)+1; return counts[cat]; }})();
function filterEventsByCategory(events, category, cb){ return events.filter(e=>e.category===category).filter(cb||(()=>true)); }
