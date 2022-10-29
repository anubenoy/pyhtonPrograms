$(document).ready(function() {

    $('#reset').click(function() {
        $(".error").hide(); //hide the error messages when rest button is clicked
    });

    $('#form').submit(function(e) {
      e.preventDefault();
      var name = $('#name').val();
      var email = $('#email').val();
      var password = $('#password').val();
      var confirmpassword = $('#confirmpassword').val(); 
      var telephonenumber = $('#telephonenumber').val();

      $(".error").remove();
  
      if (name.trim() == "") {
        $('#name').after('<span class="error">Name is required</span>');
      }

      if (email.trim() == "") {
        $('#email').after('<span class="error">Email is required</span>');
      } else {
        var regExEmail = /^[a-z0-9]+\@[a-z]+\.[a-z]+$/; //regex email
        var validEmail = regExEmail.test(email);
        if (!validEmail) {
          $('#email').after('<span class="error">Enter a valid email</span>');
        }
      }

      if (password == "") {
       $('#password').after('<span class="error">Password is required</span>');
      }
      if (confirmpassword == "") {
        $('#confirmpassword').after('<span class="error">Confirm Password is required</span>');
       }
       else{
        if(password != confirmpassword){
            $('#confirmpassword').after('<span class="error">Passwords should match</span>');
        }
       }

       if(telephonenumber != ""){
        var regExTelephone = /^\+[0-9]\([0-9]{3}\)[0-9]{3}\-[0-9]{4}$/; //regex phone number
        var validnumber = regExTelephone.test(telephonenumber);
        if (!validnumber) {
          $('#telephonenumber').after('<span class="error">Enter a valid Phone number</span>');
        }
       }

    });
  });