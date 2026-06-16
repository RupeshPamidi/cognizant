// Exercise 09 - Async & Fetch
const app = document.getElementById('app');
app.innerHTML = '<div id="spinner">Loading events...</div>';
fetch('https://jsonplaceholder.typicode.com/posts?_limit=5')
.then(res=>res.json())
.then(data=>{ document.getElementById('spinner').remove(); data.forEach(d=>{ const p=document.createElement('p'); p.textContent=d.title; app.appendChild(p); }); })
.catch(err=>{ document.getElementById('spinner').textContent='Failed to load'; console.error(err); });
async function loadAsync(){ try{ const res=await fetch('https://jsonplaceholder.typicode.com/posts?_limit=3'); const jsn=await res.json(); console.log('Async loaded', jsn.length); } catch(e){ console.error(e); } }
loadAsync();
