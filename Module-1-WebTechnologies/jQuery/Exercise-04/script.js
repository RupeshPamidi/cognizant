// Exercise 04 script.js
$(function(){
  $('#itemForm').on('submit', function(e){ e.preventDefault(); const v=$('#itemInput').val(); if(v.trim()){ $('#itemList').append($('<li>').text(v)); $('#itemInput').val(''); } });
  $('#removeAll').on('click', function(){ $('#itemList').empty(); });
});
