// Exercise 03 - Conditionals & Loops
const events = [ {name:'Old Event', date:'2020-01-01', seats:0}, {name:'Music Night', date:'2026-08-01', seats:10} ];
const today = new Date();
function displayUpcoming(list){ list.forEach(e=>{ try{ const ed = new Date(e.date); if(isNaN(ed)) throw new Error('Invalid date'); if(ed < today || e.seats<=0){ console.log('Skipping', e.name); } else { console.log('Showing', e.name); } } catch(err){ console.error('Error for event', e, err); } }); }
displayUpcoming(events);
