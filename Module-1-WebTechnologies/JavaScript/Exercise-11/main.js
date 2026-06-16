// Exercise 11 - Forms
const app = document.getElementById('app');
app.innerHTML = `<form id="reg"><input name="name" required placeholder="Name"><input name="email" type="email" required placeholder="Email"><button>Submit</button></form><div id="err"></div>`;
const form=document.getElementById('reg');
form.addEventListener('submit',(e)=>{ e.preventDefault(); const data=new FormData(form); const name=data.get('name'); if(name.length<2){ document.getElementById('err').textContent='Name too short'; return; } console.log('Submitted',Object.fromEntries(data)); document.getElementById('err').textContent='Success'; });
