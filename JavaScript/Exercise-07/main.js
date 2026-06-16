// Exercise 07 - DOM Manipulation
const app = document.getElementById('app');
let events = [ {id:1,name:'Music Night',seats:10}, {id:2,name:'Workshop',seats:0} ];
function render(){ app.innerHTML=''; events.forEach(ev=>{ const card=document.createElement('div'); card.className='event'; card.innerHTML=`<h3>${ev.name}</h3><p>Seats: <span>${ev.seats}</span></p><button data-id="${ev.id}">Register</button>`; app.appendChild(card); }); attachHandlers(); }
function attachHandlers(){ app.querySelectorAll('button').forEach(b=>b.addEventListener('click', (e)=>{ const id=+e.target.dataset.id; register(id); })); }
function register(id){ const ev=events.find(x=>x.id===id); if(ev && ev.seats>0){ ev.seats--; render(); } else { alert('No seats available'); } }
render();
