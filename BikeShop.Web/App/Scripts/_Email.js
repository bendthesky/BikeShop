﻿jQuery(function ($) {
    $("#contact_form").submit(function () {
        var email = $("#email").val(); // get email field value
        var name = $("#name").val(); // get name field value
        var msg = $("#msg").val(); // get message field value
        $.ajax(
        {
            type: "POST",
            url: "https://mandrillapp.com/api/1.0/messages/send.json",
            data: {
                'key': 'meZV0ekohE16Bse4HFFm2Q',
                'message': {
                    'from_email': email,
                    'from_name': name,
                    'headers': {
                        'Reply-To': email
                    },
                    'subject': 'Website Contact Form Submission',
                    'text': msg,
                    'to': [
                    {
                        'email': 'thebikeshoppe1@gmail.com',
                        'name': 'The Bike Shoppe',
                        'type': 'to'
                    }]
                }
            }
        })
        .done(function (response) {
            alert('Your message has been sent. Thank you!'); // show success message
            $("#name").val(''); // reset field after successful submission
            $("#email").val(''); // reset field after successful submission
            $("#msg").val(''); // reset field after successful submission
        })
        .fail(function (response) {
            alert('Error sending message.');
        });
        //return false; // prevent page refresh
    });
});