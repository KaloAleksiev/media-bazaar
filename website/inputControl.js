$( document ).ready((function() {

    //form input control for creating the initial quiz
    $('#passCheckForm').submit(function(e){
        
        var pass = $('#oldPasswordTB').val();

        $(".text-danger").remove();

        if(pass.length < 1){
            e.preventDefault();
            $('#oldPasswordTB').after('<br><span class="text-danger">Enter your password first!</span>');
        }
    });
}));

$( document ).ready((function() {

    //form input control for creating the initial quiz
    $('#changeEmailForm').submit(function(e){
        
        var pass = $('#passwordTB').val();
        var email = $('#emailTB').val();
        var confirmPass = $('#confirmPasswordTB').val();

        $(".text-danger").remove();

        if(email.length < 1){
            e.preventDefault();
            $('#emailTB').after('<br><span class="text-danger">Email required!</span>');
        }
        if(pass.length < 1){
            e.preventDefault();
            $('#passwordTB').after('<br><span class="text-danger">Password required!</span>');
        }
        if(confirmPass.length < 1){
            e.preventDefault();
            $('#confirmPasswordTB').after('<br><span class="text-danger">You need to confirm your password!</span>');
        }     
    });
}));

$( document ).ready((function() {

    //form input control for creating the initial quiz
    $('#changeAddressForm').submit(function(e){
        
        var city = $('#cityTB').val();
        var zipcode = $('#zipcodeTB').val();
        var address = $('#addressTB').val();

        $(".text-danger").remove();

        if(city.length < 1){
            e.preventDefault();
            $('#cityTB').after('<br><span class="text-danger">City required!</span>');
        }
        if(zipcode.length < 1){
            e.preventDefault();
            $('#zipcodeTB').after('<br><span class="text-danger">Zipcode reuquired!</span>');
        }
        if(address.length < 1){
            e.preventDefault();
            $('#addressTB').after('<br><span class="text-danger">Address required!</span>');
        }     
    });
    
}));




