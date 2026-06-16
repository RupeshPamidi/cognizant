// Exercise 14 - jQuery demo (if jQuery available)
if(window.jQuery){ $('#app').html('<button id="registerBtn">Register (jQuery)</button>'); $('#registerBtn').click(()=>{ alert('Registered via jQuery'); $('#app').fadeOut(200).fadeIn(400); }); } else { document.getElementById('app').innerHTML='<p>jQuery not loaded. Include it to try jQuery tasks.</p>'; }
