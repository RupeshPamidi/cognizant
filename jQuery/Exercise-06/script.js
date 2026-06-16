// Exercise 06 script.js
$(function(){
  $('#box').on('click', function(){ $(this).css('background','#bbf7d0'); $('#out').text('Box clicked'); });
  $('#box').on('dblclick', function(){ $(this).css('background',''); $('#out').text('Box double-clicked'); });
  $('#box').on('mouseenter', function(){ $(this).css('border-color','#f97316'); });
  $('#box').on('mouseleave', function(){ $(this).css('border-color','#374151'); $('#out').text(''); });
  $('#txt').on('keypress', function(){ $('#out').text('Typing... ' + $(this).val().length); });
});
