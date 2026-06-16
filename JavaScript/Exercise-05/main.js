// Exercise 05 - Objects & Prototype
class Event{ constructor(name,date,seats){ this.name=name; this.date=date; this.seats=seats; }
}
Event.prototype.checkAvailability = function(){ return this.seats>0; };
const e = new Event('Workshop', '2026-09-01', 12);
console.log(Object.entries(e));
