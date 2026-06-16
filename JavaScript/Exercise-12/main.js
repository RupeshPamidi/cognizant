// Exercise 12 - AJAX & Fetch POST
const app=document.getElementById('app');
app.innerHTML=`<button id="send">Send Registration</button><div id="status"></div>`;
document.getElementById('send').addEventListener('click', ()=>{
  const payload={name:'Test User',event:'Workshop'};
  document.getElementById('status').textContent='Sending...';
  setTimeout(()=>{
    fetch('https://jsonplaceholder.typicode.com/posts',{method:'POST',body:JSON.stringify(payload),headers:{'Content-Type':'application/json'}})
    .then(r=>r.json()).then(j=>{ document.getElementById('status').textContent='Success: '+j.id; }).catch(e=>{ document.getElementById('status').textContent='Failed'; });
  }, 800);
});
