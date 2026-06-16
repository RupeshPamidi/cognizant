// Exercise 02 - Data Types
const eventName = 'Community Cleanup';
const eventDate = '2026-07-10';
let seats = 25;
const info = `Event: ${eventName} on ${eventDate} - Seats left: ${seats}`;
console.log(info);
function register(){ if(seats>0){ seats--; console.log('Registered, seats now', seats);} else { console.log('No seats'); } }
