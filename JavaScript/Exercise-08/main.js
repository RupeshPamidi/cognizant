// Exercise 08 - Event Handling
const app = document.getElementById('app');
app.addEventListener('keydown', (e)=>{ if(e.key==='f'){ document.getElementById('desc').style.background='#fff3bf'; }});
function setupFilter(){ const sel=document.createElement('select'); sel.innerHTML='<option value="all">All</option><option value="music">Music</option>'; sel.onchange=function(){ console.log('Filter', this.value); }; app.prepend(sel); }
setupFilter();
