// Exercise 03 script.js
$(function(){
  $('.box').hide();
  $('#showBtn').on('click', function(){ $('.box').show(); });
  $('#hideBtn').on('click', function(){ $('.box').hide(); });
  $('#fadeBtn').on('click', function(){ $('.box').fadeToggle(); });
  $('#chainBtn').on('click', function(){ $('.box').slideUp().delay(1000).slideDown(); });
});
