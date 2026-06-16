// Exercise 05 script.js
$(function(){
  $('#colorBtn').on('click', function(){ $('#colorBox').css('background','red'); });
  $('#colorBox').on('dblclick', function(){ $(this).css('background','white'); });
});
