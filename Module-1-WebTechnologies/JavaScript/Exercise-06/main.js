// Exercise 06 - Arrays & Methods
let events = [ {name:'Music Night', category:'music'}, {name:'Bake Off', category:'food'} ];
function add(e){ events.push(e); }
const music = events.filter(ev=>ev.category==='music');
const cards = events.map(ev=>`${ev.category.toUpperCase()}: ${ev.name}`);
console.log(music, cards);
